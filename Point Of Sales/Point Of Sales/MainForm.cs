using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sales
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }
        #region panelSlide
        private void customizeDesign()
        {
            panelSubProduct.Visible = false;
            panelSubRecord.Visible = false;
            panelSubStock.Visible = false;
            panelSubSetting.Visible = false;    
        }
        private void hideSubmenu()
        {
            if(panelSubProduct.Visible==true)
            { panelSubProduct.Visible = false; }
            if (panelSubRecord.Visible == true)
            { panelSubRecord.Visible = false; }
            if (panelSubStock.Visible == true)
            { panelSubStock.Visible = false; }
            if (panelSubSetting.Visible == true)
            { panelSubSetting.Visible = false; }
        }
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        #endregion panelSlide
        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubProduct);
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnInStock_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubStock);
        }

        private void btnStockEntry_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnStockAdministrator_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubRecord);
        }

        private void btnSaleHistory_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnPOSRecord_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubSetting);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lang_combBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lang_combBox.SelectedIndex==0)
            //{
            //    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar");
            //    this.Controls.Clear();
            //    InitializeComponent();

            //}
            //else
            //{
            //    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
            //    this.Controls.Clear();
            //    InitializeComponent();
            //    this.RightToLeft = RightToLeft.No;
            //    this.RightToLeftLayout = false;
            //}
            switch (lang_combBox.SelectedIndex)
            {      // change the lang to Arabic
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");
                    this.Controls.Clear();
                    InitializeComponent();
                    break;

                // change the lang to English
                case 1:
                default:
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                    this.Controls.Clear();
                    InitializeComponent();
                    this.RightToLeft = RightToLeft.No;
                    this.RightToLeftLayout = false;
                    break;
            }

        }
    }
}
