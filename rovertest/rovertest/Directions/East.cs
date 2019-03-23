
namespace rovertest
{
    public class East : IDirection
    {
        private readonly IGrid grid;

        public East(IGrid grid)
        {
            this.grid = grid;
        }

        public override string ToString()
        {
            return "East";
        }

        public void MoveForward()
        {
            this.grid.MoveForwardOnXAxis();
        }

        public IDirection TurnLeft()
        {
            return new North(this.grid);
        }

        public IDirection TurnRight()
        {
            return new South(this.grid);
        }
    }
}