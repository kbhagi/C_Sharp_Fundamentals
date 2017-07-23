# C_Sharp_Fundamentals
Fundamentals of C# What is C# ? , What is .Net ? 
C# is a programming Language.
.Net is a Framework of libraries that works on Windows like VB.Net

Before C# whe had two languages in C Family. C, C++ Compiler translated C/C++ code in High Level Language into Native code. We had differenct hardwares & different O.S , So when microsoft was designing C# and .Net they came up with this idea of cross-compatibililty
Borrowing from open_source world , Java where compiler compiles into a Bytecode instead of Native code.

Same way, in C# when you write code ,its compiled into a IL Code , Intermediate Language Code. IL code is independent of computer on which it is running. CLR converts IL Code into Native Code . CLR is an application sitting in memory that converts IL Code into Native Code . This process is called Just-in-time compilations or JIT. So you can write your code in C#, you dont need to worry about architecture because CLR takes care of that , CLR is specific to Linux, Windows,Mac OS X. That takes care of conversion into machine code i.e Native Code , & running on that operating system.


ARCHITECTURE OF .NET APPLICATIONS : Building blocks are classes. These classes collaborate each other at Runtime. Class has Data & Methods. Data respresents state of applications. Method represents its functionality.

Each Class responsible for a peice of functionality. Organize classes into related classes. Namespaces is a container for related classes. 

As the number of classes grow, we need a way to partition an application. That's where Assembly comes into play. An assembly is a container for related namespaces.PHysically is a file under disk which can be executable or dll
Compiler buils one or more assembly based on how your partition your code.

AssemblyInfo.cs is an identification for the assemboly that will be produced as a result of compilation.  That is the result of When we compile an application you get an executable that is the assebmly

App.config is a settings file for an application. like connection to database

Using statement to import code from different namespaces. 
Every class you create has a class called Program. Main method is entry point to application. When you run our applicatino clr executes code inside main method.

Methods have input and output.

Variable: a name given to a storage location in memory.
Constant: an immutable value . To create safety in our application
