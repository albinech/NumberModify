# Filter by Predicate. Interfaces

Intermediate level task for practicing interfaces, strategy pattern.

Estimated time to complete the task - 1.5h.

The task requires .NET 6 SDK installed.

## Task description

- Develop the [ArrayExtensions](ArrayExtensions) class with following methods:

    - the `FilterByDigit` method, which takes an array of integers as a parameter and, based on it, forms a new array only from those elements that contain the given digit;
    - the `FilterByPalindromic` method, which takes an array of integers as a parameter and, based on it, forms a new array only from those elements that are palindromes.    
    _When implementing these methods, follow the suggested skeletons._

- Analyze the resulting methods:
    - what part of their code is the same?
    - which part depends on a specific _predicate_*?      
    _*A predicate  is a statement made about a subject. The subject of the statement is that about which the statement is made. A predicate in programming is an expression that uses one or more values with a boolean result._

    _Discuss this question and your answer with your trainer, if you work in a regular group._

- In this task predicate is defined as a `IsMatch` method of the [IPredicate](FilterByPredicate/IPredicate.cs) interface. The implementation details of the predicate logic are left to the derived classes.

- Put the common part of the code as a skeleton of operations in the `Select` extesion method of the [ArrayExtensions](FilterByPredicate) static class. The method must contain the `IPredicate` interface as a parameter.

- Develop derived classes for described above predicates. Place the solutions in two separate projects:

    - [Filter by Digit](FilerByDigit);
    - [Filter by Palindromic](FilterByPalindromic).

## Task Checklist

* Build a solution in [Visual Studio](https://docs.microsoft.com/en-us/visualstudio/ide/building-and-cleaning-projects-and-solutions-in-visual-studio?view=vs-2019). Make sure there are **no compiler errors and warnings**, fix these issues and rebuild the solution. 
* Run all unit tests with [Visual Studio](https://docs.microsoft.com/en-us/visualstudio/test/run-unit-tests-with-test-explorer?view=vs-2019) and make sure there are **no failed unit tests**. Fix your code to [make all tests GREEN](https://stackoverflow.com/questions/276813/what-is-red-green-testing). 
* Review all your changes in the codebase **before** [staging the changes and creating a commit](https://docs.microsoft.com/en-us/azure/devops/repos/git/commits?view=azure-devops&tabs=visual-studio). 
* [Stage your changes, create a commit](https://docs.microsoft.com/en-us/azure/devops/repos/git/commits?view=azure-devops&tabs=visual-studio), and publish your changes to the remote repository. 
