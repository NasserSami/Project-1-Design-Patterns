using Assi1.Aggregates;

namespace Assi1.Iterators
{
    // HeavyObjectIterator.cs - Iterator for HeavyObjectList collection
    public class HeavyObjectIterator : IIterator
    {
        protected HeavyObjectList list;
        protected int index;

        // Initialize iterator with list and starting index
        public HeavyObjectIterator( HeavyObjectList list )
        {
            this.list = list;
            this.index = 0;
        }

        // Get previous element if exists
        public HeavyObject GetPrevious()
        {
            return index == 0 ? null : list.At(index - 1);
        }

        public bool IsDone()
        {
            return index >= list.Length();
        }

        public void Next()
        {
            index++;
        }

        public HeavyObject Current()
        {
            return list.At(index);
        }

        public HeavyObject First()
        {
            return list.At(0);
        }

    }
}
