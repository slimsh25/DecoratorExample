using System;

namespace DecoratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent component = new ConcreteComponent(args);
            ConcreteDecoratorA decorator = new ConcreteDecoratorA();
            decorator.SetComponent(component);
            decorator.RunTheOperation();

        }
    }
}
