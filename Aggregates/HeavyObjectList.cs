using Assi1.Iterators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi1.Aggregates
{
    // HeavyObjectList.cs - Collection of HeavyObjects with iterator support

    public class HeavyObjectList : IAggregate
    {
        private List<HeavyObject> heavyObjectList;

        public HeavyObjectList()
        {
            heavyObjectList = new List<HeavyObject>();
        }

        public IIterator CreateIterator()
        {
            return new HeavyObjectIterator(this);
        }

        public void Add( HeavyObject heavyObject )
        {
            heavyObjectList.Add(heavyObject);
        }

        public int Length()
        {
            return heavyObjectList.Count;
        }

        public HeavyObject At( int position )
        {
            return heavyObjectList[position];
        }

        public void Print()
        {
            foreach (HeavyObject heavyObject in heavyObjectList)
                heavyObject.Print();
        }
    }
}
