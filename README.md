# Custom List Implementation in C#

# Table of Contents

1. [Project Overview](#project-overview)
2. [Key Features](#key-features)
3. [Technologies Used](#technologies-used)
4. [Installation](#installation)
5. [Running Tests](#running-tests)
6. [Project Structure](#project-structure)
    - [`CustomList` Directory](#customlist-directory)
    - [`CustomListTests` Directory](#customlisttests-directory)
7. [Improvements and Optimizations](#improvements-and-optimizations)
    - [Overview](#overview)
    - [Key Enhancements](#key-enhancements)
    - [Detailed Comparison](#detailed-comparison)
8. [Future Work](#future-work)
9. [Challenges and Lessons Learned](#challenges-and-lessons-learned)
10. [Contributing](#contributing)

## Project Overview

This project introduces a custom list implementation in C#, developed with a focus on Test-Driven Development (TDD) and thorough unit testing. Each primary method, including add, remove, and ToString, as well as custom operator overloads for addition and subtraction, is accompanied by a comprehensive set of tests to ensure reliability and performance.

## Key Features

-   **Custom Add and Remove**: Enhanced add and remove methods with optimized performance for dynamic lists.
-   **Operator Overloads**: Custom implementation of `+` and `-` operators for intuitive list manipulation.
-   **Dynamic Capacity Management**: Automatic resizing of the internal array to accommodate growing elements, ensuring efficient memory usage.
-   **ToString Implementation**: Custom method to return a string representation of the list contents.
-   **Extensive Unit Tests**: Rigorous testing for each functionality, ensuring robustness and reliability.

## Technologies Used

-   C#
-   .NET Framework
-   MSTest for unit testing

## Installation

This project requires the [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine. Clone this repository and navigate to the project's directory.

```bash
git clone [repository-url]
cd [project-directory]
```

## Running Tests

To run the unit tests and verify the functionality, use the following command in the terminal at the project's root directory:

```bash
dotnet test
```

## Project Structure

The project is structured into two main parts: the library implementation and the associated unit tests:

### `CustomList` Directory

-   `CustomList.cs`: The core class implementing the custom list data structure with methods for adding and removing items, as well as operator overloads.
-   `MinusOperatorOverloadDocumentation.txt`: Documentation providing details on the implementation and use cases of the minus operator overload.
-   `BeforeAfterComparisonDocumentation.txt`: Documentation providing details on changes to the CustomList class.

### `CustomListTests` Directory

-   `AddMethodTests.cs`: Unit tests for the `Add` method in the `CustomList` class.
-   `MinusOperatorOverloadTests.cs`: Unit tests for the minus (`-`) operator overload functionality.
-   `PlusOperatorOverloadTests.cs`: Unit tests for the plus (`+`) operator overload functionality.
-   `RemoveMethodTests.cs`: Unit tests for the `Remove` method.
-   `ToStringMethodTests.cs`: Unit tests for the `ToString` method's correct behavior.
-   `Usings.cs`: Shared namespaces used across multiple test classes to simplify test code.

Each file is named according to the method or functionality it is testing, ensuring that unit tests are easy to locate and maintain.

## Improvements and Optimizations

### Overview

After a year of gaining more experience and insights, I revisited this Custom List project to enhance its performance, usability, and code readability. This iterative approach reflects the evolving nature of software development and my commitment to refining work over time.

## Improvements and Optimizations

### Key Enhancements

-   **Type Constraint Integration**: The `CustomList<T>` class now requires elements to implement the `IComparable<T>` interface, enhancing the list's ability to handle sorted data and paving the way for future sorting functionalities.
-   **Performance Optimization**: Significant optimizations were made to internal operations, particularly in the `Add` and `Remove` methods, to enhance execution efficiency and memory management. The `Remove` method, for example, has been optimized to shift items within the existing array, reducing memory allocations and improving overall performance.
-   **Code Readability**: The codebase has undergone comprehensive refactoring to improve readability and maintainability. Changes include clearer method naming, the use of string interpolation for easier string handling, and encapsulating complex logic within helper methods.

### Detailed Comparison

For a detailed before-and-after comparison of these improvements, please refer to the [BeforeAfterComparisonDocumentation.txt](./CustomList/BeforeAfterComparisonDocumentation.txt) document located in the `CustomList` directory. This comparison not only showcases the specific enhancements but also serves as an educational resource for understanding the impact of these optimizations on C# development.

## Future Work

-   **Expand Functionality**: Explore additional functionalities that could be integrated into the CustomList class, such as sorting and searching algorithms.
-   **Performance Benchmarking**: Conduct thorough performance benchmarking against native .NET collections to identify areas for further optimization.
-   **Cross-Platform Compatibility**: Ensure the CustomList implementation is fully compatible with different .NET runtimes, including .NET Core and .NET Framework.

## Challenges and Lessons Learned

-   **TDD Approach**: Adopting a Test-Driven Development approach was instrumental in ensuring each functionality was correctly implemented and robust from the outset.
-   **Operator Overloads**: Implementing and testing operator overloads was a challenging yet rewarding process that deepened my understanding of C# language features.
-   **Capacity Management**: Ensuring efficient dynamic capacity management required careful consideration and testing to balance memory usage and performance.

## Contributing

Contributions to this project are welcome. Please follow these steps to contribute:

1. Fork the repository.
2. Create a new branch for your feature or fix.
3. Commit your changes.
4. Push your branch and submit a pull request.
