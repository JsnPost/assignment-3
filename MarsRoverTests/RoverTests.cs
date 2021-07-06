using System;
using System.Collections.Generic;
using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTests
{
    [TestClass]
    public class RoverTests
    {
        Command[] commands = { new Command("Move", 5000) };
        

        [TestMethod]

        public void ConstructorSetsDefaultPosition()
        {

            Message newMessage = new Message("Test message", commands);
            Rover testRover = new Rover(98382);

            Assert.AreEqual(testRover.Position, 5000);
        }
    }
}
