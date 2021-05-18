using System;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var viking = new Viking();
            viking.Move();
            Console.WriteLine("Viking Position: " + viking.Position);
            viking.MoveBehaviour = new Fly();
            viking.Move();
            Console.WriteLine("Viking Position: " + viking.Position);
        }
    }
}
