using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
   public class CarRepository
    {
        //1.list car order by year
        public IEnumerable<Car> GetNewestCar()
        {

            using (var carDBContext = new CarsDBContext())
            {
                return carDBContext.Car.OrderByDescending(c => c.Year).ToList();


           }
        }
        //2.List car order by name
        public IEnumerable<Car> GetCar_ByMakeName()
        {
            
            using (var carDBContext = new CarsDBContext())
            {
                return carDBContext.Car.OrderBy(c => c.Make).ToList();
            }
            
        }
        //3.list car order by price
        public IEnumerable<Car> GetCar_ByPrice()
        {
         
            using (var carDBContext = new CarsDBContext())
            {
                return carDBContext.Car.OrderByDescending(c => c.Price).ToList();
                    
            }
            
        }
        //4.list car order by value
        public IEnumerable<Car> GetBestValueCar()
        {
            
            using (var carDBContext = new CarsDBContext())
            {
                var max = carDBContext.Car.Max(x => x.TCC_Rating);
                return carDBContext.Car.Where(y => y.TCC_Rating == max).ToList();

            }
           
        }
        //5.list car order by consumption
        public Dictionary<string, float> GetConsumptionByDistance(float distance)
        {
            

            using (var carDBContext = new CarsDBContext())
            {
                return carDBContext.Car.OrderBy(x => x.MPG)
                    .ToDictionary(x => x.Make+  "-"+x.Model, x => distance / x.MPG);
            }
           
        }
        //6.Get a random car from list
        public Car GetRandomCar()
        {
            List<Car> car = new List<Car>();
            using (var carDBContext = new CarsDBContext())
            {
                car = carDBContext.Car.ToList();

            }
            Random rand = new Random();
            int random = rand.Next(car.Count());
            return car[random];
        }
        //7.get the avg mpg by year
        public Dictionary<int, double> GetMPG_ByYear()
        {
           
            using (var carDBContext = new CarsDBContext())
            {
                return carDBContext.Car.GroupBy(x => x.Year, m => m.MPG)
                    .ToDictionary(m => m.Key, k => k.Average());
                    
            }
            
        }
    }
}
