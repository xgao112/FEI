using DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            CarRepository c = new CarRepository();

            foreach (var item in c.GetNewestCar())
            {
                Console.WriteLine(item.Make+" " +item.Year);
            }
                
           
            Console.ReadLine();
            
        }
    }
}
