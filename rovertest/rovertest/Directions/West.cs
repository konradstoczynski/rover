

namespace rovertest
{
    public class West : IDirection
    {
        private readonly IGrid grid;

        public West(IGrid grid)
        {
            this.grid = grid;
        }

        public override string ToString()
        {
            return "West";
        }

        public void MoveForward()
        {
            this.grid.MoveBackwardOnXAxis();
        }

        public IDirection TurnLeft()
        {
            return new South(this.grid);
        }

        public IDirection TurnRight()
        {
            return new North(this.grid);
        }

    }
}