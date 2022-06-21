using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnologyMarket
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }


        private void btn_Singin_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "" || txt_Password.Text=="")
            {

                MessageBox.Show("* alanlar boş geçilemez");

                return;

            }
            else
            {
                using (ShopingContext context = new ShopingContext())
                            {
                                User u = new User();
                                u.USERNAME = txt_Username.Text;
                                u.NAME = txt_Name.Text;
                                u.SURNAME = txt_Surname.Text;
                                u.PASSWORD = txt_Password.Text;
                                u.ADDRESS = txt_Address.Text;
                                context.Users.Add(u);
                                context.SaveChanges();
                                MessageBox.Show("Yeni Kullanıcı Kaydedildi");
                                Hide();
                            }
            }
            
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
