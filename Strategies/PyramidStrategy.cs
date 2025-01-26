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
        public float ExecuteStrategy( HeavyObjectList list )
        {
            // Initialize iterator and score
            var it = list.CreateIterator();
            float score = 0;

            // Compare each object's area to previous
            while (!it.IsDone())
            {
                var prev = it.GetPrevious();
                if (prev != null)
                    // Increment score if current area < previous (pyramid shape)
                    score += it.Current().Width * it.Current().Length < prev.Width * prev.Length ? 1 : -1;
                it.Next();
            }
            return score;
        }
    }
}
