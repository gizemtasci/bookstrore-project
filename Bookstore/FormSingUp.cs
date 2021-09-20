using System;
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
    public partial class FormSingUp : Form
    {
        public Customer cst;
        bool []flag= {true,true};

        public FormSingUp()
        {
            InitializeComponent();
        }

        //kayıt butonu
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtMail.Text == "" || txtName.Text == ""
                || txtPassword.Text == "" || txtPhone1.Text.Length != 3
                || txtPhone2.Text.Length != 7 || txtSurname.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Eksik Bilgileri Doldurunuz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cst = new Customer();
                cst.Name = txtName.Text;
                cst.Surname = txtSurname.Text;
                cst.Username = txtUsername.Text;
                cst.Mail = txtMail.Text;
                cst.Phone = txtPhone1.Text + txtPhone2.Text;
                cst.Password = txtPassword.Text;
                cst.Address = txtAddress.Text;
                cst.ID = int.Parse(ProductFactory.GetID());
                cst.SaveCustomer();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        //iptal butonu
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }     


        //parola textboxında boşluk kaldırma
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }
        //kullanıcı adında ilk karakterin boşluk olması ve birden fazla boşluk olmasının iptali
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && 
                (txtUsername.Text=="" || txtUsername.Text[txtUsername.Text.Length-1] == ' '))
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        //isimde ilk karakterin boşluk olması ve birden fazla boşluk olmasının iptali
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && 
                (txtName.Text == "" || txtName.Text[txtName.Text.Length - 1] == ' '))
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }
        //isimde alfabetik karakter izni
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsLetter(ch) && ch!=8 && ch != 32)
            {
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        //soyisimde boşluk olmasının iptali
        private void txtSurname_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }
        //soyisimde alfabetik karakter izni
        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            {
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        //mail default yazıyı tıklanınca silme
        private void txtMail_Click(object sender, EventArgs e)
        {
            if (flag[0])
            {
                flag[0] = false;
                txtMail.Text = "";
                txtMail.ForeColor = Color.Black;
            }
        }
        //mail boşluk iptali
        private void txtMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        //telefon numarası işlemleri
        private void txtPhone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        private void txtPhone1_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone1.TextLength >=3)
            {
                txtPhone2.Focus();
            }
        }

        private void txtPhone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        private void txtPhone2_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone2.TextLength >= 7)
            {
                txtAddress.Focus();
            }
        }

        private void FormSingUp_Activated(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
