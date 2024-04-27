# Part 1: .NET Framework

1. What is managed code and give examples of languages that use this concept?
2. What is the Common Intermediate Language (CIL) and why is it important in .NET development? What is another name for CLI.
3. Explain the role of the Common Language Runtime (CLR) in the .NET Framework.
4. Describe the structure of a basic C# program that prints "Hello, World!" to the console.
5. What are the advantages of using managed code in the .NET Framework?
6. How does the .NET Framework achieve cross-language interoperability?
7. What is the Framework Class Library (FCL) and what purpose does it serve in .NET development?
8. Explain the concept of a solution and a project within the context of Visual Studio. How does it relate to an assembly in C#?
9. What distinguishes native code from managed code, and provide examples of languages that produce each type?
10. What is the purpose of the 'args' parameter in the Main method of a C# program?

# Part 2: C# Basics

## Variables
1. Give a few code examples of variable declaration and identify which of them are syntactically correct
2. How to declare a floating point number instead of a double?

## Type Conversion
1. What is implicit type conversion in C#, and provide an example where it is successfully used?
2. What occurs when you attempt to implicitly convert a double to an integer in C#?
3. Explain the concept of type promotion in C# with an example.
4. How does explicit type conversion (casting) work in C#, and give an example demonstrating its use?
5. Show how we can use the Convert class to do explicit casting.

## Operators
1. What is the result of using the modulus operator in C#, and provide an example?
2. Explain the difference between post-increment and pre-increment operators in C# with examples.
3. How do assignment operators work in C#? Provide examples for += and /=.
4. What is the order of precedence among arithmetic, logical, and assignment operators in C#?
5. Evaluate these expressions:
    1. `((3 + 2) * 5) % 4` (ans: s1)
    2. `x = 5; y = x++ + ++x;` (ans: 12) 
    3. `!(b >= a) && (a == 5)` where `a = 5` and `b = 3` (ans: True)
    4. `int i = 5; int j = i += i *= 10` (ans: 55)
    5. `(i > j) || (i == 5) `if `i = 10` and `j = 20` (ans: False)

## Strings
1. Explain how implicit conversion works in string concatenation with a non-string type.
2. Describe the use of escape characters in strings with examples of how to include a newline and a tab.
3. How does string interpolation work in C#, and give an example demonstrating its syntax
4. What methods can be used to modify a string in C#, and explain why they do not actually alter the original string?

## Arrays
1. What is an array in C#, and why must all elements in an array have the same data type?
2. Explain what it means when we say arrays in C# are "static" in size.
3. Describe how elements in an array are initialized when an array of integers is declared in C#.
4. Discuss the implications of the immutability of array size in C# and how it affects the management of collections of data.
5. Questions from Array syntax

> *conditionals*, *loops*, and *methods* parts probably will have code questions, from the syntax

# Part 3: OOP

1. Define what an object is in the context of OOP.
2. What is a class in OOP and how is it related to an object?
3. Explain the purpose of a constructor in a C# class.
4. How does the this keyword function within a class in C#?
5. Describe the concept of constructor overloading with an example.
6. Differentiate between public, protected, internal, and private access modifiers in C#.
7. How can you access a private field from outside its class in C#?
8. What is the significance of static fields in a class? Provide an example.
9. Explain how static methods differ from instance methods in C#.
10. Describe the process and purpose of inheritance in OOP.
11. How does a subclass constructor in C# utilize a base class constructor?
12. Explain the concepts of upcasting and downcasting with examples.
13. What is boxing in C#, and how does it differ from unboxing?
14. Define what a virtual member is and its use in C#.
15. What is a sealed method or class in C#, and why would you use it?
16. Describe an abstract class and its purpose in OOP.
17. What is an interface and how does it differ from a class in C#?
18. What is the difference between composition and aggregation in terms of class relationships?
19. Why would a method be declared as static? Give an example scenario.
20. Explain the concept of the default constructor in C# and its behavior if not explicitly defined.
21. What are the benefits of using properties with getters and setters compared to public fields?
22. Discuss the impact and usage of the override keyword in a C# program.


