using Assi1.Aggregates;
using Assi1.Flyweights;
using Assi1.Strategies;

using System;

//Credit of the project goes to Michael Root, Haider Rizvi and Sam Nasser

namespace Assi1
{
    class Program
    {
        static void Main( string[] args )
        {
            // Uncomment sections here as you implement them

            // Create our HeavyObjects (DO NOT MODIFY THESE VALUES)
            HeavyObject lightest = new HeavyObject(10, 10, 1, 1);
            HeavyObject medium = new HeavyObject(7, 7, 2, 5);
            HeavyObject heavyAndSmall = new HeavyObject(5, 5, 5, 50);

            // Create lists of the HeavyObjects and print them for debug purposes
            HeavyObjectList listA = new HeavyObjectList();
            listA.Add(heavyAndSmall);
            listA.Add(medium);
            listA.Add(lightest);
            Console.WriteLine("ListA:");
            listA.Print();
            Console.WriteLine();

            HeavyObjectList listB = new HeavyObjectList();
            listB.Add(medium);
            listB.Add(lightest);
            listB.Add(heavyAndSmall);
            Console.WriteLine("ListB:");
            listB.Print();
            Console.WriteLine();

            HeavyObjectList listC = new HeavyObjectList();
            listC.Add(lightest);
            listC.Add(medium);
            listC.Add(heavyAndSmall);
            Console.WriteLine("ListC:");
            listC.Print();
            Console.WriteLine();
          
            // Create our Flyweight Factory and create the Flyweights out of it
            FlyweightFactory fw = new FlyweightFactory();
            IStrategy bottomWeight = fw.GetFlyweight("bottomWeight", (IStrategy)new BottomWeightStrategy());
            IStrategy pyramid = fw.GetFlyweight("pyramid", (IStrategy)new PyramidStrategy());
            IStrategy topple = fw.GetFlyweight("topple", (IStrategy)new ToppleStrategy());
 
            // Create our Flyweight Factory and create the Flyweights out of it
            FlyweightFactory fw = new FlyweightFactory();
            StackingStrategy bottomWeight = fw.GetFlyweight("bottomWeight");
            StackingStrategy pyramid = fw.GetFlyweight("pyramid");
            StackingStrategy topple = fw.GetFlyweight("topple");

            // Print results
            Console.WriteLine("BottomWeight - ListA: " + bottomWeight.ExecuteStrategy(listA));
            Console.WriteLine("BottomWeight - ListB: " + bottomWeight.ExecuteStrategy(listB));
            Console.WriteLine("BottomWeight - ListC: " + bottomWeight.ExecuteStrategy(listC));

            Console.WriteLine("Pyramid - ListA: " + pyramid.ExecuteStrategy(listA));
            Console.WriteLine("Pyramid - ListB: " + pyramid.ExecuteStrategy(listB));
            Console.WriteLine("Pyramid - ListC: " + pyramid.ExecuteStrategy(listC));

            Console.WriteLine("Topple - ListA: " + topple.ExecuteStrategy(listA));
            Console.WriteLine("Topple - ListB: " + topple.ExecuteStrategy(listB));
            Console.WriteLine("Topple - ListC: " + topple.ExecuteStrategy(listC));
          
            Console.WriteLine("Topple - ListA: " + topple.EvaluateStack(listA));
            Console.WriteLine("Topple - ListB: " + topple.EvaluateStack(listB));
            Console.WriteLine("Topple - ListC: " + topple.EvaluateStack(listC));
        }
    }
}
