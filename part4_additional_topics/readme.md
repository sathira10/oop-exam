# Additional Topics

* TOC
{:toc}

## Value Types and Reference Types

There are two kinds of data types in C#: value types and reference types. 

### Value Types 
* Directly contain their data (values are stored inside the variable)
* e.g. - int, double, bool, char, decimal, etc
* Allocated in the stack

### Reference Types 
* Holds references to their data 
* Created via the new operator
* e.g. - arrays and objects
* Is allocated in the heap
* The reference variable for that object is allocated in the stack

> see diagrams in week 5 lecture note

### Methods Parameters

When passing parameters to a method in C#, value types are passed by value and reference types are passed by reference.

**Pass by Value** - When passing parameters of value type, only a local copy of the variable is passed. This means that if the copy is changed, it will not affect the original variable.

**Pass by Reference** - when a reference type is passed, the change propagates back to the original object.


## Garbage Collection

 A process that automatically frees up memory by destroying objects that are no longer in use by the application. 

* Is a feature provided by the Language Runtime (CLR)
* The programmer does not need to de-allocate objects explicitly
* Can prevent issues due to memory leaks

## Namespaces

Namespaces provide a way to group related top-level members into
a hierarchy. They are also used to avoid naming conflicts.

```c#
namespace MyNamespace
{
  class MyClass {}
}
```

## Assemblies

* Assemblies are the building blocks of .NET applications
* An assembly is a collection of types and resources that are built to work together and form a logical unit of functionality
* Assemblies take the form of executable (.exe) or dynamic link library(.dll) files
* In C#, each project is a different assembly

## Exception Handling

## Constants

## Collections

## Sorting

## Streams and Files
