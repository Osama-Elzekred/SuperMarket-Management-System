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
    public partial class BrandModule : Form
    {
        public BrandModule()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            txtBrand.Clear();
        }

        private void BrandModule_Load(object sender, EventArgs e)
        {

        }
    }
}
