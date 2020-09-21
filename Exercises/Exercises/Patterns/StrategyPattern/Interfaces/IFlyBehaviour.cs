using System;

namespace Exercises.Patterns.StrategyPattern.Interfaces
{
    public interface IFlyBehaviour
    {
        void Fly();
    }

    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }

    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!!");
        }
    }
}
