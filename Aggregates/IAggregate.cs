namespace Assi1.Aggregates
{
    // Interface for collections that support iteration
    public interface IAggregate
    {
        // Creates and returns iterator for traversing collection
        IIterator CreateIterator();
    }
}
