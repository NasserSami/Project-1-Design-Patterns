using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi1.Aggregates
{
    // Interface for collections that support iteration
    public interface IAggregate
    {
        // Creates and returns iterator for traversing collection
        IIterator CreateIterator();
    }
}
