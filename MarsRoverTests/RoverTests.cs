using System;
using System.Collections.Generic;
using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTests
{
    [TestClass]
    public class RoverTests
    {
        Rover newRover = new Rover(98382);
        /*Command[] commands = { new Command("MODE_CHANGE", "LOW_POWER"), new Command("Move", 5000) };
        Message newMessage = new Message ("Test Message", commands);*/

        [TestMethod]

        public void ConstructorSetsDefaultPosition()
        {
            Assert.AreEqual(newRover.Position, 98382);
        }

        [TestMethod]
        public void ConstructorSetsDefaultMode()
        {
            Assert.AreEqual(newRover.Mode, "NORMAL");
        }

        [TestMethod]
        public void ConstructorSetsDefaultGeneratorWatts()
        {
            Assert.AreEqual(newRover.GeneratorWatts, 110);
        }

        [TestMethod]
        public void RespondsCorrectlyToModeChangeCommand()
        {
            Rover newRover1 = new Rover(98382);
            Command[] commands1 = new Command[]{ new Command("MODE_CHANGE", "LOW_POWER")};
            Message newMessage1 = new Message("Test Message", commands1);

            newRover1.ReceiveMessage(newMessage1);

            Assert.AreEqual(newRover1.Mode, "LOW_POWER");
        }

        [TestMethod]
        public void DoesNoteMoveInLowPower()
        {
            Rover newRover1 = new Rover(98382);
            Command[] commands1 = new Command[] { new Command("MODE_CHANGE", "LOW_POWER"), new Command("MOVE", 5000)};
            Message newMessage1 = new Message("Test Message", commands1);

            newRover1.ReceiveMessage(newMessage1);

            Assert.AreEqual(newRover1.Position, 98382);
        }

    }
}
