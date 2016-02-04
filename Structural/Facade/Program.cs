using System;

namespace Facade
{    
    class MainApp
    {
        public static void Main()
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();

            Console.ReadKey();
        }
    }

    class Subsystem_1
    {
        public void MethodOne()
        {
            Console.WriteLine(" Subsystem_1 Method");
        }
    }

    class Subsystem_2
    {
        public void MethodTwo()
        {
            Console.WriteLine(" Subsystem_2 Method");
        }
    }

    class Subsystem_3
    {
        public void MethodThree()
        {
            Console.WriteLine(" Subsystem_3 Method");
        }
    }

    class Subsystem_4
    {
        public void MethodFour()
        {
            Console.WriteLine(" Subsystem_4 Method");
        }
    }

    class Facade
    {
        private Subsystem_1 _one;
        private Subsystem_2 _two;
        private Subsystem_3 _three;
        private Subsystem_4 _four;

        public Facade()
        {
            _one = new Subsystem_1();
            _two = new Subsystem_2();
            _three = new Subsystem_3();
            _four = new Subsystem_4();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ---- ");
            _one.MethodOne();
            _two.MethodTwo();
            _four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---- ");
            _two.MethodTwo();
            _three.MethodThree();
        }
    }
}