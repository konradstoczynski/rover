
namespace rovertest
{
    public class South : IDirection
    {
        private readonly IGrid grid;

        public South(IGrid grid)
        {
            this.grid = grid;
        }

        public override string ToString()
        {
            return "South";
        }

        public void MoveForward()
        {
            this.grid.MoveForwardOnYAxis();
        }

        public IDirection TurnLeft()
        {
            return new East(this.grid);
        }

        public IDirection TurnRight()
        {
            return new West(this.grid);
        }
    }
}