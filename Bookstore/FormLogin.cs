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
    public partial class FormLogin : Form
    {
        Login logUser;
        FormAdmin frmAdm;
        public FormLogin()
        {
            InitializeComponent();
        }
        //geri butonu
        private void btnLogCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //giriş butonu
        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            logUser = Login.GetInstance;
            if (logUser.CheckUserIDPass(FormHome.customerHolder, txtUsername, txtPassword))
                {
                    if (txtUsername.Text == "Admin")
                    {
                        frmAdm = new FormAdmin();
                        this.Hide();
                        frmAdm.ShowDialog();
                        frmAdm.Dispose();
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            
            
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Text = "";
                txtUsername.Text = "";
                logUser = null;
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            logUser = null;
        }
    }
}
