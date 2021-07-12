using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExample
{
    class ConcreteDecoratorA : Decorator
    {
        public override void CheckOperationNum(int currentOperationNum, int maxCallNum)
        {
            if (currentOperationNum == maxCallNum)
                throw new Exception("Exception: The maximum number of function calls has been exceeded.");

        }

        public override void RunTheOperation()
        {
            for (int i = 0; i <= numOfCalls; i++)
            {
                try
                {
                    CheckOperationNum(i, base.maxCalls);
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
                Operation(i + 1);
            }
        }
    }
}
