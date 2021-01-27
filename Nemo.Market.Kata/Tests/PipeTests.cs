using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nemo.Market.Kata.Classes;
using Nemo.Market.Kata.Enums;
using System.Drawing;

namespace Nemo.Market.Kata.Tests
{
    [TestClass]
    public class PipeTests
    {
        [TestMethod]
        public void pipe_has_default_position_0_0()
        {
            Pipe pipe = new Pipe();
            Assert.AreEqual( 0, pipe.Position.X );
            Assert.AreEqual( 0, pipe.Position.Y );
        }

        [TestMethod]
        public void pipe_position_can_be_set()
        {
            Pipe pipe = new Pipe();
            var point = new Point( 1, 2 );
            pipe.SetPosition(point);
            Assert.AreEqual( 1, pipe.Position.X );
            Assert.AreEqual( 2, pipe.Position.Y );
        }

        [TestMethod]
        public void pipe_diameter_can_be_set()
        {
            Pipe pipe = new Pipe();
            pipe.SetDiameter( PipeDiameter.Large );
            Assert.AreEqual((int)PipeDiameter.Large, pipe.Diameter);
        }
    }
}
