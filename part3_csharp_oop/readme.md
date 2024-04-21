# Object Oriented Programming

* TOC
{:toc}

## Objects and Classes

A class is a template used to create objects.
They are made up of members, the main two of which are fields and methods. 
* **Fields** are variables that hold the state of the object
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

It is possible to create a class even if no constructors are defined. This is because the compiler will automatically add a default parameterless constructor to such a class. 

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

A class in C# may only inherit from one base class. If no base class is specified, the class will implicitly inherit from System.Object. This is therefore the root class of all other classes.

### Downcast and Upcast



## Redefining Members

## Access Levels

## Static

## Interfaces

## Abstract

## OOP concepts

## UML Class Diagrams