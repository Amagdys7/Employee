using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Employee.DAL.Entities
{
    public class Country
    {
        [Key]
        public int CountryID { get; set; }

        [Display(Name = "Country Name")]
        [MaxLength(50, ErrorMessage = "Maximam Length is 50")]
        public string CountryNAme { get; set; }

        public ICollection<City> cities {get; set;}

    }
}
