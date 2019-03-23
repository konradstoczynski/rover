namespace rovertest
{
    public interface IDirection
    {
        void MoveForward();
        IDirection TurnLeft();
        IDirection TurnRight();
    }
}