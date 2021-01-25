using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nemo.Market.Kata.Classes;
using Nemo.Market.Kata.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nemo.Market.Kata.Tests
{
    [TestClass]
    public class PipeDiameterCalculatorTests
    {
        [TestMethod]
        public void given_1_returns_small()
        {
            PipeDiameterCalculator calculator = new PipeDiameterCalculator();
            var result = calculator.ProcessDiameter(1);
            Assert.AreEqual( PipeDiameter.Small, result);
        }

        [TestMethod]
        public void given_5_returns_small()
        {
            PipeDiameterCalculator calculator = new PipeDiameterCalculator();
            var result = calculator.ProcessDiameter( 5 );
            Assert.AreEqual( PipeDiameter.Small, result );
        }

        [TestMethod]
        public void given_6_returns_medium()
        {
            PipeDiameterCalculator calculator = new PipeDiameterCalculator();
            var result = calculator.ProcessDiameter( 6 );
            Assert.AreEqual( PipeDiameter.Medium, result );
        }

        [TestMethod]
        public void given_10_returns_medium()
        {
            PipeDiameterCalculator calculator = new PipeDiameterCalculator();
            var result = calculator.ProcessDiameter( 10 );
            Assert.AreEqual( PipeDiameter.Medium, result );
        }

        [TestMethod]
        public void given_11_returns_large()
        {
            PipeDiameterCalculator calculator = new PipeDiameterCalculator();
            var result = calculator.ProcessDiameter( 11 );
            Assert.AreEqual( PipeDiameter.Large, result );
        }

        [TestMethod]
        public void given_15_returns_large()
        {
            PipeDiameterCalculator calculator = new PipeDiameterCalculator();
            var result = calculator.ProcessDiameter( 15 );
            Assert.AreEqual( PipeDiameter.Large, result );
        }

        [TestMethod]
        public void given_16_returns_extra_large()
        {
            PipeDiameterCalculator calculator = new PipeDiameterCalculator();
            var result = calculator.ProcessDiameter( 16 );
            Assert.AreEqual( PipeDiameter.Large, result );
        }

        [TestMethod]
        public void given_20_returns_extra_large()
        {
            PipeDiameterCalculator calculator = new PipeDiameterCalculator();
            var result = calculator.ProcessDiameter( 20 );
            Assert.AreEqual( PipeDiameter.Large, result );
        }

        [TestMethod]
        public void given_0_or_less_returns_out_of_range_exception()
        {
            PipeDiameterCalculator calculator = new PipeDiameterCalculator();
            Assert.ThrowsException<ArgumentOutOfRangeException>( () => calculator.ProcessDiameter( 0 ) );
            Assert.ThrowsException<ArgumentOutOfRangeException>( () => calculator.ProcessDiameter( -999 ) );
        }

        [TestMethod]
        public void given_21_or_more_returns_out_of_range_exception()
        {
            PipeDiameterCalculator calculator = new PipeDiameterCalculator();
            Assert.ThrowsException<ArgumentOutOfRangeException>( () => calculator.ProcessDiameter( 21 ) );
            Assert.ThrowsException<ArgumentOutOfRangeException>( () => calculator.ProcessDiameter( 999 ) );
        }
    }
}
