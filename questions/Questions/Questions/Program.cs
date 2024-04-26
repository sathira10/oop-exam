using System.Collections;

namespace Questions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //value type
        //int a = 5;
        //int b = 5;
        //Console.WriteLine(a == b);
        //Console.WriteLine(a.Equals(b));
        //// equality operator compares value


        //// reference type
        //SampleObject obj1 = new SampleObject { Value = 10 };
        //SampleObject obj2 = new SampleObject { Value = 10 };

        //Console.WriteLine(obj1 == obj2);
        //// equality operator compares memory address
        //Console.WriteLine(obj1.Equals(obj2));


        //SampleObject obj3 = obj1;
        //Console.WriteLine(obj1 == obj3);
        //Console.WriteLine(obj1.Equals(obj3));

        //Console.WriteLine(obj3.Value);


        // Demonstrating pass by value with integers
        //int value = 10;
        //Console.WriteLine("Original integer value: " + value);
        //StackVsheap.ModifyValue(value);
        //Console.WriteLine("Integer value after modification attempt: " + value);

        //// Demonstrating pass by reference with objects
        //SampleObject obj = new SampleObject { Value = 10 };
        //Console.WriteLine("\nOriginal object value: " + obj.Value);
        //StackVsheap.ModifyObject(obj);
        //Console.WriteLine("Object value after modification: " + obj.Value);



        int[] x = new int[3];
        //x[8] = 8;

        ////x[0] = 1;
        ////x[1] = 2;
        ////x[2] = 3;

        //Console.Write(x[0] + x[1] + x[2]); // "6"

        // values can be assigned all at once by using a curly bracket notation
        //int[] y = new int[] { 1, 2, 3 };

        // new keyword and data type may optionally be left out if the array is declared at the same time.
        //int[] z = { 1, 2, 3 };

        //List<int> ages = new List<int>();
        //ArrayList bandList = new ArrayList();

        //bandList.Add("jwhejrw");
        //bandList.Add(5345);
        //bandList.Add(new SampleObject());
        //bandList.Insert(2, "sjdhfjas");
        //bandList.RemoveAt(3);
        ////bandList.RemoveAt(8);

        //Dictionary<int, string> myDictionary = new();

        //myDictionary.Add(1, "hello");
        //myDictionary.Add(3, "oooo");
        //myDictionary.Add(9, "oooo");
        //string s;
        //myDictionary.TryGetValue(3, out s);

        //Console.WriteLine(s == null);
        //myDictionary.ContainsKey(3);

        double d = 98.5;
        int i = Convert.ToInt32(d);
        Console.WriteLine(i);
    }


}

