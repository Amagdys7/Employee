using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.DAL.Entities;
using Employee.DAL.Repository;

namespace Employee.BL.RepositoryClasses
{
    public class CountryRepository : ICountryRepository
    {
        EmployeeContext em = new EmployeeContext();
        public void Add(Country C)
        {
            em.countries.Add(C);
            em.SaveChanges();
        }

        public void Edit(Country C)
        {
            em.Entry(C).State = System.Data.Entity.EntityState.Modified;
        }

        public Country FindById(string CountryID)
        {
            int countryid = Convert.ToInt32(CountryID);
            Country cc = em.countries.Where(x => x.CountryID == countryid).FirstOrDefault();
            return cc;
        }

        public IEnumerable<Country> GetCountry()
        {
            IEnumerable<Country> countriess = em.countries.ToList();
            return countriess;
        }

        public void Remove(string CountryID)
        {
            Country c = em.countries.Find(CountryID);
            em.countries.Remove(c);
            em.SaveChanges();
        }
    }
}
