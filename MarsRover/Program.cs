using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Rover myRover = new Rover(98382);
            Command[] commands1 = new Command[] { new Command("MODE_CHANGE", "LOW_POWER") };
            Message newMessage1 = new Message("Test Message", commands1);
            myRover.ReceiveMessage(newMessage1);
            Console.WriteLine(myRover.ToString());


        }
    }
}
