using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.DAL.Entities;
namespace Employee.DAL.Repository
{
    public interface ICityRepository
    {


        void Add(City C);
        void Edit(City C);
        void Remove(string CityID);
        IEnumerable<City> GetCity();
        City FindById(string cityID);
    }
}
