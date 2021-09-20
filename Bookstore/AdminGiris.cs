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
    public partial class FormAdminLogin : Form
    {
        public FormAdminLogin()
        {
            InitializeComponent();
        }
        FormAdmin frmAdmin;
        private void btnadminlogin_Click(object sender, EventArgs e)
        {
            if(txt_username.Text=="admin" && txt_password.Text == "admin")
            {
                frmAdmin = new FormAdmin();
                this.Hide();
                frmAdmin.ShowDialog();
                frmAdmin.Dispose();
                this.Show();


            }
        }

        private void FormAdminLogin_Load(object sender, EventArgs e)
        {
            FormAdmin frmAdmin;
        }
    }
}
