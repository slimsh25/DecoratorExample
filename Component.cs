using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExample
{
    public abstract class Component
    {
        public int maxCalls = 0;
        public int numOfCalls = 0;
        /// <summary>
        /// The main operation
        /// </summary>
        /// <param name="callNum"> The current call number </param>
        public abstract void Operation(int callNum);

        /// <summary>
        /// Run the cycle. 
        /// </summary>
        public abstract void RunTheOperation();
    }
}
