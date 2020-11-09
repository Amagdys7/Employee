using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.DAL.Entities;

namespace Employee.DAL.Repository
{
   public interface IEmployeeRepository
    {

        void Add(EmployeeN e);
        void Edit(EmployeeN b);
        void Remove(string EmployeeNID);
        IEnumerable<EmployeeN> GetEmployeeNs();
        EmployeeN FindById(string EmployeeNID);

    }
}
