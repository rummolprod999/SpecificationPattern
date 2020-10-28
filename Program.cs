using System;

namespace SpetificationPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISpecification spetification =
                new ExampleSpecification1()
                    .Or(new ExampleSpecification1()
                        .And(new ExampleSpecification2()));
            
            if (spetification.IsSatisfiedBy(new Object()))
            {
                Console.WriteLine("specification success");
            }
        }
    }
}