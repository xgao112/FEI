namespace DataAccess.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.CarsDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccess.CarsDBContext context)
        {
            context.Car.AddOrUpdate(
                new Car { Make = "Honda", Model = "CRV", Color = "Green", Year = 2016, Price = 23845, TCC_Rating = 8, MPG = 33 },
                new Car { Make = "Ford", Model = "Escape", Color = "Red", Year = 2017, Price = 238590, TCC_Rating = 7.8, MPG = 32 },
                new Car { Make = "Hyundai", Model = "SanteFe", Color = "Grey", Year = 2016, Price = 24950, TCC_Rating = 8, MPG = 27 },
                new Car { Make = "Mazda", Model = "CX-5", Color = "Red", Year = 2017, Price = 21795, TCC_Rating = 8, MPG = 35 },
                new Car { Make = "Subaru", Model = "Forester", Color = "Blue", Year = 2016, Price = 22395, TCC_Rating = 8.4, MPG = 32 }
          );
        }
    }
}
