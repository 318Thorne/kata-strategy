namespace strategy
{
    public interface IUnit
    {
        int Position { get; set; }
        void Move();
        IMoveBehaviour MoveBehaviour { get; set; }
    }
}