using Assi1.Aggregates;

namespace Assi1.Strategies
{
    // BottomWeightStrategy.cs - Calculates weighted sum based on object position near bottom of stack
    public class BottomWeightStrategy : IStrategy
    {
        public float ExecuteStrategy( HeavyObjectList list )
        {

            // Initialize iterator, score and position counter
            var it = list.CreateIterator();
            float score = 0, pos = 1;

            // Calculate mass/position ratio for each object
            while (!it.IsDone())
            {
                score += it.Current().Mass / pos++;
                it.Next();
            }
            return score;
        }
    }
}
