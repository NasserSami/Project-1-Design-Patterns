using System;

namespace Assi1
{
    // HeavyObject.cs - Represents a physical object with mass properties
    public class HeavyObject
    {
        public float Width;
        public float Length;
        public float Height;
        public float Density;

        // Initialize object dimensions and density
        public HeavyObject( float width = 1000f, float length = 1000f, float height = 1000f, float density = 1f )
        {
            Width = width;
            Length = length;
            Height = height;
            Density = density;
        }

        // Volume = Width * Height * Length
        public float Volume
        {
            get { return Width * Height * Length; }
            set { }
        }

        // Mass = Volume * Density
        public float Mass
        {
            get { return Volume * Density; }
            set { }
        }

        public void Print()
        {
            Console.WriteLine("HeavyObject: (" + Width + "x" + Length + "x" + Height + "), density = " + Density + ", mass = " + Mass);
        }
    }
}
