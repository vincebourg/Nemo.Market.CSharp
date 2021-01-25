using Nemo.Market.Kata.Classes;
using System;
using System.Collections.Generic;

namespace Nemo.Market.Kata.Tests
{
    public class Project
    {
        public int Consumption { get; internal set; }

        public IEnumerable<Pipe> GetPipes()
        {
            throw new NotImplementedException();
        }

        public void Add( object thisObject)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Building> GetBuildings()
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<PowerPlant> GetPlants()
        {
            throw new NotImplementedException();
        }
    }
}