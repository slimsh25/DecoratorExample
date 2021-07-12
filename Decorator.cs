using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExample
{
    public abstract class Decorator : Component
    {
        protected Component component;

        /// <summary>
        /// Set the component that we going to add functionality to it.
        /// </summary>
        /// <param name="component"></param>
        public void SetComponent(Component component)
        {
            this.component = component;
            this.maxCalls = component.maxCalls;
            this.numOfCalls = component.numOfCalls;
        }

        public override void RunTheOperation()
        {
            component.RunTheOperation();
        }

        public override void Operation(int callNum)
        {
            if (component != null)
                component.Operation(callNum);
        }

        /// <summary>
        /// Added functionality 
        /// </summary>
        /// <param name="currentOperationNum">Get from outsource resource </param>
        /// <param name="maxCallNum">Get from outsource resource </param>
        public abstract void CheckOperationNum(int currentOperationNum, int maxCallNum);


    }
}
