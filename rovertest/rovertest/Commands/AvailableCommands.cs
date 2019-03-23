
using System.Collections.Generic;

namespace rovertest
{
    public static class AvailableCommands
    {
        public static Dictionary<string, ICommand> List
        {
            get
            {
                Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();

                commands.Add("F", new MoveForwardCommand());
                commands.Add("R", new TurnRightCommand());
                commands.Add("L", new TurnLeftCommand());

                return commands;
            }
        }
    }
}