using System;
using System.Collections;
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
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
        }
       

        ProductDal _productDal = new ProductDal();
        UserDal _userDal = new UserDal();
        List<int> cartPrice = new List<int>();
        int sum = 0;
        
        public void UserPage_Load(object sender, EventArgs e)
        {
            txtProductName.ReadOnly = true;
            txtProductPrice.ReadOnly = true;
            txtAmount.ReadOnly = true;
            txtSum.ReadOnly = true;
            
            dataProducts.DataSource = _productDal.GetAll();
            dataProducts.Columns[0].Visible = false;
            
           

            lblUserName.Text = SingIn.username;
            

        }
        public void SearchLoad(string key)
        {
            
            dataProducts.DataSource = _productDal.GetByName(key); ;
            


        }

        private void dataUserList1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = dataProducts.CurrentRow.Cells[1].Value.ToString();
            txtProductPrice.Text = dataProducts.CurrentRow.Cells[2].Value.ToString();
            txtAmount.Text = dataProducts.CurrentRow.Cells[3].Value.ToString();
           
        }

        
        public  void button1_Click(object sender, EventArgs e)
        {

            int stock = Convert.ToInt32(txtAmount.Text);
            string productName = txtProductName.Text;
            int productPrice = Convert.ToInt32(txtProductPrice.Text);
            if (stock!=0)
            {
                
                listBoxCart.Items.Add(productName);
                cartPrice.Add(productPrice);
                sum = cartPrice.Sum();
            }
            else
            {
                MessageBox.Show("Ürün Stoklarımızda Tükendi");
            }
            
            
            txtSum.Text = Convert.ToString(sum+" "+"TL");
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreditCard creditCard = new CreditCard();
            creditCard.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            listBoxCart.Items.Clear();
            cartPrice.Clear();
            txtSum.Clear();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            SearchLoad(txt_Search.Text);
        }

        
    }
}
