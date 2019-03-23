using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rovertest
{
    class Program
    {
        static void Main(string[] args)
        {
     
            string command = string.Empty;
            string userInputSize = "";
            int size;

            while ((!Int32.TryParse(userInputSize, out size)) || size == 0)
            {
                SetGridSize(ref userInputSize);
            }

            Grid grid = new Grid(size);
            Rover rover = new Rover(grid);

            DisplayAvailableCommands();

            while (command != "E")
            {
                Console.Write("Enter Commands: ");
                command = Console.ReadLine().ToUpper();
                rover.ExecuteCommands(command);
                Console.WriteLine(string.Format("Current position: {0}", rover.ToString()));
            }
        }

        private static void DisplayAvailableCommands()
        {
            Console.WriteLine("Press F to go forward");
            Console.WriteLine("Press R to turn right");
            Console.WriteLine("Press L to turn left");
        }

        private static void SetGridSize(ref string userInputSize)
        {
            Console.Write("Please enter grid size");
            Console.WriteLine();
            userInputSize = Console.ReadLine();
        }
    }
}
