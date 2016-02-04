using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client();

            c.RunCommand();

            Console.ReadKey();
        }

        public class Client
        {
            public void RunCommand()
            {
                Invoker invoker = new Invoker();
                Receiver receiver = new Receiver();
                ConcreteCommand command = new ConcreteCommand(receiver);
                command.Parameter = "Helloworld !!";
                invoker.Command = command;
                invoker.ExecuteCommand();
            }
        }

        public class Receiver
        {
            public void Action(string message)
            {
                Console.WriteLine("Action called with message: {0}", message);
            }
        }

        public class Invoker
        {
            public ICommand Command { get; set; }

            public void ExecuteCommand()
            {
                Command.Execute();
            }
        }

        public interface ICommand
        {
            void Execute();
        }

        public class ConcreteCommand : ICommand
        {
            protected Receiver _receiver;
            public string Parameter { get; set; }

            public ConcreteCommand(Receiver receiver)
            {
                _receiver = receiver;
            }

            public void Execute()
            {
                _receiver.Action(Parameter);
            }
        }
    }
}
