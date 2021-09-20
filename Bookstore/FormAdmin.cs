using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace BookStore
{
    public partial class FormAdmin : Form
    {
        public static List<Product> productList = new List<Product>();
        Login logUser;
        int index = 0;
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            logUser = Login.GetInstance;
            radioBtnBook_CheckedChanged(sender, e);
            tabControlItems.SelectedTab = tabPMain;
            tabControlItems.SelectedTab.Show();          
        }

        //Main Page Buttons
        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnItemAdd.Text);
            if (radioBtnBook.Checked)
            {
                btnBookEdit.Visible = false;
                btnAddBook.Visible = true;
                //textboxları temizle
                txtBookAuthor.Text = "";
                txtBookISBN.Text = "";
                txtBookName.Text = "";
                txtBookPage.Text = "";
                txtBookPrice.Text = "";
                txtBookPublisher.Text = "";
                UpDownBook.Value = 1;

                tabControlItems.SelectedTab = tabPBook;
                tabControlItems.SelectedTab.Show();         
            }
            else if(radioBtnMagazine.Checked)
            {
                btnMagazineEdit.Visible = false;
                btnAddMagazine.Visible = true;
                //textbox temizle
                txtMagazineIssue.Text = "";
                txtMagazineName.Text = "";
                txtMagazinePrice.Text = "";
                comBMagazineType.SelectedIndex = -1;

                tabControlItems.SelectedTab = tabPMagazine;
                tabControlItems.SelectedTab.Show();
            }
            else if(radioBtnMusicCD.Checked)
            {
                btnMusicEdit.Visible = false;
                btnAddMusic.Visible = true;
                //textboxları temizle
                txtMusicSinger.Text = "";
                txtMusicPrice.Text = "";
                txtMusicName.Text = "";
                comBMusicType.SelectedIndex = -1;
                tabControlItems.SelectedTab = tabPMusicCD;
                tabControlItems.SelectedTab.Show();
            }
        }
        private void btnItemRemove_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnItemRemove.Text);
            int chosenItemsNumber = listViewItems.SelectedItems.Count;
            if (productList.Count != 0 && chosenItemsNumber != 0)
            {
                foreach (ListViewItem item in listViewItems.SelectedItems)
                {
                    long itemID = long.Parse(item.SubItems[0].Text);
                    SeeknDestroy(itemID);
                    item.Remove();
                }
            }
            else 
            {
                MessageBox.Show("Herhangi Bir Ürün Seçilmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnItemUpdate_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnItemUpdate.Text);
            if (radioBtnBook.Checked && listViewItems.SelectedItems.Count != 0)
            {
                btnAddBook.Visible = false;
                btnBookEdit.Visible = true;
                for (int i = 0; i < productList.Count; i++)
                {
                    if (listViewItems.SelectedItems[0].SubItems[0].Text == productList[i].ID.ToString())
                    {
                        Book tmp = (Book)productList[i].CloneIT();
                        txtBookAuthor.Text = tmp.Author;
                        txtBookISBN.Text = tmp.ISBN;
                        txtBookName.Text = tmp.Name;
                        txtBookPage.Text = tmp.Page.ToString();
                        txtBookPrice.Text = tmp.Price.ToString();
                        txtBookPublisher.Text = tmp.Publisher;
                        UpDownBook.Value = tmp.Stock;
                        index = i;
                        tabControlItems.SelectedTab = tabPBook;
                        tabControlItems.SelectedTab.Show();
                        break;
                    }
                }
            }

            else if (radioBtnMagazine.Checked && listViewItems.SelectedItems.Count != 0)
            {
                btnAddMagazine.Visible = false;
                btnMagazineEdit.Visible = true;
                for (int i = 0; i < productList.Count; i++)
                {
                    if (listViewItems.SelectedItems[0].SubItems[0].Text == productList[i].ID.ToString())
                    {
                        Magazine tmp = (Magazine)productList[i].CloneIT();
                        txtMagazineIssue.Text = tmp.Issue;
                        txtMagazineName.Text = tmp.Name;
                        txtMagazinePrice.Text = tmp.Price.ToString();
                        comBMagazineType.SelectedIndex = (int)tmp.MagType;
                        UpDownMagazine.Value = tmp.Stock;
                        index = i;
                        tabControlItems.SelectedTab = tabPMagazine;
                        tabControlItems.SelectedTab.Show();
                        break;
                    }
                }
            }
            else if (radioBtnMusicCD.Checked && listViewItems.SelectedItems.Count != 0)
            {
                btnAddMusic.Visible = false;
                btnMusicEdit.Visible = true;
                for (int i = 0; i < productList.Count; i++)
                {
                    if (listViewItems.SelectedItems[0].SubItems[0].Text == productList[i].ID.ToString())
                    {
                        MusicCD tmp = (MusicCD)productList[i].CloneIT();
                        txtMusicName.Text = tmp.Name;
                        txtMusicSinger.Text = tmp.Singer;
                        txtMusicPrice.Text = tmp.Price.ToString();
                        comBMusicType.SelectedIndex = (int)tmp.MusType;
                        UpDownMusic.Value = tmp.Stock;
                        index = i;
                        tabControlItems.SelectedTab = tabPMusicCD;
                        tabControlItems.SelectedTab.Show();
                        break;
                    }
                }
            }
        }
        private void btnBackMain_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnBackMain.Text);
            this.Close();
        }
        private void btnUserPage_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnUserPage.Text);
            PrintListViewUsers();
            tabControlItems.SelectedTab = tabPUser;
            tabControlItems.SelectedTab.Show();
        }
        //Log Tutulan dosyayı açar.
        private void btnLogFile_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnLogFile.Text);
            Process.Start(Application.StartupPath + @"\Log File.txt");
        }

        //Main Page Radio Buttons 
        private void radioBtnMusicCD_CheckedChanged(object sender, EventArgs e)
        {
            listViewItems.Clear();
            listViewItems.View = View.Details;
            listViewItems.GridLines = true;
            listViewItems.FullRowSelect = true;
            listViewItems.Columns.Add("ID", 55);
            listViewItems.Columns.Add("Müzik CD Adı", 275);
            listViewItems.Columns.Add("Sanatçı", 225);
            listViewItems.Columns.Add("Türü", 150);
            listViewItems.Columns.Add("Adet", 55);
            listViewItems.Columns.Add("Fiyat", 75);
            foreach (Product item in productList)
            {
                if (item.GetType() == typeof(MusicCD))
                {
                    string[] row = item.PrintProperties().Split('%');
                    var satir = new ListViewItem(row);
                    listViewItems.Items.Add(satir);
                }
            }
        }
        private void radioBtnBook_CheckedChanged(object sender, EventArgs e)
        {
            listViewItems.Clear();
            listViewItems.View = View.Details;
            listViewItems.GridLines = true;
            listViewItems.FullRowSelect = true;
            listViewItems.Columns.Add("ID", 55);
            listViewItems.Columns.Add("Kitap Adı", 205);
            listViewItems.Columns.Add("Yazarı", 150);
            listViewItems.Columns.Add("Yayımcı", 175);
            listViewItems.Columns.Add("ISBN", 85);
            listViewItems.Columns.Add("Sayfa Sayısı", 40);
            listViewItems.Columns.Add("Adet", 50);
            listViewItems.Columns.Add("Fiyat", 75);
            foreach (Product item in productList)
            {
                if (item.GetType() == typeof(Book))
                {
                    string[] row = item.PrintProperties().Split('%');
                    var satir = new ListViewItem(row);
                    listViewItems.Items.Add(satir);
                }
            }
        }
        private void radioBtnMagazine_CheckedChanged(object sender, EventArgs e)
        {
            listViewItems.Clear();
            listViewItems.View = View.Details;
            listViewItems.GridLines = true;
            listViewItems.FullRowSelect = true;
            listViewItems.Columns.Add("ID", 55);
            listViewItems.Columns.Add("Dergi Adı", 250);
            listViewItems.Columns.Add("Türü", 195);
            listViewItems.Columns.Add("Basım", 210);
            listViewItems.Columns.Add("Adet", 50);
            listViewItems.Columns.Add("Fiyat", 75);
            foreach (Product item in productList)
            {
                if (item.GetType() == typeof(Magazine))
                {
                    string[] row = item.PrintProperties().Split('%');
                    var satir = new ListViewItem(row);
                    listViewItems.Items.Add(satir);
                }
            }
        }

        //Book Page Buttons
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if(txtBookAuthor.Text==""|| txtBookISBN.Text == "" || txtBookName.Text == "" || txtBookPage.Text == "" 
                || txtBookPrice.Text == "" || txtBookPublisher.Text == "")
            {
                MessageBox.Show("Eksik Bilgileri Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Book newBook = (Book)ProductFactory.FactoryMethod("Book", txtBookName.Text, double.Parse(txtBookPrice.Text)
                    , Convert.ToInt32(UpDownBook.Value),true);
                newBook.Author = txtBookAuthor.Text;
                newBook.Page = int.Parse(txtBookPage.Text);
                newBook.ISBN = txtBookISBN.Text;
                newBook.Publisher = txtBookPublisher.Text;
                productList.Add(newBook);
                MessageBox.Show("Ürün Başarılı bir şekilde eklenmiştir", "Bilgilendirme"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);                
               
                radioBtnBook_CheckedChanged(sender, e);
                tabControlItems.SelectedTab = tabPMain;
                tabControlItems.SelectedTab.Show();
            }
        }
        private void btnBookEdit_Click(object sender, EventArgs e)
        {
            Book tmp = (Book)productList[index].CloneIT();
            tmp.Author = txtBookAuthor.Text;
            tmp.ISBN = txtBookISBN.Text;
            tmp.Name = txtBookName.Text;
            tmp.Page = int.Parse(txtBookPage.Text);
            tmp.Price = double.Parse(txtBookPrice.Text);
            tmp.Publisher = txtBookPublisher.Text;
            tmp.Stock = (int)UpDownBook.Value;
            productList[index] = tmp.CloneIT();

            radioBtnBook_CheckedChanged(sender, e);
            tabControlItems.SelectedTab = tabPMain;
            tabControlItems.SelectedTab.Show();
        }
        private void btnCancelBook_Click(object sender, EventArgs e)
        {
            tabControlItems.SelectedTab = tabPMain;
            tabControlItems.SelectedTab.Show();
        }

        //Magazine Page Buttons
        private void btnAddMagazine_Click(object sender, EventArgs e)
        {

            if (txtMagazineIssue.Text == "" || txtMagazineName.Text == ""
                || txtMagazinePrice.Text == "" || comBMagazineType.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik Bilgileri Doldurunuz!", "Uyarı"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Magazine newMagazine = (Magazine)ProductFactory.FactoryMethod("Magazine", txtMagazineName.Text, double.Parse(txtMagazinePrice.Text), Convert.ToInt32(UpDownMagazine.Value),true);
                newMagazine.Issue = txtMagazineIssue.Text;
                newMagazine.MagType = (TypeOfMagazine)comBMagazineType.SelectedIndex;
                productList.Add(newMagazine);
                MessageBox.Show("Ürün Başarılı bir şekilde eklenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioBtnMagazine_CheckedChanged(sender, e);                

                tabControlItems.SelectedTab = tabPMain;
                tabControlItems.SelectedTab.Show();
            }       
        }
        private void btnMagazineEdit_Click(object sender, EventArgs e)
        {
            Magazine tmp = (Magazine)productList[index].CloneIT();
            tmp.Issue = txtMagazineIssue.Text;
            tmp.MagType = (TypeOfMagazine)comBMagazineType.SelectedIndex;
            tmp.Name = txtMagazineName.Text;
            tmp.Price = double.Parse(txtMagazinePrice.Text);
            tmp.Stock = (int)UpDownMagazine.Value;
            productList[index] = tmp.CloneIT();

            radioBtnMagazine_CheckedChanged(sender, e);
            tabControlItems.SelectedTab = tabPMain;
            tabControlItems.SelectedTab.Show();
        }
        private void btnCancelMagazine_Click(object sender, EventArgs e)
        {
            tabControlItems.SelectedTab = tabPMain;
            tabControlItems.SelectedTab.Show();
        }

        //Music Page Buttons
        private void btnAddMusic_Click(object sender, EventArgs e)
        {
            if (txtMusicName.Text == "" || txtMusicPrice.Text == ""
               || txtMusicSinger.Text == "" || comBMusicType.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik Bilgileri Doldurunuz!", "Uyarı"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MusicCD newMusicCD = (MusicCD)ProductFactory.FactoryMethod("MusicCD", txtMusicName.Text
                    , double.Parse(txtMusicPrice.Text), Convert.ToInt32(UpDownMusic.Value),true);
                newMusicCD.Singer = txtMusicSinger.Text;
                newMusicCD.MusType = (TypeOfMusic)comBMusicType.SelectedIndex;
                productList.Add(newMusicCD);
                MessageBox.Show("Ürün Başarılı bir şekilde eklenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                radioBtnMusicCD_CheckedChanged(sender, e);
                tabControlItems.SelectedTab = tabPMain;
                tabControlItems.SelectedTab.Show();
            }
        }
        private void btnMusicEdit_Click(object sender, EventArgs e)
        {
            MusicCD tmp = (MusicCD)productList[index].CloneIT();
            tmp.Singer = txtMusicSinger.Text;
            tmp.MusType = (TypeOfMusic)comBMusicType.SelectedIndex;
            tmp.Name = txtMusicName.Text;
            tmp.Price = double.Parse(txtMusicPrice.Text);
            tmp.Stock = (int)UpDownMusic.Value;
            productList[index] = tmp.CloneIT();


            radioBtnMusicCD_CheckedChanged(sender, e);
            tabControlItems.SelectedTab = tabPMain;
            tabControlItems.SelectedTab.Show();
        }
        private void btnCancelMusic_Click(object sender, EventArgs e)
        {
            tabControlItems.SelectedTab = tabPMain;
            tabControlItems.SelectedTab.Show();
        }

        //user ekranı butonları

        private void btnBackAdminPanel_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnBackAdminPanel.Text);
            tabControlItems.SelectedTab = tabPMain;
            tabControlItems.SelectedTab.Show();
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            logUser.LogButtonClicks(btnDeleteUser.Text);
            if (DialogResult.Yes == MessageBox.Show("Kullanıcıyı Silmek İstediğinize Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                for (int i = 0; i < FormHome.customerHolder.Count; i++)
                {
                    if (listViewUsers.SelectedItems[0].SubItems[0].Text == FormHome.customerHolder[i].ID.ToString())
                    {
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(@"customer.xml");
                        XmlNodeList nodes = xmlDoc.DocumentElement.SelectNodes("/store/customers/customer");
                        foreach (XmlNode node in nodes)
                        {
                            if (node.SelectSingleNode("id").FirstChild.Value == listViewUsers.SelectedItems[0].SubItems[0].Text)
                            {
                                node.ParentNode.RemoveChild(node);
                                break;
                            }
                        }
                        xmlDoc.Save(@"customer.xml");
                        FormHome.customerHolder.RemoveAt(i);
                        break;
                    }
                }
                PrintListViewUsers();
            }
        }

        //listeden ürünü ara yok et
        private void SeeknDestroy(long ID)
        {
            foreach (Product item in productList)
            {
                if (item.ID == ID)
                {
                    productList.Remove(item);
                    break;
                }
            }
        }
        

        // //// //// //// ///// //// //// ///// //// /// /// //// //
        //textboxların boşluk kontrolü ve uygun karakter kontrolü
        //kitap için
        private void txtBookName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space &&
                (txtBookName.Text=="" || txtBookName.Text[txtBookName.Text.Length-1] == ' '))
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }
        private void txtBookISBN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space &&
              (txtBookISBN.Text == "" || txtBookISBN.Text[txtBookISBN.Text.Length - 1] == ' '))
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }
        private void txtBookPrice_KeyPress(object sender, KeyPressEventArgs e)
        {           
            char ch = e.KeyChar;
            if (ch == 44 && txtBookPrice.Text.IndexOf(",") != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
                e.Handled = true;
        }
        private void txtBookAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space &&
             (txtBookAuthor.Text == "" || txtBookAuthor.Text[txtBookAuthor.Text.Length - 1] == ' '))
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }
        private void txtBookAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            {
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }
        private void txtBookPublisher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space &&
              (txtBookPublisher.Text == "" || txtBookPublisher.Text[txtBookPublisher.Text.Length - 1] == ' '))
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }
        private void txtBookPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        //magazine için
        private void txtMagazineName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space &&
               (txtMagazineName.Text == "" || txtMagazineName.Text[txtMagazineName.Text.Length - 1] == ' '))
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }
        private void txtMagazinePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 44 && txtMagazinePrice.Text.IndexOf(",") != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
                e.Handled = true;
        }
        private void txtMagazineIssue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space &&
               (txtMagazineIssue.Text == "" || txtMagazineIssue.Text[txtMagazineIssue.Text.Length - 1] == ' '))
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        //music cd için
        private void txtMusicName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space &&
               (txtMusicName.Text == "" || txtMusicName.Text[txtMusicName.Text.Length - 1] == ' '))
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }
        private void txtMusicPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 44 && txtMusicPrice.Text.IndexOf(",") != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
                e.Handled = true;
        }
        private void txtMusicSinger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space &&
              (txtMusicSinger.Text == "" || txtMusicSinger.Text[txtMusicSinger.Text.Length - 1] == ' '))
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }    
      
        //kullanıcıları listViewUsers da göster
        private void PrintListViewUsers()
        {
            listViewUsers.Clear();
            listViewUsers.View = View.Details;
            listViewUsers.GridLines = true;
            listViewUsers.FullRowSelect = true;
            listViewUsers.Columns.Add("ID", 55);
            listViewUsers.Columns.Add("Ad", 165);
            listViewUsers.Columns.Add("Soyad", 140);
            listViewUsers.Columns.Add("Kullanıcı Adı", 110);
            listViewUsers.Columns.Add("E-Posta", 155);
            listViewUsers.Columns.Add("Telefon", 90);
            listViewUsers.Columns.Add("Adres", 120);
            foreach (Customer cst in FormHome.customerHolder)
            {
                if (cst.Username != "Admin")
                {
                    string[] row = cst.PrintCustomerDetails().Split('%');
                    var satir = new ListViewItem(row);
                    listViewUsers.Items.Add(satir);
                }
            }
        }      
    }
}
