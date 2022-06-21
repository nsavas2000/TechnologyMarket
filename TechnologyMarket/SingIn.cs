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
    public partial class SingIn : Form
    {
        public SingIn()
        {
            InitializeComponent();
        }

        public static string username;
        
        
        private void SingIn_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_Newaccount_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            Hide();
            createAccount.Show();
        }

        public void btn_Singin_Click(object sender, EventArgs e)
        {
            
            username = txt_Username.Text;
            var password = txt_Password.Text;
            var errorMessage = "";
            var isError = false;

           

            if (string.IsNullOrEmpty(username))
            {
                errorMessage += "Kullanıcı adını boş geçemezsiniz!\r\n";
                isError = true;
            }
            if (string.IsNullOrEmpty(password))
            {
                errorMessage += "Şifreyi boş geçemezsiniz!\r\n";
                isError = true;
            }
            if (isError)
            {
                MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var loginSatate = Login(username, password);

            if (loginSatate)
            {
                if (username == "admin" && password == "123")
                {
                    AdminPanel frmAdmin= new AdminPanel();
                    frmAdmin.Show();
                }
                else
                {
                    UserPage frmUser = new UserPage();
                    frmUser.Show();
                }


            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola hatası");
            }
            this.Hide();
        }
        public bool Login(string username, string password)
        {

            using (ShopingContext context = new ShopingContext())
            {
                var user = context.Users.Where(x => username == x.USERNAME && password == x.PASSWORD).FirstOrDefault();
                if (user != null)
                {
                    return true;
                }
                return false;
            }
            
        }
        


        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = true;

        }
    }
}
