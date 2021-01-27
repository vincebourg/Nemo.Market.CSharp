using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nemo.Market.Kata.Classes;
using Nemo.Market.Kata.Enums;
using System;
using System.Drawing;

namespace Nemo.Market.Kata.Tests
{
    [TestClass]
    public class BuildingTests
    {
        [TestMethod]
        public void building_has_default_position_0_0()
        {
            Building building = new Building();
            Assert.AreEqual(0, building.Position.X);
            Assert.AreEqual(0, building.Position.Y);
        }

        [TestMethod]
        public void building_position_can_be_set()
        {
            Building building = new Building();
            building.SetPosition(new Point(1, 2));
            Assert.AreEqual(1, building.Position.X);
            Assert.AreEqual(2, building.Position.Y);
        }

        [TestMethod]
        public void building_consumption_can_be_set()
        {
            Building building = new Building();
            building.SetConsumption(20);
            Assert.AreEqual(building.Consumption, 20);
        }

        [TestMethod]
        public void building_consumption_cannot_be_more_than_20()
        {
            Building building = new Building();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => building.SetConsumption(21));
        }

        [TestMethod]
        public void building_consumption_cannot_be_less_than_1()
        {
            Building building = new Building();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => building.SetConsumption(0));
        }
    }
}
