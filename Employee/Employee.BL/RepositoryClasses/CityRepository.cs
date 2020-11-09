using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.DAL.Entities;
using Employee.DAL.Repository;

namespace Employee.BL.RepositoryClasses
{
   public class CityRepository : ICityRepository
    {



        EmployeeContext em = new EmployeeContext();

        public void Add(City C)
        {
            em.cities.Add(C);
            em.SaveChanges();
        }

        public void Edit(City C)
        {

            em.Entry(C).State = System.Data.Entity.EntityState.Modified;
        }

        public City FindById(string cityID)
        {
            int cityid = Convert.ToInt32(cityID);
            City cc = em.cities.Where(x => x.ID == cityid).FirstOrDefault();
            return cc;
        }

        public IEnumerable<City> GetCity()
        {
            IEnumerable<City> cities = em.cities.ToList();
            return cities;
        }

        public void Remove(string CityID)
        {
            City c = em.cities.Find(CityID);
            em.cities.Remove(c);
            em.SaveChanges();
        }

       
    }
}
