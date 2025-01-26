using Assi1.Aggregates;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi1.Strategies
{
    // BottomWeightStrategy.cs - Calculates weighted sum based on object position near bottom of stack
    public class BottomWeightStrategy : IStrategy
    {
        // Calculates sum where each object's mass is divided by its position from bottom
        public float ExecuteStrategy( HeavyObjectList heavyObjectsList )
        {
            var iterator = heavyObjectsList.CreateIterator();
            var objects = new List<float>();

            // First collect all masses
            while (!iterator.IsDone())
            {
                objects.Add(iterator.Current().Mass);
                iterator.Next();
            }

            // Then calculate the weighted sum of the stack
            float stack = 0f;
            for (int i = 0; i < objects.Count; i++)
            {
                stack += objects[i] / (i + 1);
            }

            return stack;
        }
    }
}
