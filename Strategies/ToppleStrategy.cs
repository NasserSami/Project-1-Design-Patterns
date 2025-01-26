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
        public float ExecuteStrategy( HeavyObjectList list )
        {
            // Initialize iterator and score
            var it = list.CreateIterator();
            float score = 0;

            // Compare each object's volume*mass to previous
            while (!it.IsDone())
            {
                var prev = it.GetPrevious();
                if (prev != null)
                    // Increment score if current < previous (less stable)
                    score += it.Current().Width * it.Current().Length * it.Current().Mass <
                            prev.Width * prev.Length * prev.Mass ? 1 : -1;
                it.Next();
            }
            return score;
        }
    }
}
