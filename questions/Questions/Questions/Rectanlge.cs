using System;
namespace Questions
{
   abstract class Rectangle
   {
       public int x, y;

       public static double PI = 3.14159;

       public static int count = 0;


       //public Rectangle(int a, int b) { x = a; y = b; count++; }

       //public Rectangle(int a) : this(a, a) { }
   }

   class Square : Rectangle
   {
       public override int GetArea() { return x * x; }
   }
}

