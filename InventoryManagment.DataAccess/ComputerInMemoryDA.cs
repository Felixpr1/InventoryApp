using InventoryManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagment.DataAccess
{
    public class ComputerInMemoryDA : IComputerDA
    {
        /// <summary>The in-memory collection of employees.</summary>
        private List<Computer> computers = null;

        /// <summary>
        /// Creates a data access object for the in-memory collection.
        /// </summary>
        public ComputerInMemoryDA()
        {
            computers = GetAllComputer();
        }

        /// <summary>
        /// Returns the list of all employees in the collection.
        /// </summary>
        /// <returns>The list of all employees.</returns>
        public List<Computer> GetAllComputer()
        {
            if (computers == null)
            {
                computers = new List<Computer>() {
                    new Computer(Department.Asuntos_Legales,"Felix Ortiz",
                    "Dell","GTX-1070","4","Felix Pc","787787787","787787787","Windowa XP",
                    "w7fwr7e8","2010","AUS6SF5",true,true,"NO TIENE NADA")
                };
            }
            return computers;
        }


        /// <summary>
        /// Adds the given employee to the collection of employees.
        /// </summary>
        /// <param name="employee">The employee to be added.</param>
        public void AddComputer(Computer computer)
        {
          computers.Add(computer);
        }
    }
}
