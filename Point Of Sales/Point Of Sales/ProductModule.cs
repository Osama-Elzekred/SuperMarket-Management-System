using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sales
{
    public partial class ProductModule : Form
    {
        /* SqlConnection cn = new SqlConnection();
         SqlCommand cm = new SqlCommand();  
         DBConnect dbcon =new DBConnect();*/
        المنتجات product;
        public ProductModule(المنتجات pd)
        {
            InitializeComponent();
            //cn = new SqlConnection(dbcon.myConnection());
            product = pd;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
