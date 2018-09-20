using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Domain
{
    /// <summary>
    /// Represents a Computer.
    /// </summary>
    public class Computer
    {
        public Department Department { get; set; }

        public string UserName { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string RAM { get; set; }

        public string PCName { get; set; }

        public string GMPc { get; set; }

        public string GMMonitor { get; set; }

        public string OperativeSis { get; set; }

        public string License { get; set; }

        public string OfficeVer { get; set; }

        public string OfficeLic { get; set; }

        public bool Disclaimer { get; set; }

        public bool Antivirus { get; set; }

        public string AdditionalLic { get; set; }



        public Computer(Department department, string user, string brand, string model, string ram, string pcName, string gmPc,
            string gmMonitor, string operativeSis, string license, string officeVer, string officeLic, bool disclaimer, bool antivirus,
            string additionalLic)
        {
            Department = department;
            UserName = user;
            Brand = brand;
            Model = model;
            RAM = ram;
            PCName = pcName;
            GMPc = gmPc;
            GMMonitor = gmMonitor;
            OperativeSis = operativeSis;
            License = license;
            OfficeVer = officeVer;
            OfficeLic = officeLic;
            Disclaimer = disclaimer;
            Antivirus = antivirus;
            AdditionalLic = additionalLic;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Computer other = (Computer)obj;
            return this.UserName == other.UserName &&
                this.GMPc == other.GMPc;
        }
    }
}
