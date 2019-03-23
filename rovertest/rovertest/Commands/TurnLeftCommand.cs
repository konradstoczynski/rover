using System;


namespace rovertest
{
    public class TurnLeftCommand : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.TurnLeft();
        }
    }
}