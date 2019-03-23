using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rovertest
{
    class Rover : IRover
    {

        private readonly IGrid grid;

        public IDirection Direction { get; set; }

        public Rover(IGrid grid)
        {
            this.grid = grid;
            Direction = new North(this.grid);
        }
        public void MoveForward()
        {
            Direction.MoveForward();
        }
     
        public void TurnLeft()
        {
            Direction = Direction.TurnLeft();
        }

        public void TurnRight()
        {
            Direction = Direction.TurnRight();
        }


        public int PointX
        {
            get { return this.grid.PointX; }
        }

        public int PointY
        {
            get { return this.grid.PointY; }
        }

        public override string ToString()
        {
            return string.Format("X : {0}, Y : {1}, Heading : {2}", PointX, PointY, Direction);
        }


        public void ExecuteCommands(string commandString)
        {
            var commands = AvailableCommands.List;
            var commandParser = new CommandParser(commands);

            for (int index = 0; index < commandString.Length; index++)
            {
                var command = commandString[index].ToString();
                var commandToExecute = commandParser.ParseCommand(command);
                commandToExecute.Execute(this);
            }
        }
    }
}
