# Object Oriented Programming

* TOC
{:toc}

## Objects and Classes

* A class is a template used to create objects.
* A class allows the definition of a custom type
* An Object is a "variable" of that custom type

Classes are made up of two types of members:
* **Attributes** are variables that hold the state of the object
* **Methods** define what the object can do

```c#
class Rectangle
{
  int x, y;
  int GetArea() { return x * y; }
}
```

### Creating Objects

Use the new keyword to create objects

```c#
class MyApp {
  static void Main()
  {
    // Create an object of Rectangle
    Rectangle r = new Rectangle();

    // type specified after the new expression can optionally be omitted
    Rectangle r = new();
  }
}
```

### Accessing Object Members

A dot (.) is used after the object’s name to reference its accessible members.

```c#
class Rectangle
{
  // Make members accessible for instances of the class
  public int x, y;
  public int GetArea() { return x * y; }
}
```

```c#
static void Main()
{
  Rectangle r = new Rectangle();
  r.x = 10;
  r.y = 5;
  int a = r.GetArea(); // 50
}
```

## Constructors

This is a special kind of method used to instantiate (construct) the object. It always has the same name as the class and does not have a return type


```c#
class Rectangle
{
  public int x, y;

  public Rectangle(int width, int height)
  {
    x = width; y = height;
  }
}
```

It is possible to create a class even if no constructors are defined. This is because the compiler will automatically add a default parameter-less constructor to such a class. 

The default constructor will instantiate the object and set each field to its default value.

### This Keyword

This keyword is a reference to the current instance of the class. Can be used inside the constructor or other methods.

```c#
class Rectangle
{
  public int x, y;

  public Rectangle(int x, int y)
  {
    this.x = x; // set field x to parameter x
    this.y = y; }
}
```

### Constructor Overloading
Constructor can be overloaded like any other method

```c#
class Rectangle
{
  public int x, y;
  public Rectangle() { x = 10; y = 5; }
  public Rectangle(int a) { x = a; y = a; }
  public Rectangle(int a, int b) { x = a; y = b; }
}
```

Constructors can use other constructors too. This is known as constructor chaining.

```c#
class Rectangle
{
  public int x, y;
  public Rectangle(int a) : this(a, a) {}
  public Rectangle(int a, int b) { x = a; y = b; }
}
```

## Access Levels

Every class member has an accessibility level that determines where the member will be visible. 
* public
* protected
* internal
* private

When selecting an access level, it is generally best to use the most restrictive level possible. Object members are private by default.

* **Private Access** - 
Accessible in the class in which they are declared, the defining class.

* **Protected Access** -
A protected member can be accessed from within a derived class, but it is inaccessible from any other classes.

* **Internal Access** - 
An internal member can be accessed anywhere within the local assembly, but not from another assembly. An assembly is the compilation unit of a .NET project, either an executable program (.exe) or a library (.dll).

* **Public Access** - 
The public modifier gives unrestricted access from anywhere that a member can be referenced.


## Get and Set Methods

Private attributes that need to be accessed externally typically have associated Get and Set methods

```c#
class Time {
  private int seconds;
  
  // Get method
  public int getSeconds() { return seconds; }

  // Set method
  public void setSeconds (int seconds) 
  { 
    this.seconds = seconds; 
  }
}
```

C# also supports an additional way to define attributes with associated Get and Set methods using **Properties**

```c#
class Time {
  private int sec;
  public int Seconds
  {
    get { return sec; }
    set { sec = value; }
  }
}
```

Note that the contextual `value` keyword corresponds to the value assigned to the property.


## Static

* The static keyword can be used to declare fields and methods that can
be accessed without having to create an instance of the class. 
* Static (class) members only exist in one copy, which belongs to the class itself
* Non-static (instance) members are created as new copies for each new object


### Static Attributes
* A static attribute of a class is shared by all the instances of that class
* It exists regardless of objects of that class being instantiated
* It is located in a special section of the heap associated to that class
* A public static attribute can be accessed directly using: `ClassName.AttributeName`


### Static Methods
* Static methods are attached to a class and do not operate on any of the instance variables (attributes)
* They can be called without an object instance created first
* Hence they can only refer to other static members (attributes and methods) of the same class

