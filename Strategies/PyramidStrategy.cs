using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi1.Strategies
{
    // PyramidStrategy.cs - Evaluates if objects form pyramid shape
    public class PyramidStrategy : IStrategy
    {
        // Returns positive score for pyramid shape (decreasing area), negative for inverse
        public float ExecuteStrategy( HeavyObjectList heavyObjectsList )
        {
            // easier adjacent element comparison
            var objects = new List<HeavyObject>();
            var iterator = heavyObjectsList.CreateIterator();

            // Collect all objects
            while (!iterator.IsDone())
            {
                objects.Add(iterator.Current());
                iterator.Next();
            }

            if (objects.Count <= 1)
                return 0.0f;

            float stack = 0.0f;

            // Compare adjacent elements' areas
            for (int i = 1; i < objects.Count; i++)
            {
                double currentArea = objects[i].Width * objects[i].Length;
                double previousArea = objects[i - 1].Width * objects[i - 1].Length;

                stack += currentArea < previousArea ? 1.0f : -1.0f;
            }

            return stack;
        }
    }
}
