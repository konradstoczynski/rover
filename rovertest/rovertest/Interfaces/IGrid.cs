namespace rovertest
{
    public interface IGrid
    {
        int PointX { get; }
        int PointY { get; }

        void MoveForwardOnXAxis();
        void MoveBackwardOnXAxis();

        void MoveForwardOnYAxis();
        void MoveBackwardOnYAxis();
    }
}