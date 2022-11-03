using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class Main : Form
    {
        bool sidebarExpand;

        public Main()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
             

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            openChildForm(new Products());
        }

        private void ptcProd_Click(object sender, EventArgs e)
        {
            openChildForm(new Products());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            openChildForm(new Customers());
        }

        private void ptcCust_Click(object sender, EventArgs e)
        {
            openChildForm(new Customers());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new Orders());
        }

        private void ptcOrd_Click(object sender, EventArgs e)
        {
            openChildForm(new Orders());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new User());
        }

        private void ptcUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new User());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            openChildForm(new Categories());
        }

        private void ptcCat_Click(object sender, EventArgs e)
        {
            openChildForm(new Categories());
        }
    }
}
