using System;

namespace OOP5
{
    class Program
    {
        interface ISpoon
        {
            void Size();
        }
        class Spoon
        {
            ISpoon spoon;
            public Spoon(ISpoon loz)
            {
                spoon = loz ;
            }
            public void Start()
            {
                spoon.Size();
            }
        }
        class Small : ISpoon
        {
            public void Size()
            {
                Console.WriteLine("This spoon is big");
            }
        }
        class Big : ISpoon
        {
            public void Size()
            {
                Console.WriteLine("This spoon is small");
            }
        }

        interface IFork
        {
            void Type();
        }
        class Fork
        {
            IFork fork;
            public Fork(IFork vil)
            {
                fork = vil;
            }
            public void Start()
            {
                fork.Type();
            }
        }
        class Cheap : IFork
        {
            public void Type()
            {
                Console.WriteLine("This fork is steel");
            }
        }
        class Exp : IFork
        {
            public void Type()
            {
                Console.WriteLine("This fork is silver");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Interface ISpoon:");
            Spoon small = new Spoon(new Small());
            Spoon big = new Spoon(new Big());
            small.Start();
            big.Start();
            Console.WriteLine();
            Console.WriteLine("Interface IFork:");
            Fork ch = new Fork(new Cheap());
            Fork ex = new Fork(new Exp());
            ch.Start();
            ex.Start();
            Console.ReadKey();
        }
    }
}
