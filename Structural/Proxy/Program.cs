﻿using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Request();

            Console.ReadKey();
        }
    }

    abstract class Subject
    {
        public abstract void Request();
    }

    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Call RealSubject.Request()");
        }
    }

    class Proxy : Subject
    {
        private RealSubject _realSubject;

        public override void Request()
        {
            if (_realSubject == null)   // lazy init
            {
                _realSubject = new RealSubject();
            }

            _realSubject.Request();

        }
    }
}
