using System;
 
namespace TemplateMethod
{
  class MainApp
  {

    static void Main()
    {
      AbstractClass a = new ConcreteClassA();
      a.TemplateMethod();
 
      AbstractClass b = new ConcreteClassB();
      b.TemplateMethod();
      
      Console.ReadKey();
    }
  }
 
  abstract class AbstractClass
  {
    public abstract void PrimitiveOperation1();
    public abstract void PrimitiveOperation2();
 
    public void TemplateMethod()
    {
      PrimitiveOperation1();
      PrimitiveOperation2();
    }
  }
 
  class ConcreteClassA : AbstractClass
  {
    public override void PrimitiveOperation1()
    {
      Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
    }
    public override void PrimitiveOperation2()
    {
      Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
    }
  }
 
  class ConcreteClassB : AbstractClass
  {
    public override void PrimitiveOperation1()
    {
      Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
    }
    public override void PrimitiveOperation2()
    {
      Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
    }
  }
}