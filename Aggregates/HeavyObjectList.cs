using Assi1.Iterators;
using System.Collections.Generic;

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
