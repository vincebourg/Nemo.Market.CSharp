using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nemo.Market.Kata.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Nemo.Market.Kata.Tests
{
    [TestClass]
    public class PlantTests
    {
        [TestMethod]
        public void power_plant_has_default_position_0_0()
        {
            PowerPlant plant = new PowerPlant();
            Assert.AreEqual( 0, plant.Position.X );
            Assert.AreEqual( 0, plant.Position.Y );
        }

        [TestMethod]
        public void power_plant_position_can_be_set()
        {
            PowerPlant plant = new PowerPlant();
            var position = new Point( 1, 2 );
            plant.SetPosition( position );
            Assert.AreEqual( 1, plant.Position.X );
            Assert.AreEqual( 2, plant.Position.Y );
        }
    }
}
