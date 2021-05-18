namespace strategy
{
    public class Viking : IUnit
    {
        public Viking()
        {
            MoveBehaviour = new Walk();
        }

        public int Position { get; set; }
        public IMoveBehaviour MoveBehaviour { get; set; }

        public void Move()
        {
            MoveBehaviour.Move(this);
        }
    }
}