# Part 4: Additional Concepts

## Value and Ref types
1. What are value types in C#, and where are they stored? Give examples of C# value types and explain how they are managed in memory.
2. Describe what reference types are in C#. Explain what happens in memory when a new reference type is created in C#.
3. Explain what it means to pass a parameter by value in C#. What happens to the original variable if the parameter is modified within the method?
4. ~~Describe the behavior of passing a reference type by value in C#. How does it differ from passing a value type by value?~~
5. Explain what it means to pass a parameter by reference in C#. What happens to the original variable if the parameter is modified within the method?

## Garbage Collection
1. What is the primary purpose of garbage collection in C#?
2. Describe how garbage collection in C# differs from manual memory management in languages like C++.
3. Explain what is meant by "garbage collection is provided by the Language Runtime (CLR)" in the context of C#.

## Namespaces, Assemblies, Constants
1. What is the purpose of namespaces in C#, and how do they help manage large codebases?
2. ~~Give an example of how a namespace can be used to resolve naming conflicts between two classes that have the same name but different functionalities.~~
3. How do assemblies contribute to the structure and deployment of a C# application?
4. Explain the use of the const keyword in C#. What happens if you try to change the value of a constant variable after it has been initialized?

## Collections
1. What is the primary difference between a fixed-size array and a dynamic collection such as a List in C#?
2. ~~How does the List collection manage its size as elements are added or removed?~~
3. ~~Describe the IList interface. What are some of the key methods it defines for managing collections?~~
4. In what scenario might you choose to use an ArrayList over a List in C#?
5. What is boxing and unboxing in the context of ArrayLists, and why is it considered a performance overhead?
6. How can the use of generic collections like List<T> improve type safety compared to non-generic collections like ArrayList?
7. Define the purpose of a Dictionary collection in C#. What makes it different from a List?
8. What are the advantages of using a SortedDictionary<TKey, TValue> over a regular Dictionary<TKey, TValue>?
9. Give an example of a situation where you would use a Dictionary<TKey, TValue> instead of a List<T>.
10. ~~How do generic collections in System.Collections.Generic offer better performance than their non-generic counterparts?~~

## Exception Handling
1. What is the difference between a runtime error and a compile time error?
2. What is an exception in the context of C# programming?
3. Describe the purpose of the try block in C#'s exception handling.
4. What is the role of a catch block? Provide an example where it catches a specific type of exception.
5. Explain the function of the finally block. When is it executed in the flow of a program?
6. Provide an example of using StreamReader within a try-catch-finally block to handle possible exceptions during file reading.
7. Discuss how exceptions act as objects in C#. What properties do these objects typically possess? What is the base class of any exception.
8. How can you define your own custom exception class in C#? Provide a simple example.

## Sorting
1. Explain how the Sort method of the List<T> class works when sorting a list of integers or strings.
2. What role does the CompareTo method play in the sorting process of a List<T> in C#?
3. Describe the contract specified by the IComparable<T> interface. What must a class implement to satisfy this contract?
4. Provide an example of a custom class that implements the IComparable<T> interface to allow its objects to be sorted using the List<T>'s Sort method.
5. ~~Discuss how you can customize the sorting behavior of a List<T> that contains objects of a class which implements IComparable<T>.~~

## Streams and Files
1. What is a stream in the context of C# programming?
2. Describe the primary functions of the System.IO.Stream class. How do these functions facilitate file operations?
3. Explain the difference between binary streams and character streams in .NET. Why might one choose to use character streams?
4. How does encoding affect the handling of character streams, especially when dealing with different operating systems?
5. Describe the role of the StreamWriter class in C#. How does it handle character encoding by default?
6. Compare and contrast the two constructors of StreamWriter. How does each establish the connection to the underlying data stream?
7. What is the purpose of the Write and WriteLine methods in StreamWriter? How do they differ in their output?
8. What are some best practices for managing file streams in C# to avoid resource leaks?
9. How does the Dispose method function in the context of file handling, and why is it important to call it?
10. Provide an example of how to handle exceptions that might occur during file read/write operations using streams in C#.