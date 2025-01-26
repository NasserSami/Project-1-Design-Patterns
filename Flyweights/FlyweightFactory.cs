using Assi1.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi1.Flyweights
{
    // FlyweightFactory.cs - Creates and manages strategy flyweights
    public class FlyweightFactory
    {
        // Available strategy types
        public enum StrategyType { Pyramid, Topple, BottomWeight }

        // Strategy cache
        private Dictionary<StrategyType, IStrategy> strategies;

        public FlyweightFactory()
        {
            strategies = new Dictionary<StrategyType, IStrategy>();
        }

        // Gets existing strategy or adds new one if provided
        public IStrategy GetFlyweight( StrategyType type, IStrategy newStrategy = null )
        {
            // Add new strategy if provided and doesn't exist
            if (!strategies.ContainsKey(type) && newStrategy != null)
                strategies[type] = newStrategy;

            // Return existing or throw if not found
            return strategies.ContainsKey(type)
                ? strategies[type]
                : throw new ArgumentException($"Strategy {type} not found");
        }
    }
}
