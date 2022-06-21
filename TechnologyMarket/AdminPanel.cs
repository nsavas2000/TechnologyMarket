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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            dataProductList.DataSource = _productDal.GetAll();

        }
        private void SearchLoad(string key)
        {
            var result = _productDal.GetByName(key);
            dataProductList.DataSource = result;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                PRODUCTNAME = txt_Productname.Text,
                PRICE = Convert.ToInt32(txt_Productprice.Text),
                AMOUNT = Convert.ToInt32(txt_Amount.Text)

            });
            dataProductList.DataSource = _productDal.GetAll();
            MessageBox.Show("Ürün Eklendi");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                PRODUCTID = Convert.ToInt32(dataProductList.CurrentRow.Cells[0].Value),
                PRODUCTNAME = txt_Updatename.Text,
                PRICE = Convert.ToInt32(txt_Updateprice.Text),
                AMOUNT=Convert.ToInt32(txt_Updateamount.Text)

            });
            dataProductList.DataSource = _productDal.GetAll();
            MessageBox.Show("Ürün Güncellendi");

        }

        private void dataProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           txt_Updatename.Text = dataProductList.CurrentRow.Cells[1].Value.ToString();
           txt_Updateprice.Text = dataProductList.CurrentRow.Cells[2].Value.ToString();
           txt_Updateamount.Text = dataProductList.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            _productDal.Deleted(new Product
            {
                PRODUCTID = Convert.ToInt32(dataProductList.CurrentRow.Cells[0].Value.ToString())
            });
            dataProductList.DataSource = _productDal.GetAll();
            MessageBox.Show("Ürün Silindi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usersview usersview = new Usersview();
            usersview.Show();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            SearchLoad(txt_Search.Text);
        }
    }
}
