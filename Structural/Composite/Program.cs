using System;
using System.Collections.Generic;

namespace Composite
{

    class MainApp
    {

        static void Main()
        {           
            Composite system = new Composite("System");
            system.Add(new Leaf("System.Element 1"));
            system.Add(new Leaf("System.Element 2"));

            Composite subsystem1 = new Composite("System.Subsystem1");
            subsystem1.Add(new Leaf("System.Subsystem1.Element1"));
            subsystem1.Add(new Leaf("System.Subsystem1.Element2"));

            system.Add(subsystem1);
            system.Add(new Leaf("System.Element 3"));

            Leaf leaf = new Leaf("System.Element 4");
            system.Add(leaf);
            system.Remove(leaf);

            system.Display(1);
            
            Console.ReadKey();
        }
    }

    abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
    
    class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        public Composite(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Component component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }

    class Leaf : Component
    {
        public Leaf(string name) 
            : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}