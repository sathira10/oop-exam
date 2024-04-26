using System;
using System.Drawing;

namespace Questions
{


	public class StackVsheap
	{
        // Method to try modifying an integer value
        public static void ModifyValue(int val)
        {
            val += 10;
            Console.WriteLine("Value inside method: " + val);
        }

        // Method to modify an object's value
        public static void ModifyObject(SampleObject obj)
        {
            obj.Value += 10;
            Console.WriteLine("Value inside method: " + obj.Value);
        }


    }

    public class SampleObject
    {
        public int Value { get; set; }
    }
}

