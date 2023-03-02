using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sales
{
    public partial class Brand : Form
    {
        public Brand()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void LoadBrand()
        {
            dgvBrand.Rows.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BrandModule moduleform = new BrandModule();
            moduleform.ShowDialog();
        }

        private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
