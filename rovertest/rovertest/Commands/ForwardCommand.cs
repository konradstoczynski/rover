using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace rovertest
{
    public class MoveForwardCommand : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.MoveForward();
        }
    }
}
