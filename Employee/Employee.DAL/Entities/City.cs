using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DAL.Entities
{
    public class City
    {
        [Key]
        public int ID { get; set; }
        public int Name { get; set; }

        public DateTime MyDate{get; set;}


        public TimeSpan Mytime { get; set; }
        public  int countryID { get; set; }

        public virtual Country country { get; set; }


    }
}
