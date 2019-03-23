using System;


namespace rovertest
{
    public class TurnRightCommand : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.TurnRight();
        }
    }
}