using Exercises.Patterns.StrategyPattern.Models;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();
        }
    }
}
