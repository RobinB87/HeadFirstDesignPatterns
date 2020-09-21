using System;

namespace Exercises.Patterns.StrategyPattern.Interfaces
{
    public interface IQuackBehaviour
    {
        void Quack();
    }

    public class NormalQuack : IQuackBehaviour
    {
        public new void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }

    public class MuteQuack : IQuackBehaviour
    {
        public new void Quack()
        {
            Console.WriteLine("Silence...");
        }
    }

    public class Squeak : IQuackBehaviour
    {
        public new void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
