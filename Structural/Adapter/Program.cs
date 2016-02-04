using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();
            
            Console.ReadKey();
        }
    }

    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request");
        }    
    }

    class Adapter : Target
    {
        Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            // Do some work,
            // then : 
            adaptee.SpecificRequest();
        }
    }

    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called Specific Request");
        }
    }
}
