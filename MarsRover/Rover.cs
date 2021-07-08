using System;
namespace MarsRover
{
    public class Rover
    {
        public string Mode { get; set; }
        public int Position { get; set; }
        public int GeneratorWatts { get; set; }

        public Rover(int position)
        {
            this.Position = position;
            this.Mode = "NORMAL";
            this.GeneratorWatts = 110;
        }

        public override string ToString()
        {
            return "Position: " + Position + " - Mode: " + Mode + " - GeneratorWatts: " + GeneratorWatts; 
        }

        public void ReceiveMessage(Message message)
        {
            foreach(Command order in message.Commands)
            {
                if (order.CommandType == "MOVE")
                {
                    if (this.Mode == "LOW_POWER")
                    {
                        Console.WriteLine("Cannot move in LOW_POWER mode");
                        break;
                    }
                    this.Position = order.NewPosition;
                    
                }

                if (order.CommandType == "MODE_CHANGE")
                {
                    if(order.NewMode == "NORMAL")
                    {
                        this.Mode = order.NewMode;
                    }
                    else if (order.NewMode == "LOW_POWER")
                    {
                        this.Mode = order.NewMode;

                    }


                }
            }            
        }

    }
}
