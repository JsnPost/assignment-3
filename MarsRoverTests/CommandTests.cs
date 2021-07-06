using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;
using System;

namespace MarsRoverTests
{
    [TestClass]
    public class CommandTests
    {

        [TestMethod]
        public void ArgumentNullExceptionThrownIfCommandTypeIsNullOrEmpty()
        {
            try
            {
                new Command("");
            }
            catch (ArgumentNullException ex)
            {
                // replace command type... by oops
                Assert.AreEqual("Command type required.", ex.Message);
            }
        }

        [TestMethod]
        public void ConstructorSetsCommandType()
        {
            //test passes if line 29 and 30 contain same command string
            Command newCommand = new Command("MOVE", 0);
            Assert.AreEqual(newCommand.CommandType, "MOVE");
        }

        [TestMethod]
        public void ConstructorSetsInitialNewPositionValue()
        {
            Command newCommand = new Command("MOVE", 20);
            Assert.AreEqual(newCommand.NewPosition, 20);
        }

        [TestMethod]
        
        public void ConstructorSetsInitialNewModeValue()
        {
            Command newCommand = new Command("Mode", "Sleep");
            Assert.AreEqual(newCommand.NewMode, "Sleep");
        }

    }
}
