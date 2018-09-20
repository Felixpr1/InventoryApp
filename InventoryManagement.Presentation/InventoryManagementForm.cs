using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Presentation
{
    public partial class frmInventoryManagementForm : Form
    {
        public frmInventoryManagementForm()
        {
           
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHomeControl1.BringToFront();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddComputer1.BringToFront();
            

        }

        private void InventoryManagementForm_Load(object sender, EventArgs e)
        {
            frmHomeControl1.BringToFront();
            btnHome.selected = true;
            WindowState = FormWindowState.Maximized;

        }

        private void lblMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmModifyComputer1.BringToFront();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDeleteForm1.BringToFront();
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            seeComputer1.BringToFront();
        }
    }
}
