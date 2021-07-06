using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;

namespace MarsRoverTests
{
    [TestClass]
    public class MessageTests
    {
        Command[] commands = { new Command("foo", 0), new Command("bar", 20) };

        Message testName = new Message("Test Message");

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

        [TestMethod]
        public void ConstructorSetsName()
        {
          Assert.AreEqual(testName.Name, "Test Message");
        }


        //verify that the commads array is properly filled

        [TestMethod]
        public void ConstructorSetsCommandsField()
        {

        }

    }
}
