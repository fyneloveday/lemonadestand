using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace lemonadestandtesting.UnitTests
{
    [TestClass]
    public class lemonademixtest
    {
        [TestMethod]
        public void getTemperature()
        {
            // Arrange            
            Weather weather = new Weather();
            int firstValue = 40;
            int secondValue = 100;

            // Act
            weather.getTemperature();

            // Assert
            Assert.IsTrue(weather.temperature >= 40 && weather.temperature <= 100);
        }


        [TestMethod]
        public void buySugar_CheckIfItemCountIncreases()
        {
            // Arrange
            Sugar sugar = new Sugar();
            Player player = new Player();
            Store store = new Store();
            Inventory inventory = new Inventory();
            int sugarAmount = 3;
            int expected = 3;
            int actual = inventory.sugarList.Count;
            

            // Act
            player.BuySugar(store);

            //Assert
            Assert.AreEqual(expected, actual);            
        }


        [TestMethod]
        public void 

    }


}
