using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.DAL.Entities;

namespace Employee.BL
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("EmployeeConnectionString")
        {


        }

        public DbSet<EmployeeN> employeeNs {get; set;}

        public DbSet<Country> countries { get; set; }
        public DbSet<City> cities { get; set; }

    }
}
