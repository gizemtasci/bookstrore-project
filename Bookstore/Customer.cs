/**
    * @brief 
    * @file Customer.cs
    * @author Fatma Karakaya
    * @date 2019-04-25
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace BookStore
{
    /**
   * @brief Customer Class
   * Product class'ından türetilmiştir. 
   * Customer nesnelerini Name, Surname, Mail, Username, Phone, Password, Address, ID gibi verilerin yapısını kapsar. 
   */


    public class Customer
    {
        /**
         * @brief  Name fuction
         * isim bölümünün get set metotlarını tutar.
        */
        public string Name { get; set; }
        /**
        * @brief  Surname fuction
        * soyisim bölümünün get set metotlarını tutar.
       */
        public string Surname { get; set; }
        /**
        * @brief  Mail fuction
        * Mail bölümünün get set metotlarını tutar.
       */
        public string Mail { get; set; }
        /**
        * @brief  Username fuction
        * Kullanıcı adı bölümünün get set metotlarını tutar.
       */
        public string Username { get; set; }
        /**
        * @brief  Phone fuction
        * Telefon numarası bölümünün get set metotlarını tutar.
       */
        public string Phone { get; set; }
        /**
        * @brief  Password fuction
        * Şifre bölümünün get set metotlarını tutar.
       */
        public string Password { get; set; }
        /**
        * @brief  Address fuction
        * Adres bölümünün get set metotlarını tutar.
       */
        public string Address { get; set; }
        /**
        * @brief  ID fuction
        * ID bölümünün get set metotlarını tutar.
       */
        public int ID { get; set; }
        /**
        * @brief  WishList fuction
        * Alışveriş listesi bölümünün get set metotlarını tutar.
        * ItemToPurchase nesne tipinde veri tutup döndürme işlemini yapar. 
       */
        public List<ItemToPurchase> WishList { get; set; }
        /**
        * @brief  PurchaseHistory fuction
        * Alışveriş geçmişi bölümünün get set metotlarını tutar.
        * ItemToPurchase nesne tipinde veri tutup döndürme işlemini yapar. 
       */
        public List<ItemToPurchase> PurchaseHistory { get; set; }

        /**
        * @brief  constructor Customer fuction
        *Satın alma geçmişi ve alışveriş listesini tutar.
       */
        public Customer(){
            WishList = new List<ItemToPurchase>();
            PurchaseHistory = new List<ItemToPurchase>();
        }
        /**
        * @brief  PrintCustomerDetails fuction      
        * Müşterinin özelliklerini döndürmek için kullanılan fonksiyondur.
        * @return ID + "%" + Name + "%" + Surname + "%" + Username + "%" + Mail + "%" + Phone + "%" + Address
       */
        public string PrintCustomerDetails()
        {
            return ID + "%" + Name + "%" + Surname + "%" + Username + "%" + Mail + "%" + Phone + "%" + Address;
        }
        /**
       * @brief  SaveCustomer fuction      
       * Müşteri bilgilerini XML formatına çevirip oluşturulan kaynak
       * dosyasına kaydedilmesini sağlayan fonksiyondur. 
      */
        
        public void SaveCustomer()
        {
            XDocument xmlDoc = XDocument.Load(@"customer.xml");
            xmlDoc.Root.Element("customers").Add(
                new XElement("customer",
                new XElement("name", Name),
                new XElement("surname", Surname),
                new XElement("mail", Mail),
                new XElement("username", Username),
                new XElement("phone", Phone),
                new XElement("password", Password),
                new XElement("address", Address),
                new XElement("id", ID)));
            xmlDoc.Save(@"customer.xml");
        }
        
        /**
       * @brief  PrintCustomerPurchases fuction   
       * Alışveriş detaylarını belirtilen nesnede kullanılan fonksiyon
       * @param ListView lv
       * */
       
        public void PrintCustomerPurchases(ListView lv)
        {
            lv.Clear();
            lv.View = View.Details;
            lv.GridLines = true;
            lv.FullRowSelect = true;

            lv.Columns.Add("Ürün Adı", 250);
            lv.Columns.Add("Adet", 120);
            lv.Columns.Add("Fiyat", 125);
            foreach (ItemToPurchase item in PurchaseHistory)
            {
                string[] row = { item.Product.Name, "x" + item.Quantity, (item.Product.Price).ToString("C") };
                var rowP = new ListViewItem(row);
                lv.Items.Add(rowP);
            }
        }
    }
}
