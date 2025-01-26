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
        private Dictionary<string, IStrategy> Strategies;

        public FlyweightFactory()
        {
            Strategies = new Dictionary<string, IStrategy>();
        }

        // Returns existing strategy or creates new one
        public IStrategy GetFlyweight( string key, IStrategy defaultStrategy )
        {
            if (Strategies.ContainsKey(key))
                return Strategies[key];

            Strategies.Add(key, defaultStrategy);
            return defaultStrategy;
        }
    }
}
