# C# Basics

## Variables

### Declaration and Assignment

* a variable must be declared (created) before it can be used

    `int myInt;`

* A value is assigned to the variable by using the equals sign

    `myInt = 10;`

* These two steps can be combined. Also we can declare and assign multiple variables at once.

    `int myInt = 10;`

    `int myInt = 10, myInt2 = 20, myInt3;`



### Basic Data Types

* **Integers** - int (32 bit) or long (64 bit)

    `int i  = 42`

* **Floating-point numbers** - float (32 bit) or double (64  bit). Default is double, if we want to use float have to add an 'F' at the end 

    `float f = 3.14F;`

    `double f = 3.14F;`

* **Char** - char type can contain a single Unicode character inside  single quotes.


    `char c = 'a';`

* **Boolean** - bool type can store a Boolean value, specified with the true and false keywords. 

    `bool b = true;`


> string data type is discussed separately below

### Type Conversion

#### **Implicit Conversion**

Happens automatically when one data type is assigned to another data type that is **capable of representing it without data loss**

If we try the opposite we get a **Compile error**

 ```C#
double a = 2; // a = 2.0
int a = 18.7; // ERROR
```


Before performing calculations, C# promotes values of types with a narrower range into the larger one (promotion).

```C#
int num = 10;
int den = 4;
int result = num / den;
// result = 2

double num = 10;
double den = 4;
double result = num / den;
// result = 2.5
```

The opposite (narrowing) does not happen automatically.

#### **Explicit Conversion (Casting)**

Has to be used when conversion is not supported implicitly.

```C#
int a = 18.7; // ERROR
int a = (int)18.7; // a = 18
```

We can also use the `Convert` class for this

```C#
string s = "123";
int i = Convert.ToInt32(s); 
```
This is specially useful with Console input
```C#
string userInput = Console.ReadLine();
int numericValue = Convert.ToInt32(userInput);
```

## Operators

### Arithmetic Operators

```C#
float x = 3 + 2; // addition (5)
      x = 3 - 2; // subtraction (1)
      x = 3 * 2; // multiplication (6)
      x = 3 / 2; // division (1)
      x = 3 % 2; // modulus (1)
```

### Assignment Operators

```C#
int i = 0; // assignment

i += 5; // i = i+5;
i -= 5; // i = i-5;
i *= 5; // i = i*5;
i /= 5; // i = i/5;
i %= 5; // i = i%5;
```

### Increment and Decrement Operators

```C#
x++; // post-increment
x--; // post-decrement
++x; // pre-increment
--x; // pre-decrement
```

The post-operator returns the original value before it changes the variable, while the pre-operator changes the variable first and then returns the value. See the following example.

```C#
int x, y;
x = 5; y = x++; // y=5, x=6
x = 5; y = ++x; // y=6, x=6
```

### Comparison Operators

```C#
bool b = (2 == 3); // equal to (false)
     b = (2 != 3); // not equal to (true)
     b = (2 > 3);  // greater than (false)
     b = (2 < 3);  // less than (true)
     b = (2 >= 3); // greater than or equal to (false)
     b = (2 <= 3); // less than or equal to (true)
```

### Logical Operators

```C#
bool b = (true && false); // logical and (false)
     b = (true || false); // logical or (true)
     b = !(true);         // logical not (false)
```

### Operator Precedents
1. increment, decrement(`++` `--`), not (`!`)
2. multiplication, division, modulus (`*` `/` `%`)
3. addition, subtraction (`+` `-`)
4. comparisons (`<` `<=` `>` `>=`)
5. equality (`==` `!=`)
6. and (`&&`)
7. or (`||`)
8. assignment (`=`)

## Strings

The string data type is used to store string constants. They are delimited by double quotes.

`string a = "Hello";`

### String Concatenation

The concatenation operator (+) can combine strings together. When one of the operands is not of a string type, they will be implicitly be converted to a string

```C#
string a = "Hello";
string b = a + " World"; // Hello World
a += " World"; // Hello World

int i = 1;
string c = i + " is " + 1; // 1 is 1
```
we can also use the `ToString` method

```C#
int i = 1;
string d = i.ToString() + " is " + 1.ToString(); // 1 is 1
```

Another way to compile strings is to use **String Interpolation**

