using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;

namespace MarsRoverTests
{
    [TestClass]
    public class MessageTests
    {
        Command[] commands = { new Command("foo", 0), new Command("bar", 20) };
                    

        [TestMethod]
        public void ArgumentNullExceptionThrownIfNameNotPassedToConstructor()
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

        // verify that the message constructor properly populates the string Name

/*        [TestMethod]
        public void ConstructorSetsName()
        {
            Message testName = new Message("Test Message");
            Assert.AreEqual(testName.Name, "Test Message");
        }*/


        //verify that the name and commads array is set

        [TestMethod]
        public void ConstructorSetsCommandsField()
        {
            Message newTest = new Message("Test Message", commands);
            Assert.AreEqual(newTest.Name, "Test Message");
        }

    }
}
