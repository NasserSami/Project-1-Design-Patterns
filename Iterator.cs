using System;

// Mike: Built this based on IIterator.cs in week 3 Iterator_End code.
namespace Assi1
{
	public interface IIterator<HeavyObject T>
	{
		T First();

		T Next();

		bool IsDone()

		T Current();
	}
}
