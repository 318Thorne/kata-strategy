namespace strategy
{
    public class Walk : IMoveBehaviour
    {
        public void Move(IUnit unit)
        {
            unit.Position += 1;
        }
    }
}