To perform string interpolation, a dollar sign ($) is placed before the string.

```C#
string s1 = "Hello";
string s2 = "World";
string s = $"{s1} {s2}"; // Hello World
```

### Escape Characters

To add new lines into the string itself, the escape character (\n) is used. This backslash notation is used to write special characters

`myString = "Hello\nWorld";`

Common escape characters
* `\n` newline
* `\t` horizontal tab
* `\'` single quote
* `\"` double quote
* `\\` backslash

### String Members

The string type is an alias for the String class. Many methods are available in the String class

```C#
string a = "String";
string b = a.Replace("i", "o"); // Strong
       b = a.Insert(0, "My ");  // My String
       b = a.Remove(0, 3);
       b = a.Substring(0, 3);
       b = a.ToUpper();
int    i = a.Length;    
```

Note that there are no methods for changing a string. Methods that appear to modify a string actually return a completely new string. 

## Arrays

An array is a data structure used for storing a collection of values that all have the same data type. Length of an array cannot be modified.

```C#
int[] x; // integer array
int[] x = new int[3];
```

When an array is created like above, the elements will automatically be assigned to the default value for that data type, in this case zero.

Arrays are zero indexed (first element is index 0)
```C#
x[0] = 1;
x[1] = 2;
x[2] = 3;

System.Console.Write(x[0] + x[1] + x[2]); // "6"
```

We can also use the following shorthand natation

```C#
// values can be assigned all at once by using a curly bracket notation
int[] y = new int[] { 1, 2, 3 };

// new keyword and data type may optionally be left out if the array is declared at the same time.
int[] z = { 1, 2, 3 };
```

## Conditionals

### If Statement

```C#
if (x < 1)
  System.Console.Write(x + " < 1");
else if (x > 1)
  System.Console.Write(x + " > 1");
else
  System.Console.Write(x + " == 1");
```

### Switch Statement
```C#
switch (x)
{
  case 0: System.Console.Write(x + " is 0"); break;
  case 1: System.Console.Write(x + " is 1"); break;
  default: System.Console.Write(x + " is >1"); break;
}
```

### Ternary Operator

```C#
d = (d < 0.5) ? 0 : 1;
```

## Loops

### While Loop

```C#
int i = 0;
while (i < 10) {
  System.Console.Write(i++); // 0-9
}
```

### Do-While Loop

```C#
int j = 0; do {
  System.Console.Write(j++); // 0-9
} while (j < 10);
```

### For Loop

```C#
for (int k = 0; k < 10; k++) {
  System.Console.Write(k); // 0-9
}
```

### Foreach Loop

```C#
int[] a = { 1, 2, 3 };
foreach (int m in a) {
  System.Console.Write(m); // "123"
}
```

### Break and Continue

The break keyword ends the loop structure, and continue skips the rest of the current iteration and continues at the start of the next iteration.

```C#
for (int n = 0; n < 10; n++) {
  if (n == 5) break; // end loop
  if (n == 3) continue; // start next iteration
  System.Console.Write(n); // "0124"
}
```

## Methods

Methods are reusable code blocks that will only execute when called.

### Defining Methods

A method can be created inside a class by typing void followed by the method’s name, a set of parentheses, and a code block.

```C#
class MyApp {
  void Print()
  {
    System.Console.WriteLine("Hello World");
  }
}
```


### Calling Methods

```C#
class MyApp {
  static void Main()
  {
    MyApp m = new MyApp();
    m.Print(); // Hello World
  }
  void Print()
  {
    System.Console.WriteLine("Hello World");
  }
}
```


### Method Parameters

```C#
void MyPrint(string s1, string s2)
{
  System.Console.WriteLine(s1 + s2);
}
```
```C#
static void Main()
{
  MyApp m = new MyApp();
  m.Print("Hello", " World"); // "Hello World"
}
```


### Method Overloading

It is possible to declare multiple methods with the same name as long as the parameters vary in type or number.

```C#
void Print(string s)
{
  System.Console.WriteLine(s);
}
void Print(int i)
{
  System.Console.WriteLine(i);
}
```

### Return Statement

A method can return a value by replacing void with the data type that the method will return, and a return statement is added.

```C#
string GetPrint()
{
  return "Hello";
}
```