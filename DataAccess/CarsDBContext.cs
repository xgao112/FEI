using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class CarsDBContext:DbContext
    {
        public CarsDBContext():base("Name=CarsDBContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Car> Car { get; set; }
    }
}
