using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExample
{
    public class ConcreteComponent : Component
    {


        public ConcreteComponent(string[] args)
        {

            if (args.Length >= 2)
            {
                this.maxCalls = Int32.TryParse(args[0].ToString(), out this.maxCalls) ? this.maxCalls : 0;
                this.numOfCalls = Int32.TryParse(args[1].ToString(), out this.numOfCalls) ? this.numOfCalls : 0;
            }
        }

        public override void Operation(int callNum)
        {
            Console.WriteLine("Run operation: " + callNum);
        }

        public override void RunTheOperation()
        {
            for (int i = 0; i <= numOfCalls; i++)
            {
                Operation(i + 1);
            }
        }
    }
}
