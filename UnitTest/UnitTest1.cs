using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess.Repository;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetNewestCar()
        {
            CarRepository c = new CarRepository();
            var result = c.GetNewestCar();

            string expected_FirstCar = "Escape";
            string expected_LastCar = "SanteFe";
            Assert.AreEqual(result.First().Model, expected_FirstCar);
            Assert.AreEqual(result.Last().Model, expected_LastCar);
        }
        [TestMethod]
        public void TestGetCar_ByMakeName()
        {
            CarRepository c = new CarRepository();

            var result = c.GetCar_ByMakeName();

            string expected_FirstCar = "Ford";
            string expected_LastCar = "Subaru";
            Assert.AreEqual(result.First().Make, expected_FirstCar);
            Assert.AreEqual(result.Last().Make, expected_LastCar);
        }
       
        [TestMethod]
        public void TestGetCar_ByPrice()
        {
            CarRepository c = new CarRepository();

            var result = c.GetCar_ByPrice();

            string expected_FirstCar = "SanteFe";
            string expected_LastCar = "CX-5";
            Assert.AreEqual(result.First().Model, expected_FirstCar);
            Assert.AreEqual(result.Last().Model, expected_LastCar);
        }
        [TestMethod]
        public void TestGetBestValueCar()
        {
            CarRepository c = new CarRepository();

            var result = c.GetBestValueCar();

            string expected_FirstCar = "Forester";
          
            Assert.AreEqual(result.First().Model, expected_FirstCar);        
        }
        [TestMethod]
        public void TestGetConsumptionByDistance()
        {
            CarRepository c = new CarRepository();
            var distance = 10000;
            Dictionary<string,float> result = c.GetConsumptionByDistance(distance);

            float expected_Consumption = 312.5f;
                
            Assert.AreEqual(result["Ford-Escape"], expected_Consumption);
        }
    }
}
