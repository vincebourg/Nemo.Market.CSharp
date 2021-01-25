using Nemo.Market.Kata.Enums;
using System;
using System.Drawing;

namespace Nemo.Market.Kata.Classes
{
    public class Pipe
    {
        public Pipe()
        {
        }

        private Point _position;

        public Point Position => _position;
        public int Diameter { get; private set; }

        internal void SetPosition( Point point )
        {
            throw new NotImplementedException();
        }

        internal void SetDiameter( PipeDiameter large )
        {
            throw new NotImplementedException();
        }
    }
}