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
    public partial class frmHomeControl : UserControl
    {
        private IComputerDA computerDA;

        public frmHomeControl()
        {
            
            InitializeComponent();
            computerDA = new ComputerInMemoryDA();
        }

        private void frmHomeControl_Load(object sender, EventArgs e)
        {
            this.FillComputerListView();
        }

        private void FillComputerListView()
        {
            lvwHome.Items.Clear();
            foreach(Computer computer in computerDA.GetAllComputer())
            {
                string[] fields ={
                    computer.Department.ToString(),computer.UserName, computer.Brand,computer.Model,computer.RAM,
                computer.PCName,computer.GMPc,computer.GMMonitor,computer.OperativeSis,computer.License,computer.OfficeVer,
                computer.OfficeLic,computer.Disclaimer.ToString(),computer.Antivirus.ToString(),computer.AdditionalLic};
                lvwHome.Items.Add(new ListViewItem(fields));
            }
        }
        


    }
}
