using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace BookStore
{
    public partial class FormHome : Form
    {
        public static List<Customer> customerHolder = new List<Customer>();
        public static Random rand = new Random();
        FormLogin frmLog;
        FormSingUp frmSing;
        FormShopping frmShop;
        
        FormWishList frmWishList;
        FormAdminLogin frmAdminlogin;
        Login logUser;

        public FormHome()
        {
            InitializeComponent();
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            InitializeBookstore();
            btnbackAdminPanel.Visible = true;
        }

        //Giriş,Çıkış,Kayıt butonları
        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLog = new FormLogin();
            this.Hide();
            if (frmLog.ShowDialog() == DialogResult.OK) {
                logUser = Login.GetInstance;
                lbWelcome.Visible = true;
                lbWelcome.Text = "Hoşgeldin " + logUser.GetCustomer.Name;
                groupBoxInfo.Visible = true;
                btnLogin.Enabled = false;
                btnLogin.Visible = false;
                btnSignup.Enabled = false;
                btnSignup.Visible = false;
                btnShowWhisList.Visible = true;
                btnOrderHistory.Visible = true;
                lbCurrentUserInfo.Text = logUser.GetCustomer.Name+" "+logUser.GetCustomer.Surname+"\n@"+logUser.GetCustomer.Username;
                if (logUser.GetCustomer.Username == "Admin")
                {
                    lbWelcome.Visible = false;
                    btnbackAdminPanel.Visible = true;
                }
                else
                {
                    lbWelcome.Visible = true;
                    btnbackAdminPanel.Visible = false;
                }

            }
            frmLog.Dispose();
            this.Show();
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            frmSing = new FormSingUp();
            this.Hide();
            if (frmSing.ShowDialog()==DialogResult.OK)
            { 
                customerHolder.Add(frmSing.cst);
            }
            frmSing.Dispose();
            this.Show();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (logUser!=null)
            {
                logUser.SaveCustomerCartToXml("history",
                logUser.GetCustomer.PurchaseHistory);
                logUser.SaveCustomerCartToXml("wishlist",
                    logUser.GetCustomer.WishList);

                    UpdateProductXml();
                
                btnbackAdminPanel.Visible = false;
                logUser.LogOut();
                groupBoxInfo.Visible = false;
                lbWelcome.Visible = false;
                btnShowWhisList.Visible = false;
                btnOrderHistory.Visible = false;

                btnLogin.Enabled = true;
                btnLogin.Visible = true;
                btnSignup.Enabled = true;
                btnSignup.Visible = true;

                lbCurrentUserInfo.Text = "";
            }
            
        }

       //dükkan oluşturuluyor
        private static void InitializeBookstore()
        {
            try
            {        
                //Dükkana ürünler ekleniyor      
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Application.StartupPath + "\\store.xml");
                XmlNodeList nodelist = xmlDoc.SelectNodes("/store/products/books/book");

                foreach (XmlNode node in nodelist)
                {
                    Book newBook =(Book) ProductFactory.FactoryMethod("Book", node.SelectSingleNode("name").InnerText, double.Parse(node.SelectSingleNode("price").InnerText), int.Parse(node.SelectSingleNode("stock").InnerText), false);
                    newBook.Author = node.SelectSingleNode("author").InnerText;
                    newBook.ISBN= node.SelectSingleNode("isbn").InnerText;
                    newBook.Page = int.Parse(node.SelectSingleNode("page").InnerText);
                    newBook.Publisher= node.SelectSingleNode("publisher").InnerText;
                    newBook.ID = int.Parse(node.SelectSingleNode("id").InnerText);
                    FormAdmin.productList.Add(newBook);
                }
                nodelist = xmlDoc.SelectNodes("/store/products/magazines/magazine");
                foreach (XmlNode node in nodelist)
                {
                    Magazine newMagazine = (Magazine)ProductFactory.FactoryMethod("Magazine", node.SelectSingleNode("name").InnerText, double.Parse(node.SelectSingleNode("price").InnerText), int.Parse(node.SelectSingleNode("stock").InnerText), false);
                    newMagazine.Issue = node.SelectSingleNode("issue").InnerText;
                    newMagazine.MagType = (TypeOfMagazine)Enum.Parse(typeof(TypeOfMagazine), node.SelectSingleNode("type").InnerText);
                    newMagazine.ID = int.Parse(node.SelectSingleNode("id").InnerText);
                    FormAdmin.productList.Add(newMagazine);
                }

                nodelist = xmlDoc.SelectNodes("/store/products/musics/music");
                foreach (XmlNode node in nodelist)
                {
                    MusicCD newMusic = (MusicCD)ProductFactory.FactoryMethod("MusicCD", node.SelectSingleNode("name").InnerText, double.Parse(node.SelectSingleNode("price").InnerText), int.Parse(node.SelectSingleNode("stock").InnerText), false);
                    newMusic.Singer = node.SelectSingleNode("singer").InnerText;
                    newMusic.MusType = (TypeOfMusic)Enum.Parse(typeof(TypeOfMusic), node.SelectSingleNode("type").InnerText);
                    newMusic.ID = int.Parse(node.SelectSingleNode("id").InnerText);
                    FormAdmin.productList.Add(newMusic);
                }

                //Müşteriler Ekleniyor
                xmlDoc.Load(Application.StartupPath + "\\customer.xml");
                nodelist = xmlDoc.SelectNodes("/store/customers/customer");
                foreach (XmlNode node in nodelist)
                {
                    Customer newCustomer = new Customer();
                    newCustomer.Address = node.SelectSingleNode("address").InnerText;
                    newCustomer.ID = int.Parse(node.SelectSingleNode("id").InnerText);
                    newCustomer.Mail = node.SelectSingleNode("mail").InnerText;
                    newCustomer.Name = node.SelectSingleNode("name").InnerText;
                    newCustomer.Password = node.SelectSingleNode("password").InnerText;
                    newCustomer.Phone = node.SelectSingleNode("phone").InnerText;
                    newCustomer.Surname = node.SelectSingleNode("surname").InnerText;
                    newCustomer.Username = node.SelectSingleNode("username").InnerText;

                    customerHolder.Add(newCustomer);
                }
                XmlCustomerListRead("wishlist", true);
                XmlCustomerListRead("history", false);                
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Dosya Bulunamadı! " + Hata.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //ürünler için butonlar
        private void btnBook_Click(object sender, EventArgs e)
        {
            if (logUser!=null)
            {
                if (Login.IsUserLoggedIn())
                {
                    logUser.LogButtonClicks(btnBook.Text);
                    frmShop = new FormShopping();
                    frmShop.comBProductTypes.SelectedIndex = 0;
                    this.Hide();
                    frmShop.ShowDialog();
                    frmShop.Dispose();
                    this.Show();
                }
            }
            
            else
                MessageBox.Show("Lütfen Giriş Yapınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnMagazine_Click(object sender, EventArgs e)
        {
            if (logUser != null)
            {
                if (Login.IsUserLoggedIn())
                {
                    logUser.LogButtonClicks(btnMagazine.Text);
                    frmShop = new FormShopping();
                    frmShop.comBProductTypes.SelectedIndex = 1;
                    this.Hide();
                    frmShop.ShowDialog();
                    frmShop.Dispose();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Giriş Yapınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMusic_Click(object sender, EventArgs e)
        {
            if (logUser != null)
            {
                if (Login.IsUserLoggedIn())
                {
                    logUser.LogButtonClicks(btnMusic.Text);
                    frmShop = new FormShopping();
                    frmShop.comBProductTypes.SelectedIndex = 2;
                    this.Hide();
                    frmShop.ShowDialog();
                    frmShop.Dispose();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Giriş Yapınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //sepetim ve alışveriş geçmişi butonları
        private void btnShowWhisList_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnShowWhisList.Text);
            frmWishList = new FormWishList();
            this.Hide();
            frmWishList.ShowDialog();
            this.Show();
            frmWishList.Dispose();
        }
        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnOrderHistory.Text);
            frmShop = new FormShopping();
            this.Hide();
            frmShop.tabCShoppingForm.SelectedTab = frmShop.tabPOrders;
            frmShop.ShowDialog();
            this.Show();
            frmShop.Dispose();            
        }

     
        //kullanıcının sepeti ve satın alımları xml'den okuma
        public static void XmlCustomerListRead(string str,bool bl)
        {
            XDocument xdoc = XDocument.Load(@"customer.xml");
            for (int i = 0; i < customerHolder.Count; i++)
            {
                var items = from item in xdoc.Descendants("customer")
                            where item.Element("id").Value == customerHolder[i].ID.ToString()
                            select item;

                foreach (XElement item in items)
                {
                    if (item.Descendants(str).Any())
                    {
                        if (item.Element(str).Descendants("book").Any())
                        {
                            var newitems = item.Element(str).Descendants("book");
                            foreach (XElement item2 in newitems)
                            {
                                Book newBook = (Book)ProductFactory.FactoryMethod("Book", item2.Element("name").Value
                                , double.Parse(item2.Element("price").Value), int.Parse(item2.Element("stock").Value), false);
                                newBook.Author = item2.Element("author").Value;
                                newBook.ISBN = item2.Element("isbn").Value;
                                newBook.Page = int.Parse(item2.Element("page").Value);
                                newBook.Publisher = item2.Element("publisher").Value;
                                newBook.ID = int.Parse(item2.Element("id").Value);
                                ItemToPurchase newItems = new ItemToPurchase();
                                newItems.Product = newBook.CloneIT();
                                newItems.Product.Price = newBook.Price;
                                newItems.Quantity = newBook.Stock;
                                if(bl)
                                    customerHolder[i].WishList.Add(newItems);
                                else
                                    customerHolder[i].PurchaseHistory.Add(newItems);
                            }
                        }
                        if (item.Element(str).Descendants("magazine").Any())
                        {
                            var newitems = item.Element(str).Descendants("magazine");
                            foreach (XElement item2 in newitems)
                            {
                                Magazine newMagazine = (Magazine)ProductFactory.FactoryMethod("Magazine", item2.Element("name").Value
                       , double.Parse(item2.Element("price").Value), int.Parse(item2.Element("stock").Value), false);
                                newMagazine.Issue = item2.Element("issue").Value;
                                newMagazine.MagType = (TypeOfMagazine)Enum.Parse(typeof(TypeOfMagazine), item2.Element("type").Value);
                                newMagazine.ID = int.Parse(item2.Element("id").Value);
                                ItemToPurchase newItems = new ItemToPurchase();
                                newItems.Product = newMagazine.CloneIT();
                                newItems.Product.Price = newMagazine.Price;
                                newItems.Quantity = newMagazine.Stock;
                                if (bl)
                                    customerHolder[i].WishList.Add(newItems);
                                else
                                    customerHolder[i].PurchaseHistory.Add(newItems);
                            }
                        }
                        if (item.Element(str).Descendants("music").Any())
                        {
                            var newitems = item.Element(str).Descendants("music");
                            foreach (XElement item2 in newitems)
                            {
                                MusicCD newMusic = (MusicCD)ProductFactory.FactoryMethod("MusicCD"
                        , item2.Element("name").Value, double.Parse(item2.Element("price").Value)
                        , int.Parse(item2.Element("stock").Value), false);
                                newMusic.Singer = item2.Element("singer").Value;
                                newMusic.MusType = (TypeOfMusic)Enum.Parse(typeof(TypeOfMusic), item2.Element("type").Value);
                                newMusic.ID = int.Parse(item2.Element("id").Value);
                                ItemToPurchase newItems = new ItemToPurchase();
                                newItems.Product = newMusic.CloneIT();
                                newItems.Product.Price = newMusic.Price;
                                newItems.Quantity = newMusic.Stock;
                                if (bl)
                                    customerHolder[i].WishList.Add(newItems);
                                else
                                    customerHolder[i].PurchaseHistory.Add(newItems);
                            }
                        }
                    }
                }
            }
        }

        //form kapanınca kullanıcıyı çıkar
        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Login.IsUserLoggedIn())
                btnLogOut_Click(sender, e);
        }

        //ürünlerin tutulduğu xml dosyası güncelleniyor
        public static void UpdateProductXml()
        {
            XDocument xmlDoc = XDocument.Load(@"store.xml");

            xmlDoc.Root.Element("products").Remove();
            xmlDoc.Root.Add(new XElement("products"));

            for (int i = 0; i < FormAdmin.productList.Count; i++)
            {               
                 if (FormAdmin.productList[i].GetType() == typeof(Book))
                    {
                        Book bk = new Book();
                        bk = (Book)FormAdmin.productList[i].CloneIT();
                        try
                        {
                            xmlDoc.Root.Element("products").Element("books").Add(new XElement("book",
                            new XElement("name", bk.Name),
                            new XElement("price", bk.Price.ToString()),
                            new XElement("author", bk.Author),
                            new XElement("publisher", bk.Publisher),
                            new XElement("page", bk.Page),
                            new XElement("isbn", bk.ISBN),
                            new XElement("stock", bk.Stock),
                            new XElement("id", bk.ID)));
                        }
                        catch (Exception)
                        {
                        xmlDoc.Root.Element("products").Add(
                        new XElement("books",
                        new XElement("book",
                        new XElement("name", bk.Name),
                        new XElement("price", bk.Price.ToString()),
                        new XElement("author", bk.Author),
                        new XElement("publisher", bk.Publisher),
                        new XElement("page", bk.Page),
                        new XElement("isbn", bk.ISBN),
                        new XElement("stock", bk.Stock),
                        new XElement("id", bk.ID))));
                        }
                    }
                else if (FormAdmin.productList[i].GetType() == typeof(Magazine))
                {
                    Magazine mag = new Magazine();
                    mag = (Magazine)FormAdmin.productList[i].CloneIT();
                    try
                    {
                        xmlDoc.Root.Element("products").Element("magazines").Add(new XElement("magazine",
                        new XElement("name", mag.Name),
                        new XElement("price", mag.Price.ToString()),
                        new XElement("issue", mag.Issue),
                        new XElement("type", mag.MagType),
                        new XElement("stock", mag.Stock),
                        new XElement("id", mag.ID)));
                    }
                    catch (Exception)
                    {
                        xmlDoc.Root.Element("products").Add(
                        new XElement("magazines",
                        new XElement("magazine",
                        new XElement("name", mag.Name),
                        new XElement("price", mag.Price.ToString()),
                        new XElement("issue", mag.Issue),
                        new XElement("type", mag.MagType),
                        new XElement("stock", mag.Stock),
                        new XElement("id", mag.ID))));
                    }
                }
                else if (FormAdmin.productList[i].GetType() == typeof(MusicCD))
                {
                    MusicCD mcd = new MusicCD();
                    mcd = (MusicCD)FormAdmin.productList[i].CloneIT();
                    try
                    {
                        xmlDoc.Root.Element("products").Element("musics").Add(new XElement("music",
                        new XElement("name", mcd.Name),
                        new XElement("price", mcd.Price.ToString()),
                        new XElement("singer", mcd.Singer),
                        new XElement("type", mcd.MusType),
                        new XElement("stock", mcd.Stock),
                        new XElement("id", mcd.ID)));
                    }
                    catch (Exception)
                    {
                        xmlDoc.Root.Element("products").Add(
                        new XElement("musics",
                        new XElement("music",
                        new XElement("name", mcd.Name),
                        new XElement("price", mcd.Price.ToString()),
                        new XElement("singer", mcd.Singer),
                        new XElement("type", mcd.MusType),
                        new XElement("stock", mcd.Stock),
                        new XElement("id", mcd.ID))));
                    }
                }
            }
            xmlDoc.Save(@"store.xml");
        }

        private void btnbackAdminPanel_Click(object sender, EventArgs e)
        {
            frmAdminlogin = new FormAdminLogin();
            this.Hide();
            frmAdminlogin.ShowDialog();
            frmAdminlogin.Dispose();
            this.Show();         
        }
    }
}
