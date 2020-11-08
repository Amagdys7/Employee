using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.DAL.Entities;
using Employee.DAL.Repository;

namespace Employee.BL.RepositoryClasses
{
   public  class EmployeeNRepository : IEmployeeRepository
    {


        EmployeeContext em = new EmployeeContext();
        public void Add(EmployeeN e)
        {
            em.employeeNs.Add(e);
            em.SaveChanges();
        }

        public void Edit(EmployeeN b)
        {
            em.Entry(b).State = System.Data.Entity.EntityState.Modified;
        }

       

        public IEnumerable<EmployeeN> GetEmployeeNs()
        {
            IEnumerable<EmployeeN> emplo = em.employeeNs.ToList();
            return emplo;
        }

        public void Remove(string EmployeeNID)
        {
            EmployeeN b = em.employeeNs.Find(EmployeeNID);
            em.employeeNs.Remove(b);
            em.SaveChanges();
        }

        EmployeeN IEmployeeRepository.FindById(string employeeNID)
        {

            int empid = Convert.ToInt32(employeeNID);
            EmployeeN e = em.employeeNs.Where(x => x.EmployeeID == empid).FirstOrDefault();
            return e;
        }
    }
}
