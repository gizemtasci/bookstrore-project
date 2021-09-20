using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class FormShopping : Form
    {
        Login logUser;//sistemdeki aktif kullanıcı
        ShoppingCart shopCart;//alışveriş sepeti
        int indexOfSubItem; //listview fiyat subitemlerı

        public FormShopping()
        {
            InitializeComponent();
        }

        private void FormShopping_Load(object sender, EventArgs e)
        {
            logUser = Login.GetInstance;
            shopCart = new ShoppingCart();
            shopCart.CustomerID = logUser.GetCustomer.ID;

            lbCurrentUserInfo.Text = logUser.GetCustomer.Name;
            lbCurrentUserInfo2.Text = logUser.GetCustomer.Name;
            lbCurrentUserInfo3.Text = logUser.GetCustomer.Name;

            if (tabCShoppingForm.SelectedTab == tabPOrders)
            {
                tabCShoppingForm.SelectedTab.Show();
                logUser.GetCustomer.PrintCustomerPurchases(listViewOrders);
            }

            if (logUser.GetCustomer.WishList.Count != 0)
            {
                foreach (ItemToPurchase item in logUser.GetCustomer.WishList)
                {
                    shopCart.itemsToPurchase.Add(item);
                }
                ProductToShopCart(listViewShopCart, true);
                btnRemoveCart.Enabled = true;
                btnPlaceOrder.Enabled = true;
            }
        }

        //comboBoxtan seçilen ürünü listviewItems da gösterme
        private void comBProductTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBProductTypes.SelectedIndex == 2)
            {
                indexOfSubItem = 4;
                listViewShopItems.Clear();
                listViewShopItems.View = View.Details;
                listViewShopItems.GridLines = true;
                listViewShopItems.FullRowSelect = true;
                listViewShopItems.Columns.Add("ID", 60);
                listViewShopItems.Columns.Add("Müzik CD Adı", 245);
                listViewShopItems.Columns.Add("Sanatçı", 240);
                listViewShopItems.Columns.Add("Türü", 150);
                listViewShopItems.Columns.Add("Adet", 75);
                listViewShopItems.Columns.Add("Fiyat", 85);
                foreach (Product item in FormAdmin.productList)
                {
                    if (item.GetType() == typeof(MusicCD))
                    {
                        string[] row = item.PrintProperties().Split('%');
                        var satir = new ListViewItem(row);
                        listViewShopItems.Items.Add(satir);
                    }
                }
            }
            else if (comBProductTypes.SelectedIndex == 0)
            {
                indexOfSubItem = 6;
                listViewShopItems.Clear();
                listViewShopItems.View = View.Details;
                listViewShopItems.GridLines = true;
                listViewShopItems.FullRowSelect = true;
                listViewShopItems.Columns.Add("ID", 60);
                listViewShopItems.Columns.Add("Kitap Adı", 200);
                listViewShopItems.Columns.Add("Yazarı", 150);
                listViewShopItems.Columns.Add("Yayımcı", 125);
                listViewShopItems.Columns.Add("ISBN", 75);
                listViewShopItems.Columns.Add("Sayfa Sayısı", 75);
                listViewShopItems.Columns.Add("Adet", 75);
                listViewShopItems.Columns.Add("Fiyat", 90);
                foreach (Product item in FormAdmin.productList)
                {
                    if (item.GetType() == typeof(Book))
                    {
                        string[] row = item.PrintProperties().Split('%');
                        var satir = new ListViewItem(row);
                        listViewShopItems.Items.Add(satir);
                    }
                }
            }
            else if (comBProductTypes.SelectedIndex == 1)
            {
                indexOfSubItem = 4;
                listViewShopItems.Clear();
                listViewShopItems.View = View.Details;
                listViewShopItems.GridLines = true;
                listViewShopItems.FullRowSelect = true;
                listViewShopItems.Columns.Add("ID", 60);
                listViewShopItems.Columns.Add("Dergi Adı", 245);
                listViewShopItems.Columns.Add("Türü", 240);
                listViewShopItems.Columns.Add("Basım", 150);
                listViewShopItems.Columns.Add("Adet", 75);
                listViewShopItems.Columns.Add("Fiyat", 85);
                foreach (Product item in FormAdmin.productList)
                {
                    if (item.GetType() == typeof(Magazine))
                    {
                        string[] row = item.PrintProperties().Split('%');
                        var satir = new ListViewItem(row);
                        listViewShopItems.Items.Add(satir);
                    }
                }
            }            
        }

        //Seçilen ürün adedi kadar Shopping Cart a ürün ekleme butonu
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnAddCart.Text);
            bool flag = false;
            UpDownProductCount_ValueChanged(sender, e);

            if (listViewShopItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen Ürün Seçiniz","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            else if (listViewShopCart.Items.Count != 0) 
            {
                for (int i = 0; i < listViewShopCart.Items.Count; i++)
                {
                    if (listViewShopCart.Items[i].SubItems[0].Text == listViewShopItems.SelectedItems[0].SubItems[1].Text)
                    {
                        flag = true;
                        shopCart.AddToCart(int.Parse(listViewShopItems.SelectedItems[0].SubItems[0].Text), (int)UpDownProductCount.Value);
                        ProductToShopCart(listViewShopCart,true);
                        comBProductTypes_SelectedIndexChanged(sender, e);
                        break;
                    }
                }
            }

            if (!flag) {                
                long itemID = long.Parse(listViewShopItems.SelectedItems[0].SubItems[0].Text);
                shopCart.AddToCart(itemID, (int)UpDownProductCount.Value);
                ProductToShopCart(listViewShopCart,true);
                comBProductTypes_SelectedIndexChanged(sender, e);
            }
            btnPlaceOrder.Enabled =true;
            btnRemoveCart.Enabled = true;
            listViewShopItems.SelectedItems.Clear();
            UpDownProductCount.Value = 1;
            flag = false;
        }
        //Seçilen ürün veya ürünleri sepetten çıkarma butonu
        private void btnRemoveCart_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnRemoveCart.Text);
            int chosenItemsNumber = listViewShopCart.Items.Count;
            if (shopCart.itemsToPurchase.Count != 0)
            {
                for (int i = 0; i < chosenItemsNumber; i++)
                {
                    if (listViewShopCart.Items[i].Checked)
                    {
                        shopCart.RemoveProduct(listViewShopCart.Items[i].SubItems[0].Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("Herhangi Bir Ürün Seçilmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            comBProductTypes_SelectedIndexChanged(sender, e);
            ProductToShopCart(listViewShopCart, true);
            checkBoxCheckAll.Checked = false;
            btnPlaceOrder.Enabled = (listViewShopCart.Items.Count == 0) ? false : true;
            btnRemoveCart.Enabled = (listViewShopCart.Items.Count == 0) ? false : true;
        }
        //Sepeti Onaylama butonu
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnPlaceOrder.Text);
            txtNewAddress.Text = logUser.GetCustomer.Address;
            txtNewEmail.Text = logUser.GetCustomer.Mail;
            lblTotal.Text = "Toplam : " + TotalPrice().ToString("C");
            lbCurrentUserInfo2.Text = logUser.GetCustomer.Name;
            tabCShoppingForm.SelectedTab = tabPPayment;
            tabCShoppingForm.SelectedTab.Show();
            ProductToShopCart(listViewShopCartTab2, false);
        }
        //ödeme butonu
        private void btnPay_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnPay.Text);
            if (!checkBEmail.Checked && !checkBSMS.Checked)
                MessageBox.Show("Fatura Bilgilendirme Seçiniz", "UYARI"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string mail,address;
                MessageBox.Show("Ödeme Başarılı", "Bilgilendirme"
                       , MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (txtNewEmail.Text == "")
                    mail = logUser.GetCustomer.Mail;
                else
                    mail = txtNewEmail.Text;

                if (txtNewAddress.Text == "")
                    address = logUser.GetCustomer.Address;
                else
                    address = txtNewAddress.Text;

                if (checkBSMS.Checked)
                    shopCart.SendInvoicebySMS();

                if (checkBEmail.Checked)
                    shopCart.sendInvoicebyEmail(mail, address);
                
                shopCart.PlaceOrder();
                logUser.GetCustomer.PrintCustomerPurchases(listViewOrders);
                logUser.GetCustomer.WishList.Clear();
                FormHome.UpdateProductXml();

                grpEmailInfo.Visible = false;
                listViewShopCart.Clear();
                listViewShopCartTab2.Clear();
                tabCShoppingForm.SelectedTab = tabPOrders;
                tabCShoppingForm.SelectedTab.Show();
            }
        }
        //sipariş iptal butonu
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnCancelOrder.Text);
            shopCart.CancelOrder();
            FormHome.UpdateProductXml();
            listViewShopCart.Clear();
            listViewOrders.Clear();
            comBProductTypes_SelectedIndexChanged(sender, e);
        }

        //Tab Page 2 deki Alışverişe Geri Dön Butonu
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnGoBack.Text);
            //Menüye Geri Dönüldüğünde RadioButton Sıfırlama
            radioBtnCash.Checked = false;
            radioBtnCheck.Checked = false;
            radioBtnCreditCard.Checked = false;

            //Ana Tab Page gösterme
            tabCShoppingForm.SelectedTab = tabPShoppingMain;
            tabCShoppingForm.SelectedTab.Show();
        }

        //Tab Pagelerdeki Ana Menü Butonları
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnLogOut.Text);
            logUser.GetCustomer.WishList.Clear();
            logUser.AddCartToUserWishList(shopCart.itemsToPurchase);
            shopCart.itemsToPurchase.Clear();
            this.Close();
        }
        //ana menüye dönme butonu
        private void btnLogOut2_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnRemoveCart.Text);
            logUser.GetCustomer.WishList.Clear();
            logUser.AddCartToUserWishList(shopCart.itemsToPurchase);
            shopCart.itemsToPurchase.Clear();
            this.Close();
        }
        //ana menüye dönme butonu
        private void btnLogOut3_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnLogOut3.Text);
            this.Close();
        }

        //Tab Page 1 deki Listview ShopCart Fonksiyonları
        private void listViewShopItems_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewShopItems.SelectedItems)
            {
                UpDownProductCount.Maximum = 1+long.Parse(item.SubItems[indexOfSubItem].Text);
            }
        }
        //listview alışveriş sepeti click eventi
        private void listViewShopCart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewShopCart.Items.Count; i++)
            {
                if (listViewShopCart.Items[i].Selected)
                {
                    if (!listViewShopCart.Items[i].Checked)
                    {
                        listViewShopCart.Items[i].BackColor = Color.FromArgb(255, 219, 77);
                        listViewShopCart.Items[i].Checked = true;
                    }
                    else
                    {
                        listViewShopCart.Items[i].BackColor = Color.FromArgb(230, 247, 255);
                        listViewShopCart.Items[i].Checked = false;
                    }
                }
            }
        }       

        //shopcarttaki itemlerin tümünü seçme
        private void checkBoxCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCheckAll.Checked)
            {
                for (int i = 0; i < listViewShopCart.Items.Count; i++)
                {
                    listViewShopCart.Items[i].Selected = true;
                    listViewShopCart.Items[i].BackColor = Color.FromArgb(255, 219, 77);
                    listViewShopCart.Items[i].Checked = true;
                }
            }
            else
            {
                for (int i = 0; i < listViewShopCart.Items.Count; i++)
                {
                    listViewShopCart.Items[i].Selected = false;
                    listViewShopCart.Items[i].BackColor = Color.FromArgb(230,247, 255);
                    listViewShopCart.Items[i].Checked = false;
                }
            }
        }
         
        //Payment Tab
        //RadioButtonların Check Olması Durumunda Uygun GroupBox Gösterme 
        private void radioBtnCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnCreditCard.Checked)
            {
                txtCardNum1.Enabled = true;
                txtCardNum2.Enabled = false;
                txtCardNum3.Enabled = false;
                txtCardNum4.Enabled = false;
                txtCardNum1.Text = "";
                txtCardNum2.Text = "";
                txtCardNum3.Text = "";
                txtCardNum4.Text = "";
                comBoxCardType.SelectedIndex = -1;
                shopCart.PaymentType = PaymentType.credit;
            }
            UpDownCardMonth.Minimum = DateTime.Today.Month;
            UpDownCardYear.Minimum= DateTime.Today.Year%100;//hatalı olabilir
            grpBankCardInfo.Visible = (radioBtnCreditCard.Checked) ? true : false;
        }
        private void radioBtnCash_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnCash.Checked)
                shopCart.PaymentType = 0;  
                      
            txtBoxCashInput.Text = TotalPrice().ToString("F");
            grpCashInfo.Visible = (radioBtnCash.Checked) ? true : false;
            btnPay.Enabled = (radioBtnCash.Checked) ? true : false;
            if (grpCashInfo.Visible)
                txtBoxCashInput.Focus();
        }
        private void radioBtnCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnCheck.Checked)
            {
                txtCheckOwner.Text = "";
                txtCheckId1.Enabled = true;
                txtCheckId2.Enabled = false;
                txtCheckId3.Enabled = false;
                txtCheckId4.Enabled = false;
                txtCheckId1.Text = "";
                txtCheckId2.Text = "";
                txtCheckId3.Text = "";
                txtCheckId4.Text = "";
                shopCart.PaymentType = PaymentType.cash;
            }
            grpCheckInfo.Visible = (radioBtnCheck.Checked) ? true : false;

            if (grpCheckInfo.Visible)
                txtCheckId1.Focus();            
        }

        //toplam ücreti hesaplar
        private double TotalPrice()
        {
            double sum = 0.0;
            foreach (ItemToPurchase item in shopCart.itemsToPurchase)
            {
                sum += item.Product.Price;
            }
            return sum;
        }
        //seçilen ürünü shopcarta atma
        private void ProductToShopCart(ListView lv, bool flag)
        {
            lv.Clear();
            lv.View = View.Details;
            lv.GridLines = true;
            lv.FullRowSelect = true;

            lv.Columns.Add("Ürün Adı", flag ? 130 : 245);
            lv.Columns.Add("Adet", flag ? 50 : 70);
            lv.Columns.Add("Fiyat", flag ? 70 : 80);
            foreach (ItemToPurchase item in shopCart.itemsToPurchase)
            {
                string[] row = { item.Product.Name, "x" + item.Quantity, (item.Product.Price).ToString("C") };
                var rowP = new ListViewItem(row);
                lv.Items.Add(rowP);
            }
        }

        //TextBox Nakit Ödeme Bilgisi
        private void txtBoxCashInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox'a sadece double sayı girmek için
            txtBoxCashInput.ForeColor = Color.Black;
            char ch = e.KeyChar;
            if(ch==44 && txtBoxCashInput.Text.IndexOf(",") != -1)
            {
                e.Handled = true;
                return;
            }
            if(!Char.IsDigit(ch)&& ch!=8 && ch!=44)
                e.Handled = true;
        }
        private void txtBoxCashInput_TextChanged(object sender, EventArgs e)
        {
            //girilen nakit miktarı uygunsa ödeme butonunu aktifleştir.
            if (txtBoxCashInput.Text == "" || txtBoxCashInput.Text==",")
            {
                btnPay.Enabled = false;
            }
            else if (double.Parse(txtBoxCashInput.Text) >= TotalPrice())
            {
                btnPay.Enabled = true;
            }
            else
            {
                btnPay.Enabled = false;
            }
        }

        //Stock Kontrolu
        private void UpDownProductCount_ValueChanged(object sender, EventArgs e)
        {
            if (UpDownProductCount.Maximum <= UpDownProductCount.Value)
            {
                listViewShopItems.SelectedItems[0].Selected = false;
                MessageBox.Show("Yetersiz Stok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpDownProductCount.Value = UpDownProductCount.Minimum;
            }
        }
          

        // //// //// //// //// //// //// /// /// //// //// //// //// //// //// //

        //Çek İsmi textbox harf ve boşluk kontrolü
        private void txtCheckOwner_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            //ilk tuş space olamaz ve iki space ard arda gelemez
            if (e.KeyChar == ' ' && (txtCheckOwner.Text.Length == 0 || txtCheckOwner.Text[txtCheckOwner.Text.Length-1]==' '))//for block first whitespace 
            {
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }

            //sadece harf, boşluk ve backspace kullanılabilir
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            {
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }           
        }

        //Çek BankID textbox kontrolü
        private void txtCheckId1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 )
            {
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
            if (txtCheckId1.TextLength == 3&&ch != 8)
            {
                txtCheckId2.Enabled = true;
                txtCheckId1.Enabled = false;
                txtCheckId2.Focus();
            }
        }
        private void txtCheckId2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 )
            {
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
            if (txtCheckId2.TextLength == 3&&ch != 8)
            {
                txtCheckId3.Enabled = true;
                txtCheckId2.Enabled = false;
                txtCheckId3.Focus();
            }
            else if (ch == 8 && txtCheckId2.TextLength == 0)
            {
                txtCheckId2.Enabled = false;
                txtCheckId1.Enabled = true;
                txtCheckId1.Focus();
            }
        }
        private void txtCheckId3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 )
            {
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
            if (txtCheckId3.TextLength == 3 && ch != 8)
            {
                txtCheckId4.Enabled = true;
                txtCheckId3.Enabled = false;
                txtCheckId4.Focus();
            }
            else if (ch == 8 && txtCheckId3.TextLength == 0)
            {
                txtCheckId3.Enabled = false;
                txtCheckId2.Enabled = true;
                txtCheckId2.Focus();
            }
        }
        private void txtCheckId4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((!Char.IsDigit(ch) && ch != 8 && ch!=10) || (txtCheckId4.TextLength==4 && ch!=8))
            {
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }

            if (ch==8 && txtCheckId4.TextLength==0)
            {
                txtCheckId4.Enabled = false;
                txtCheckId3.Enabled = true;
                txtCheckId3.Focus();
            }
        }

        //Çek BankID textbox Enter tuşu iptali
        private void txtCheckId1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
            if(txtCheckId1.TextLength==4 && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
                txtCheckId1.Enabled = false;
                txtCheckId2.Enabled = true;
                txtCheckId2.Focus();
            }
        }
        private void txtCheckId2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }

            if (txtCheckId2.TextLength == 4 && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
                txtCheckId2.Enabled = false;
                txtCheckId3.Enabled = true;
                txtCheckId3.Focus();
            }
        }
        private void txtCheckId3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }

            if (txtCheckId3.TextLength == 4 && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
                txtCheckId3.Enabled = false;
                txtCheckId4.Enabled = true;
                txtCheckId4.Focus();
            }
        }
        private void txtCheckId4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        //Çek Textboxlarını kontrol ederek öde butonunu aktifleştiriyor
        private void txtCheckOwner_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCheckOwner.Text))
            {
                btnPay.Enabled=false;
            }
            else if (txtCheckId4.TextLength<4)
            {
                btnPay.Enabled = false;
            }
            else if (txtCheckId4.TextLength ==4)
            {
                btnPay.Enabled = true;
            }
        }
        private void txtCheckId4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCheckId4.Text))
            {
                btnPay.Enabled = false;
            }
            else if (txtCheckId4.TextLength == 4 && txtCheckOwner.Text != "")
            {
                btnPay.Enabled = true;
            }
            else if(txtCheckId4.TextLength <4)
                btnPay.Enabled = false;
            if (txtCheckId4.TextLength == 4)
                txtCheckOwner.Focus();
        }

        //Kredi Kartı Numarası Textbox işlemleri
        private void txtCardNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
            if (txtCardNum1.TextLength == 3 && ch != 8)
            {
                txtCardNum2.Enabled = true;
                txtCardNum1.Enabled = false;
                txtCardNum2.Focus();
            }
        }
        private void txtCardNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
            if (txtCardNum2.TextLength == 3 && ch != 8)
            {
                txtCardNum3.Enabled = true;
                txtCardNum2.Enabled = false;
                txtCardNum3.Focus();
            }
            else if (ch == 8 && txtCardNum2.TextLength == 0)
            {
                txtCardNum2.Enabled = false;
                txtCardNum1.Enabled = true;
                txtCardNum1.Focus();
            }
        }
        private void txtCardNum3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
            if (txtCardNum3.TextLength == 3 && ch != 8)
            {
                txtCardNum4.Enabled = true;
                txtCardNum3.Enabled = false;
                txtCardNum4.Focus();
            }
            else if (ch == 8 && txtCardNum3.TextLength == 0)
            {
                txtCardNum3.Enabled = false;
                txtCardNum2.Enabled = true;
                txtCardNum2.Focus();
            }
        }
        private void txtCardNum4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((!Char.IsDigit(ch) && ch != 8 && ch != 10) || (txtCardNum4.TextLength == 4 && ch != 8))
            {
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }

            if (ch == 8 && txtCardNum4.TextLength == 0)
            {
                txtCardNum4.Enabled = false;
                txtCardNum3.Enabled = true;
                txtCardNum3.Focus();
            }
        }

        //Kredi Kartı Numarası Textbox Enter tuşu iptali
        private void txtCardNum1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
            if (txtCardNum1.TextLength == 4 && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
                txtCardNum1.Enabled = false;
                txtCardNum2.Enabled = true;
                txtCardNum2.Focus();
            }
        }
        private void txtCardNum2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }

            if (txtCardNum2.TextLength == 4 && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
                txtCardNum2.Enabled = false;
                txtCardNum3.Enabled = true;
                txtCardNum3.Focus();
            }
        }
        private void txtCardNum3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }

            if (txtCardNum3.TextLength == 4 && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
                txtCardNum3.Enabled = false;
                txtCardNum4.Enabled = true;
                txtCardNum4.Focus();
            }
        }
        private void txtCardNum4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        //Kredi Kartı işlemlerinde Textboxlarını kontrol ederek öde butonunu aktifleştiriyor
        private void txtCardNum4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCardNum4.Text))
            {
                btnPay.Enabled = false;
            }
            else if (txtCardNum4.TextLength == 4 && comBoxCardType.SelectedIndex>=0)
            {
                btnPay.Enabled = true;
            }
            else if (txtCardNum4.TextLength < 4)
                btnPay.Enabled = false;
        }

        //ödeme butonu aktifleştirme
        private void comBoxCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCardNum4.TextLength == 4 && comBoxCardType.SelectedIndex >= 0)
            {
                btnPay.Enabled = true;
            }else
            {
                btnPay.Enabled = false;
            }
        }

        private void txtNewAddress_Click(object sender, EventArgs e)
        {
            txtNewAddress.Text = "";
        }

        private void txtNewEmail_Click(object sender, EventArgs e)
        {
            txtNewEmail.Text = "";
        }

        private void checkBEmail_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBEmail.Checked)
                grpEmailInfo.Visible = true;
            else
                grpEmailInfo.Visible = false;
        }
        // //// //// //// //// //// //// /// /// //// //// //// //// //// //// //// //
    }
}
