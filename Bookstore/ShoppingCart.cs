/**
    * @brief 
    * @file ShoppingCart.cs
    * @author Gizem Taşçı
    * @author Faruk Aydın
    * @date 2019-04-25
    */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public enum PaymentType{
        cash,credit,check
    }

    /**
    * @brief ShoppingCart class
    * Alışveriş işlemlerinin yapıldığı class.
    */
    public class ShoppingCart
    {
        /**
   * @brief  itemsToPurchase fuction
   * Alışveriş listesi bölümünün get set metotlarını tutar.
   *
   */
        public List<ItemToPurchase> itemsToPurchase { get; set; }
        /**
   * @brief  PaymentType fuction
   * Ödeme yöntemi bölümünün get set metotlarını tutar.
   *
   */
        public PaymentType PaymentType { get; set; }
        /**
           * @brief  CustomerID fuction
           * CustomerID bölümünün get set metotlarını tutar.
           *
           */
        public int CustomerID { get; set; }
        /**
           * @brief  ShoppingCart constructor fuction
           */
      
        public ShoppingCart()
        {
            itemsToPurchase = new List<ItemToPurchase>();
        }
        /**
          * @brief  PrintProducts function
          *ListView'e alışveriş sepetini yazdırır.
          *@param lv
          */
      
        public static void PrintProducts(ListView lv)
        {
            lv.Clear();
            lv.View = View.Details;
            lv.GridLines = true;
            lv.FullRowSelect = true;

            lv.Columns.Add("Ürün Adı", 270);
            lv.Columns.Add("Adet", 145);
            lv.Columns.Add("Fiyat", 135);
            foreach (ItemToPurchase item in Login.GetInstance.GetCustomer.WishList)
            {
                string[] row = { item.Product.Name, "x" + item.Quantity, (item.Product.Price).ToString("C") };
                var rowP = new ListViewItem(row);
                lv.Items.Add(rowP);
            }            
        }
        /**
          * @brief  AddToCart function
          *alışveriş sepetine ürün ekler.
          *@param id
          *@param quantity
          */
        
        public void AddToCart(long id, int quantity)
        {
            bool flag = false;
            for (int i = 0; i < itemsToPurchase.Count; i++)
            {
                if (id == itemsToPurchase[i].Product.ID)
                {
                    itemsToPurchase[i].Product.Price += quantity * (itemsToPurchase[i].Product.Price / itemsToPurchase[i].Quantity);
                    itemsToPurchase[i].Quantity += quantity;
                    flag = true;
                    break;
                }
            }
            for (int i = 0; i < FormAdmin.productList.Count; i++)
            {
                if (id == FormAdmin.productList[i].ID)
                {
                    if (!flag)
                    {
                        ItemToPurchase item = new ItemToPurchase();
                        item.Product = FormAdmin.productList[i].CloneIT();
                        item.Quantity = quantity;
                        item.Product.Price*=item.Quantity;
                        itemsToPurchase.Add(item);
                    }
                    FormAdmin.productList[i].Stock -= quantity;

                    if (FormAdmin.productList[i].Stock == 0)
                    {
                        FormAdmin.productList.RemoveAt(i);
                    }

                    return;
                }
            }
        }
        /**
         * @brief  RemoveProduct function
         *alışveriş sepetinden ürün çıkarıt.
         *@param name
         */
        public void RemoveProduct(string name)
        {           
            for (int i = 0; i < itemsToPurchase.Count; i++)
            {
                if (name == itemsToPurchase[i].Product.Name)
                {
                    for (int j = 0; j < FormAdmin.productList.Count; j++)
                    {
                        if (name == FormAdmin.productList[j].Name)
                        {
                            FormAdmin.productList[j].Stock += itemsToPurchase[i].Quantity;
                            itemsToPurchase.RemoveAt(i);
                            return;
                        }
                    }
                    itemsToPurchase[i].Product.Price /= itemsToPurchase[i].Quantity;
                    FormAdmin.productList.Add(itemsToPurchase[i].Product);
                    itemsToPurchase.RemoveAt(i);
                }
            }
        }
        /**
        * @brief  PlaceOrder function
        *Siparişi tamamlama metodu.
        */
        public void PlaceOrder()
        {
            foreach (ItemToPurchase item in itemsToPurchase)
            {
                Login.GetInstance.GetCustomer.PurchaseHistory.Add(item);
            }
            itemsToPurchase.Clear();
        }
        /**
        * @brief  CancelOrder function
        *Siparişi iptal etme metodu.
        */
        public void CancelOrder()
        {
            foreach (ItemToPurchase item in Login.GetInstance.GetCustomer.PurchaseHistory)
            {
                foreach (Product pItem in FormAdmin.productList)
                {
                    if (item.Product.ID == pItem.ID)
                    {
                        pItem.Stock += item.Quantity;
                        item.Quantity = -1;
                    }
                }              
            }

            foreach (ItemToPurchase item in Login.GetInstance.GetCustomer.PurchaseHistory)
            {
                if (item.Quantity != -1)
                {
                    item.Product.Price /= item.Quantity;
                    item.Product.Stock = item.Quantity;
                    FormAdmin.productList.Add(item.Product);
                }
            }

            //itemsToPurchase.Clear();
            Login.GetInstance.GetCustomer.PurchaseHistory.Clear();
        }
        /**
        * @brief  SendInvoicebySMS function
        *Siparişi bilgilendirme sms'i gönderen metot.
        */
        public void SendInvoicebySMS()
        { 
            MessageBox.Show("Faturanız "+ Login.GetInstance.GetCustomer.Phone 
                + " no'lu hattınıza gönderilmiştir", "Bilgilendirme"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /**
        * @brief  sendInvoicebyEmail function
        *Siparişi bilgilendirme mail'i gönderen metot.
        */
        public void sendInvoicebyEmail(string mail,string address)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("nuzukstore@gmail.com");
            ePosta.To.Add(mail);
            //
            //
            ePosta.Subject = "Fatura Bilgilendirme";
            //
            ePosta.Body = Invoice(address);
            //
            SmtpClient smtp = new SmtpClient();
            //
            smtp.Credentials = new System.Net.NetworkCredential("nuzukstore@gmail.com", "AgbMt.726");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
                MessageBox.Show("Faturanız " + Login.GetInstance.GetCustomer.Mail + " adresine gönderilmiştir"
                    , "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SmtpException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }            
        }
        /**
        * @brief  SeeknRemoveFromCart function
        * @param name
        * @param shorCart
        *Siparişi verilen ürünü bulup sepetten çıkaran metot.
        */
        private void SeeknRemoveFromCart(string name, ShoppingCart shopCart)
        {
            foreach (ItemToPurchase item in shopCart.itemsToPurchase)
            {
                if (item.Product.Name == name)
                {
                    for (int i = 0; i < FormAdmin.productList.Count; i++)
                    {
                        if (name == FormAdmin.productList[i].Name)
                        {
                            FormAdmin.productList[i].Stock=item.Quantity + FormAdmin.productList[i].Stock;
                            break;
                        }
                        else if (i == FormAdmin.productList.Count - 1)
                        {
                            FormAdmin.productList.Add(item.Product);
                            break;
                        }
                    }
                    shopCart.itemsToPurchase.Remove(item);
                    break;
                }
            }
        }
        /**
       * @brief  SeeknRemoveFromCart function
       * Siparişi verilen ürünün faturasını yazdıran metot.
       * @param address
       * @return strBuilder.ToString()
       */
        public string Invoice(string address)
        {
            double sum = 0; 
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append
                ("                         FATURA                         " + Environment.NewLine
                +"--------------------------------------------------------"+Environment.NewLine
                + "Nüzükstore".PadRight(48) 
                + DateTime.Now.Day+"."+DateTime.Now.Month+"."+DateTime.Now.Year + Environment.NewLine
                + "Odunpazarı,Eskişehir".PadRight(40) + DateTime.Now.Hour+":"+DateTime.Now.Minute + Environment.NewLine + Environment.NewLine
                + Login.GetInstance.GetCustomer.Name + " " + Login.GetInstance.GetCustomer.Surname+ Environment.NewLine
                + address + Environment.NewLine + Environment.NewLine
                +"---------------------------------------------------------"+Environment.NewLine
                + "Ürün Adı".PadRight(50)+"Adet".PadRight(35)+"Fiyat".PadRight(40)+Environment.NewLine
                +"---------------------------------------------------------" + Environment.NewLine);

            foreach (ItemToPurchase item in itemsToPurchase)
            {
                sum += item.Product.Price;
                strBuilder.Append(item.Product.Name.PadRight(50)+  ("x"+item.Quantity.ToString()).PadRight(35) + item.Product.Price.ToString("C").PadRight(40)+ Environment.NewLine);
            }
            strBuilder.Append("---------------------------------------------------------" + Environment.NewLine + Environment.NewLine
                + "Toplam : " + sum.ToString("C").PadRight(30));
            return strBuilder.ToString();
        }
    }
}
