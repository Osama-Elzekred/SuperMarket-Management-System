﻿using System;
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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModule productModule = new ProductModule(this);
            productModule.ShowDialog(); 
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }
    }
}