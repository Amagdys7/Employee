using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.DAL.Entities;
namespace Employee.DAL.Repository
{
   public interface ICountryRepository
    {

        void Add(Country C);
        void Edit(Country  C);
        void Remove(string CountryID);
        IEnumerable<Country> GetCountry();
        Country FindById(string CountryID);
    }
}
