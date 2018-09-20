using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagment.DataAccess;
using InventoryManagement.Domain;

namespace InventoryManagement.Presentation
{
    public partial class frmAddComputer : UserControl

            {
        /// <summary>Provides data access for a employee.</summary>
        private IComputerDA computerDA;
    
        public frmAddComputer()
        {
            InitializeComponent();
            this.computerDA = computerDA;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                //  Computer computer = computerDA.getComputerByGM(txtGMPc.Text);

                Computer compute = new Computer((Department)Enum.Parse(typeof(Department), cbxDepartment.Text), txtUser.Text, txtBrand.Text,
                    txtModel.Text, txtRAM.Text, txtPcName.Text, txtGMPc.Text, txtGMMonitor.Text, txtOperativeSis.Text,
                    txtLicense.Text, txtOfficeVer.Text, txtOfficeLic.Text, true, true, txtAdditionalLic.Text);
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() +
                    "\n" + ex.StackTrace, "Exception Caught",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
