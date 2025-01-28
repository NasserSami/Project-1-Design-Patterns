namespace Assi1
{
    // Interface for traversing a collection of HeavyObjects
    public interface IIterator
    {
        // Returns first element in collection
        HeavyObject First();

        // Returns current element at iterator position
        HeavyObject Current();

        // Returns previous element if available
        HeavyObject GetPrevious();

        // Advances iterator to next element
        void Next();

        // Checks if iteration is complete
        bool IsDone();
    }
}
