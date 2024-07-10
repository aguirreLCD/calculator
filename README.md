This is a project to learn how to:

- create and run a .NET console application by using Visual Studio Code and the .NET CLI.
- manage multiple projects;
- debug;
- publish;

# Using Visual Studio Code:

## Create a Console Application: Calculator App

```
dotnet new console
dotnet build
dotnet run
```

### Create .vscode files to configure build and debug:

```
Command + P:
.NET: Generate Assets for Build and Debug
```

To handle terminal input while debugging, you can use the integrated terminal:
In launch.json file, configure console:

"console": "integratedTerminal",

### Create a .gitignore template

```
dotnet new gitignore
```

### Check for .NET sdks:

```
dotnet --list-sdks
```

## Extend Console Application:

(Manage multiple projects in VSCode)

### Creating a .NET class library

class library – assembly that can be used by other assemblies

#### Add a second project: Calculator Library

```
dotnet new classlib CalculatorLibrary
```

||

```
- Command + P:
.NET: New Project

- Search for template:
Class Library

- Name the New Project:
CalculatorLibrary
```

#### In Solution Explorer

```
- Right-Click on node Calculator
- Add Project Reference
- Select the Project to Add Reference to
```

# Working on:

- [] - Delete function:
- [x] - delete mathGames array || item;
- [x] - delete score array || score operation;

- [] - improve this logic:
- -- 1 = Addition, 2 = Subtraction, 3 = Multiplication, 4 = Division, 5 = Square2d;
- -- int[,] scores = new int[,] { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 } };
- -- string[] mathGames = new string[33];

- [] - Learning about return methods;

- [] - why

- Dereference of a possibly null reference;
  (local variable) string? readResult
  'readResult' may be null here.
- if (!String.IsNullOrEmpty(readResult))
- if is inside this if (readResult != null)?

- [x] Display calculations by operation (1 = Addition, 2 = Subtraction, 3 = Multiplication, 4 = Division, 5 = Square2d);

- [x] Delete calculations by operation (1 = Addition, 2 = Subtraction, 3 = Multiplication, 4 = Division, 5 = Square2d);

- [] Ask to delete only if array is not null or empty;

- IsNullOrEmpty - equivalent for Array?

- [] Implement logic for Square Root function (\* operator is == in Multiplication method);

- [] - Validation for input:
- [] - if (Console.ReadLine() == "y");
- [] - if (Console.ReadLine() == "d");
- [] - if (Console.ReadLine() == "x")

# Learning Topics:

- .NET is a platform to develop and run applications;

- Methods definied in .NET code libraries are called assemblies;

- Libraries encapsulates funcionality for a specific purpouse into a single assembly;

- An app model are an application Framework that combines several related libraries, along with starter projects, file templates, code generators, and other tools that developers use to build an app for a specific pourpouse;

- Wrong syntax results in a compilation error;
  Compiler throws a compilation error;

- Logic problems results in a runtime error, or exception;
  (logic error prevents the .NET runtime from running commands, then the program CRASHES)

- Dependency is an object that another object depends on;

->>>>

- application – assembly with an entry point;

- assembly – one or more files output by the compiler as a result of program compilation;

- module – the contents of an assembly produced by a compiler. Some implementations may have facilities to produce assemblies that contain more than one module. The behavior in such situations is outside the scope of this specification;

- namespace – logical organizational system grouping related program elements;

- program – one or more compilation units that are presented to the compiler and are run or executed by an execution environment

->>>>

<!--

set up a .NET project to work with dependencies

- dotnet list package

- dotnet list package --include-transitive

Creating a solution;
dotnet new sln; -->
<!-- Create a functionality that will count the amount of times the calculator was used.

Store a list with the latest calculations. And give the users the ability to delete that list.

Allow the users to use the results in the list above to perform new calculations.

Add extra calculations: Square Root, Taking the Power, 10x, Trigonometry functions. -->
