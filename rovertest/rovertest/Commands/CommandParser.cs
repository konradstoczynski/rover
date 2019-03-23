using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace rovertest
{
    public class CommandParser
    {
        private readonly Dictionary<string, ICommand> commands;

        public CommandParser(Dictionary<string, ICommand> commands)
        {
            this.commands = commands;
        }

        public ICommand ParseCommand(string command)
        {
            if (this.commands.ContainsKey(command))
            {
                return this.commands[command];
            }

            return new NotFoundCommand();
        }
    }
}