```c#
class Circle
{
  // Instance variable (one per object)
  public float r = 10F;
  
  // Static/class variable (only one instance)
  public static float pi = 3.14F;

  // Instance method
  public float GetArea()
  {
    return ComputeArea(r);
  }
  // Static/class method
  public static float ComputeArea(float a)
    {
    return pi * a * a;
  } 
}
```

## Inheritance

Inheritance allows a class to acquire the members of another class.

```c#
// Base class (parent class)
class Rectangle
{
  public int x = 10, y = 10;
  public int GetArea() { return x * y; }
}

// Derived class (child class)
class Square : Rectangle {}
```

A class in C# may only inherit from one base class. If no base class is specified, the class will implicitly inherit from `System.Object`. This is therefore the root class of all other classes. It is discussed separately in a below section.

### Subclass Constructor

We can use the constructor of the parent class when defining the constructor for the child class.

```c#
class Rectangle
{
    public int Width, Height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
}

class Square : Rectangle
{
    public Square(int side) : base(side, side) {}
}
```
### Downcast and Upcast

Square is a kind of Rectangle as well as an Object, and it can therefore be used anywhere a Rectangle or Object is expected.

If an instance of Square is created, it can be upcast to Rectangle since the derived class contains everything in the base class.

```c#
Square s = new Square();
Rectangle r = s; // upcast
```

The object is now viewed as a Rectangle, so only Rectangle’s members can be accessed. When the object is downcast back into a Square, everything specific to the Square class will still be preserved. This is because the Rectangle only contained the Square; it did not change the Square object in any way.

The downcast has to be made explicit since downcasting an actual Rectangle into a Square is not allowed.

```c#
Square s2 = (Square)r; // downcast

Rectangle r2 = new Rectangle();
Square s3 = (Square)r2; // error

```


### Boxing and Unboxing

C# allows for a variable of value type to be implicitly converted into a reference type of the Object class. This operation is known as boxing, and once the value has been copied into the object, it is seen as a reference type.

Unboxing converts the boxed value back into a variable of its value type. The unboxing operation must be explicit. If the object is not unboxed into the correct type, a **runtime** error will occur.

```c#
int value = 5;
object obj = value; // boxing

value = (int)obj; // unboxing
```

### Virtual Members

A member in a derived class can redefine a member in its base class. This can be done for all kinds of inherited members, but it is most often used to give instance methods new implementations.

```c#
class Rectangle
{
  public int x = 1, y = 10;

  // virtual modifier allows the method to be overridden in a derived class
  public virtual int GetArea() { return x * y; }
}

class Square : Rectangle
{
  // override modifier can then be used to change the implementation of the inherited method
  public override int GetArea() { return 2 * x; }
}

// btw this example doesn't make logical sense. just to demonstrate the syntax
```


### Sealed Methods and Classes

* sealed methods: cannot be overridden
* sealed classes: cannot be extended (subclassed)

Methods are sealed by default in C# unless declared virtual


## Abstract Classes

* An abstract class provides a partial implementation that other classes can build on. 
* When a class is declared as abstract, it means that the class can contain incomplete members that must be implemented in derived classes, in addition to normal class members.
* It is not possible to instantiate an abstract class

```c#
abstract class Shape
{
  protected int x = 100, y = 100;
  public abstract int GetArea();
}

class Rectangle : Shape
{
  public override int GetArea() { return x * y; }
}
```
## Interfaces

Multiple inheritance (inheriting from many parent classes) is not supported in C#. It can lead to problems like the "deadly diamond of death". This problem is solved using interfaces.

An interface is used to specify members that deriving classes must implement. 

```C#
interface IMyClass
{
  void Exposed();
}

class MyClass : IMyClass
{
  public void Exposed() {}
  public void Hidden()  {}
}
```


## OOP Concepts

There are 4 fundamental concepts in OOP that are discussed above.

1. **Encapsulation**: a single object contains both its data and behaviors and can hide what it wants from other objects

2. **Inheritance**: a class can inherit from another class and take advantage of the attributes and methods defined by the superclass

3. **Polymorphism**: similar objects can respond to the same message(method invocation) in different ways

4. **Abstraction**: a class should provide an abstract view of a “service”through its public methods and hide the implementation details

## The Object Class

## UML Class Diagrams

### Composition

### Aggregation