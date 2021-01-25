using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nemo.Market.Kata.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Nemo.Market.Kata.Tests
{
    [TestClass]
    public class ProjectTests
    {
        [TestMethod]
        public void project_can_accept_pipes()
        {
            Project project = new Project();
            var pipe = new Pipe();
            project.Add( pipe );
            var pipes = project.GetPipes();
            Assert.AreEqual(1, pipes.Count());
            Assert.AreSame(pipe, pipes.First());
        }

        [TestMethod]
        public void project_can_accept_buildings()
        {
            Project project = new Project();
            var building = new Building();
            project.Add( building );
            var buildings = project.GetBuildings();
            Assert.AreEqual( 1, buildings.Count() );
            Assert.AreSame( building, buildings.First() );
        }

        [TestMethod]
        public void project_can_accept_power_plants()
        {
            Project project = new Project();
            var plant = new PowerPlant();
            project.Add( plant );
            var plants = project.GetPlants();
            Assert.AreEqual( 1, plants.Count() );
            Assert.AreSame( plant, plants.First() );
        }

        [TestMethod]
        public void project_consumption_is_the_sum_of_all_buildings_consumption()
        {
            Project project = new Project();

            var building1 = new Building();
            building1.SetConsumption( 1 );

            var building2 = new Building();
            building2.SetPosition( new Point( 1, 1 ) );
            building2.SetConsumption( 2 );

            var building3 = new Building();
            building3.SetPosition( new Point( 2, 2 ) );
            building3.SetConsumption( 3 );

            project.Add( building1 );
            project.Add( building2 );
            project.Add( building3 );

            var allBuildingsConsumption = building1.Consumption + building2.Consumption + building3.Consumption;

            Assert.AreEqual( project.Consumption, allBuildingsConsumption );
        }

        [TestMethod]
        public void project_cannot_accept_objects_at_same_position()
        {
            Project project = new Project();

            var building1 = new Building();
            var building2 = new Building();

            project.Add( building1 );
            Assert.ThrowsException<ArgumentException>( () => project.Add( building2));
        }


    }

}
