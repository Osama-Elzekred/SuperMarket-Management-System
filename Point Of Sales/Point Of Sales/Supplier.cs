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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            SupplierModule sup = new SupplierModule(this);
            sup.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
