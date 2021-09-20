/**
    * @brief 
    * @file Login.cs
    * @author Fatma Karakaya
    * @date 2019-04-25
    */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookStore
{
    
    /**
    * @brief  Login class
    * Kayıt olmuş kullanıcılar arasında giriş kontrolü sağlayan ve giriş çıkış zamanını kaydeden class'tır. 
    * Singleton design pattern kullanılmıştır.
    */
    public sealed class Login
    {
        private static Login logInstance = null;
        private static readonly object Instancelock = new object();
        private Customer userLoggedIn = new Customer();//giriş yapan kullanıcı
        DateTime logInTime, logOutTime;//giriş-çıkış zamanları için
        StringBuilder logFile=new StringBuilder();//log tutan strinbuilder
        private Login() { }

        //obje döndürme
        public static Login GetInstance
        {
            get
            {
                lock (Instancelock)
                {
                    if (logInstance == null)
                    {
                        logInstance = new Login();
                    }
                    return logInstance;
                }
            }
        }

        /**
        * @brief  CheckUserIDPass function
        * Kullanıcı girişini kontrol eden fonksiyon.
        * @param listuser
        * @param txtUseername
        * @param txtPass
        * @return true
        * @return false
        */
       
        public bool CheckUserIDPass(List<Customer> listUser, TextBox txtUsername, TextBox txtPass)
        {
            foreach (var customer in listUser)
            {
                if (customer.Username == txtUsername.Text && customer.Password == txtPass.Text)
                {
                    logInTime = DateTime.Now;
                    userLoggedIn = customer;
                    logFile.Append("------------------------"+Environment.NewLine+"Session is starting..." + Environment.NewLine
                        + "Username: " + userLoggedIn.Username+Environment.NewLine+"Session Started: " +logInTime + Environment.NewLine);
                    return true;
                }
            }
            return false;
        }
        /**
       * @brief  LogOut function
       * Kullanıcının çıkış yapmasını sağlayan fonksiyon.
       */
        
        public void LogOut()
        {
            logOutTime = DateTime.Now;
            logFile.Append("Session Ended: " + logOutTime +Environment.NewLine
                +"Session Duration " + (logOutTime - logInTime).Minutes.ToString("F2")+ "min"+Environment.NewLine);
            LogOfUserToTextFile();
            userLoggedIn = null;
            logInstance = null;
        }
        /**
      * @brief  GetCustomer function
      * Kullanıcı için get metodunu tutar.
      * @return userLoggedIn
      */
        
        public Customer GetCustomer
        {
            get { return userLoggedIn; }
        }
        /**
         * @brief IsUserLoggedIn function
         * Kullanıcının giriş durumunu kontrol eden  metot.
         * @return true
         *  @return false
        */

        public static bool IsUserLoggedIn()
        {
            if (logInstance != null)
                return true;
            return false;
        }
        /**
        * @brief AddCartToUserWishList function
        * @param wishList
        * Kullanıcının sepetine ürün ekleme yapan  metot.
       */
        
        public void AddCartToUserWishList(List<ItemToPurchase> wishList)
        {
            foreach(ItemToPurchase item in wishList)
            {
                userLoggedIn.WishList.Add(item);
            }
        }
        /**
       * @brief LogButtonClicks function
       * @param buttonName
       * butonların tıklanmasını log için stringbuildera ekler 
      */
       
        public void LogButtonClicks(string buttonName) {
            logFile.Append("Button : " + buttonName + " Clicked, Event Time : " + DateTime.Now + Environment.NewLine);
        }
        /**
      * @brief LogOfUserToTextFile function
      * kullanıcının log durumunu dosyaya kaydeder
     */

        public void LogOfUserToTextFile()
        {
            StreamWriter file = new System.IO.StreamWriter(Application.StartupPath + @"\\Log File.txt",true);
            file.WriteLine(logFile.ToString());
            file.Close();
        }
        /**
      * @brief SaveCustomerCartToXml function
      * @param str
      * @param list
      * Alışveriş sepetini XML formatında güncelleme yaparak kaydeder.
     */
        public void SaveCustomerCartToXml(string str,List<ItemToPurchase> list)
        {
            XDocument xmlDoc = XDocument.Load(@"customer.xml");
            var items = from item in xmlDoc.Descendants("customer")
                        where item.Element("id").Value == userLoggedIn.ID.ToString()
                        select item;
            foreach(XElement itemElement in items)
            {
                try
                {
                    itemElement.Element(str).Remove();
                }
                catch (Exception)
                { break; }                    
            }
            xmlDoc.Save(@"customer.xml");

            var items1 = from item in xmlDoc.Descendants("customer")
                        where item.Element("id").Value == userLoggedIn.ID.ToString()
                        select item;
            for (int i = 0; i < list.Count; i++)
            {
                foreach (XElement itemElement in items1)
                {
                    if (list[i].Product.GetType()==typeof(Book))
                    {
                        Book bk = new Book();
                        bk =(Book) list[i].Product.CloneIT();
                        try
                        {
                            itemElement.Element(str).Add(new XElement("book",
                            new XElement("name", bk.Name),
                            new XElement("price", bk.Price.ToString()),
                            new XElement("author", bk.Author),
                            new XElement("publisher", bk.Publisher),
                            new XElement("page", bk.Page),
                            new XElement("isbn", bk.ISBN),
                            new XElement("stock", list[i].Quantity.ToString()),
                            new XElement("id", bk.ID.ToString())));
                        }
                        catch (Exception)
                        {
                            itemElement.Add(new XElement(str,
                            new XElement("book",
                            new XElement("name", bk.Name),
                            new XElement("price", bk.Price.ToString()),
                            new XElement("author", bk.Author),
                            new XElement("publisher", bk.Publisher),
                            new XElement("page", bk.Page),
                            new XElement("isbn", bk.ISBN),
                            new XElement("stock", list[i].Quantity.ToString()),
                            new XElement("id", bk.ID.ToString()))));
                        }
                    }
                    else if(list[i].Product.GetType() == typeof(Magazine))
                    {
                        Magazine mag = new Magazine();
                        mag = (Magazine)list[i].Product.CloneIT();
                        try
                        {
                            itemElement.Element(str).Add(new XElement("magazine",
                            new XElement("name", mag.Name),
                            new XElement("price", mag.Price.ToString()),
                            new XElement("issue", mag.Issue),
                            new XElement("type", mag.MagType),
                            new XElement("stock", list[i].Quantity.ToString()),
                            new XElement("id", mag.ID.ToString())));
                        }
                        catch (Exception)
                        {
                            itemElement.Add(new XElement(str,
                            new XElement("magazine",
                            new XElement("name", mag.Name),
                            new XElement("price", mag.Price.ToString()),
                            new XElement("issue", mag.Issue),
                            new XElement("type", mag.MagType),
                            new XElement("stock", list[i].Quantity.ToString()),
                            new XElement("id", mag.ID.ToString()))));
                        }
                    }
                    else if(list[i].Product.GetType() == typeof(MusicCD))
                    {
                        MusicCD mcd = new MusicCD();
                        mcd = (MusicCD)list[i].Product.CloneIT();
                        try
                        {
                            itemElement.Element(str).Add(new XElement("music",
                            new XElement("name", mcd.Name),
                            new XElement("price", mcd.Price.ToString()),
                            new XElement("singer", mcd.Singer),
                            new XElement("type", mcd.MusType),
                            new XElement("stock", list[i].Quantity.ToString()),
                            new XElement("id", mcd.ID)));
                        }
                        catch (Exception)
                        {
                            itemElement.Add(new XElement(str,
                            new XElement("music",
                            new XElement("name", mcd.Name),
                            new XElement("price", mcd.Price.ToString()),
                            new XElement("singer", mcd.Singer),
                            new XElement("type", mcd.MusType),
                            new XElement("stock", list[i].Quantity.ToString()),
                            new XElement("id", mcd.ID.ToString()))));
                        }
                    }
                }
            }
            xmlDoc.Save(@"customer.xml");
        }
    }
}
