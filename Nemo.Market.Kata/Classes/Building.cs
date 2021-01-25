using Nemo.Market.Kata.Enums;
using System;
using System.Drawing;

namespace Nemo.Market.Kata.Classes
{
    public class Building
    {
        public Building()
        {
        }

        public Point Position { get; private set; }
        public int Consumption { get; set; }

        internal void SetPosition( Point point )
        {
            throw new NotImplementedException();
        }

        internal void SetUsage( BuildingUsage usage )
        {
            throw new NotImplementedException();
        }

        internal void SetConsumption( int consumption )
        {
            throw new NotImplementedException();
        }
    }
}