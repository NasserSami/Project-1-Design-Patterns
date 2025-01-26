using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi1.Strategies
{
    // ToppleStrategy.cs - Evaluates stack stability based on object areas
    public class ToppleStrategy : IStrategy
    {
        // Returns positive score for unstable stack, negative for stable
        public float ExecuteStrategy( HeavyObjectList heavyObjectsList )
        {
            float stack = 0.0f;
            IIterator iterator = heavyObjectsList.CreateIterator();

            // Get first object if it exists
            if (iterator.IsDone())
                return stack;

            HeavyObject previousObject = iterator.Current();
            iterator.Next();

            // Compare areas sequentially
            while (!iterator.IsDone())
            {
                HeavyObject currentObject = iterator.Current();
                double currentArea = currentObject.Width * currentObject.Length;
                double previousArea = previousObject.Width * previousObject.Length;

                stack += currentArea < previousArea ? -1.0f : 1.0f;

                previousObject = currentObject;
                iterator.Next();
            }

            return stack;
        }
    }
}
