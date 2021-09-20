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
    public partial class FormWishList : Form
    {
        public FormWishList()
        {
            InitializeComponent();
        }

        //Ana Menü Butonu
        private void btnLogOut2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //sepetimi listview da gösteriyor
        private void FormWishList_Activated(object sender, EventArgs e)
        {
            ShoppingCart.PrintProducts(listViewMyCart);
        }
        //label da kullanıcının ismini gösteriyor
        private void FormWishList_Load(object sender, EventArgs e)
        {
            lbCurrentUserInfo.Text = Login.GetInstance.GetCustomer.Name;
        }
    }
}
