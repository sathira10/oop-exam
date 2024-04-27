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



        //int[] x = new int[3];
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

        //double d = 98.5;
        //int i = Convert.ToInt32(d);
        //Console.WriteLine(i);


        // List<int> ages = new List<int>() { 23, 99, 34, 45, 65, 00 };

        //foreach (int age in ages)
        //{
        //    Console.WriteLine(age);
        //}

        //ages.Sort();
        //Console.WriteLine("\n");


        //foreach (int age in ages)
        //{
        //    Console.WriteLine(age);
        //}

        //List<SampleObject> sampleObjects = new();
        //sampleObjects.Add(new SampleObject { Value = 99 });
        //sampleObjects.Add(new SampleObject { Value = 44 });
        //sampleObjects.Add(new SampleObject { Value = 10 });
        //sampleObjects.Add(new SampleObject { Value = 45 });
        //sampleObjects.Add(new SampleObject { Value = 78 });

        //foreach (SampleObject obj in sampleObjects)
        //{

        //    Console.WriteLine(obj.Value);
        //}

        //sampleObjects.Sort();

        //Console.WriteLine("\n");
        //foreach (SampleObject obj in sampleObjects)
        //{
        //    Console.WriteLine(obj.Value);
        //}


        //Rectangle r = new Rectangle();
        //Rectangle r = new Rectangle(2);
        //Rectangle r3 = new Rectangle(2, 3);
        ////Console.WriteLine(r.x);

        ////Console.WriteLine(Rectangle.count);
        //Console.WriteLine(Rectangle.count);


        //Console.WriteLine(Math.Sin(84));

        //bool isValidInput = false;
        //while (!isValidInput)
        //{
        //    Console.Write("Enter a double: ");
        //    string userInput = Console.ReadLine();
        //    try
        //    {
        //        double number = Convert.ToDouble(userInput);
        //        Console.WriteLine("You entered: " + number);
        //        isValidInput = true;
        //    }
        //    catch (FormatException ex)
        //    {
        //        Console.WriteLine("Format Exception: " + ex.Message + " Please try again.");
        //    }
        //    catch (OverflowException ex)
        //    {
        //        Console.WriteLine("Overflow Exception: " + ex.Message + " Please try again.");
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("An unexpected error occurred. Please try again.");
        //    }

        //    Console.WriteLine("Exiting the Program");
        //}

        // Operators


        Console.WriteLine(((3 + 2) * 5) % 4);

        int x = 5; int y = x++ + ++x;
        Console.WriteLine(y);

        int a = 5, b = 3;
        Console.WriteLine(!(b >= a) && (a == 5));

        int i = 5;
        int j = i += i *= 10;
        Console.WriteLine(j);

        i = 10; j = 20;
        Console.WriteLine((i > j) || (i == 5));

        //int x, y;

        //x = 5; y = x++; // y=5, x=6
        //Console.WriteLine(x + " " + y);

        //x = 5; y = ++x; // y=6, x=6
        //Console.WriteLine(x + " " + y);

        //x = 5;
        //Console.WriteLine(++x); //6

        //x = 5;
        //Console.WriteLine(x++); //5

        //x = 5;
        //Console.WriteLine(++x + x++); //12
        //Console.WriteLine(x);

        //x = 5;
        //Console.WriteLine(x++ + ++x); //12
        //Console.WriteLine(x);

        // Initialize a string
        string originalString = "Hello";

        // Append to the original string
        string modifiedString = originalString + ", World!";

        // Display both strings
        Console.WriteLine("Original String: " + originalString);
        Console.WriteLine("Modified String: " + modifiedString);

        // Check if they refer to the same object
        Console.WriteLine((ReferenceEquals(originalString, modifiedString))); // FALSE


    }

}

