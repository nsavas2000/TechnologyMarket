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
    public partial class Usersview : Form
    {
        public Usersview()
        {
            InitializeComponent();
        }

        UserDal _userDal = new UserDal();
        private void Usersview_Load(object sender, EventArgs e)
        {
            dataProductView.DataSource = _userDal.GetAll();
        }
    }
}
