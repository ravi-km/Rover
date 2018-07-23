using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheUltimateMARSRover.Contracts;

namespace RoverTests
{
    [TestClass]
    public class RoverTests
    {
        public static UltimateRover Rover = new UltimateRover();

        public static void InitRover()
        {
            Rover = new UltimateRover
            {
                CurrPosition = new Position { X = 1, Y = 1 },
                Landscape = new Position { X = 10, Y = 10 },
                Orientation = Orientation.N
            };
        }

        [TestMethod]
        public void RoverTurnLeft()
        {
            InitRover();
            Rover.TurnLeft(1);
            Assert.AreEqual(Orientation.W, Rover.Orientation);
        }

        [TestMethod]
        public void RoverTurnRight()
        {
            InitRover();
            Rover.TurnRight(1);
            Assert.AreEqual(Orientation.E, Rover.Orientation);
        }

        [TestMethod]
        public void RoverMoveOneStep()
        {
            InitRover();
            Rover.Move(1);
            Assert.AreEqual(2, Rover.CurrPosition.Y);
        }

        [TestMethod]
        public void RoverMoveTwoSteps()
        {
            InitRover();
            Rover.Move(2);
            Assert.AreEqual(3, Rover.CurrPosition.Y);
        }


        [TestMethod]
        public void RoverTurnLeftTwice()
        {
            InitRover();
            Rover.TurnLeft(2);
            Assert.AreEqual(Orientation.S, Rover.Orientation);
        }

        [TestMethod]
        public void RoverTurnRightTwice()
        {
            InitRover();
            Rover.TurnRight(2);
            Assert.AreEqual(Orientation.S, Rover.Orientation);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RoverOutOfBound()
        {
            InitRover();
            Rover.Move(20);
        }

    }
}
