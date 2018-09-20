using InventoryManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagment.DataAccess
{
    public interface IComputerDA
    {
        /// <summary>
        /// Returns the list of all employees in the collection.
        /// </summary>
        /// <returns>The list of all employees</returns>
        List<Computer> GetAllComputer();
        /// <summary>
        /// Returns the data of the employee in the collection with the given id.
        /// </summary>
        /// <param name="id">The id of the searched employee.</param>
        /// <returns>The employee with the given id.</returns>
      // Computer GetComputerByGMPc(string GMPc);
        /// <summary>
        /// Adds the given employee to the collection of employees.
        /// </summary>
        /// <param name="employee">The employee to be added.</param>
        void AddComputer(Computer computer);
    }
}
