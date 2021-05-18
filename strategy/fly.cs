namespace strategy
{
    public class Fly : IMoveBehaviour
    {
        public void Move(IUnit unit)
        {
            unit.Position += 10;
        }
    }
}