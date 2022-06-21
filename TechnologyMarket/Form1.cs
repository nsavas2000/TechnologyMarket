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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       
        private void btn_Customer_Click(object sender, EventArgs e)
        {
            SingIn singIn = new SingIn();
            
            singIn.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kontrolAbout1.Hide();
            kontrolContact1.Hide();
            kontrolHP1.Show();
            kontrolHP1.BringToFront();
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sepetinizi görebilmek için üye girişi yapmalısınız!");
        }

        

        private void btn_homepage_Click(object sender, EventArgs e)
        {
            kontrolAbout1.Hide();
            kontrolContact1.Hide();
            kontrolHP1.Show();
            kontrolHP1.BringToFront();
        }
        private void btn_about_Click(object sender, EventArgs e)
        {
            kontrolHP1.Hide();
            kontrolContact1.Hide();
            kontrolAbout1.Show();
            kontrolAbout1.BringToFront();
        }

        private void btn_contact_Click(object sender, EventArgs e)
        {
            kontrolHP1.Hide();
            kontrolAbout1.Hide();
            kontrolContact1.Show();
            kontrolContact1.BringToFront();
        }
    }
}
