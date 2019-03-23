using System;


namespace rovertest
{
    public class NotFoundCommand : ICommand
    {
        public void Execute(IRover rover)
        {
            Console.WriteLine();
            Console.Write("Ivalid command");
            Console.WriteLine();
        }
    }
}