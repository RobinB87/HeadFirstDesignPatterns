using System;
using Exercises.Patterns.StrategyPattern.Interfaces;

namespace Exercises.Patterns.StrategyPattern.Models
{
    public abstract class Duck
    {
        public IFlyBehaviour FlyBehaviour;
        public IQuackBehaviour QuackBehaviour;

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            QuackBehaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
