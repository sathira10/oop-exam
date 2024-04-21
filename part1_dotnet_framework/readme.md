# .NET Framework

## Programming Languages

* **High level languages** - Java, C, C#, C++, Python, etc.
* **Assembly language** (also called Machine Code)
* **Hardware language** - bits (1s and 0s)

> High Level Language > Assembly Language > Hardware Language

There are 2 types of high level code
1. **Native Code** *(C, C++)* - directly compiled into Assembly language
2. **Managed Code** *(C#, Java)* - uses a virtual machine or runtime environment

**Advantages of Managed Code**
1. Automatically handles memory management
2. Cross platform compatibility
3. Simplified development process

## .NET Framework

The .NET framework takes managed code a step further

* **Supports Different High Level Languages** (C#, F#, VB.NET)
* **CIL (Common Intermediate Language)** also known as MSIL (Microsoft intermediate language) - When you write and compile code in a high-level .NET language (such as C#), the compiler translates it into CIL. It is platform independent.
* **Common Language Runtime (CLR)** - The CLR provides the environment in which CIL can run. (e.g. .NET runtime for Windows and Mac)
* **Framework Class Library (FCL)** - It is a common library to all .NET languages with some basic functions. e.g.- `Console.WriteLine` is included in FCL

## C# Program Structure
The `Main` method is the entry point for the compiler


```c#
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
```
* C# programs in Visual Studio are structured as "solutions"
* Each solution can have multiple "projects"
* Every individual project becomes it's own assembly (`.dll`)