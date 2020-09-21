using System;
using Exercises.Patterns.StrategyPattern.Interfaces;

namespace Exercises.Patterns.StrategyPattern.Models
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehaviour = new FlyWithWings();
            QuackBehaviour = new NormalQuack(); 
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck!");
        }
    }
}
