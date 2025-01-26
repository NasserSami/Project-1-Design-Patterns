using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Strategies
{
    // IStrategy.cs - Strategy interface for heavy object list calculations
    public interface IStrategy
    {
        // Executes calculation strategy on provided heavy object list
        float ExecuteStrategy( HeavyObjectList heavyObjectsList );
    }
}
