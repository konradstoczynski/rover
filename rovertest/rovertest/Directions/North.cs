

namespace rovertest
{
    public class North : IDirection
    {
        private readonly IGrid grid;

        public override string ToString()
        {
            return "North";
        }

        public void MoveForward()
        {
            this.grid.MoveForwardOnYAxis();
        }

        public North(IGrid grid)
        {
            this.grid = grid;
        }

        public IDirection TurnLeft()
        {
            return new West(this.grid);
        }

        public IDirection TurnRight()
        {
            return new East(this.grid);
        }
    }
}
