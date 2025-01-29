My Calculator

This is a simple console-based calculator built using C#. The program allows the user to perform basic arithmetic operations such as Addition, Subtraction, Multiplication, and Division.
Features

    Addition: Adds two numbers.
    Subtraction: Subtracts the second number from the first.
    Multiplication: Multiplies two numbers.
    Division: Divides the first number by the second (with a check to prevent division by zero).

Getting Started
Prerequisites

To run this project, you will need to have the .NET SDK installed on your machine. You can download it from the official .NET website.
Installation

Navigate to the project directory:

cd my-calculator

Open the project in Visual Studio Code:

code .

Build and run the project using the following command in the terminal:

    dotnet run

Usage

    When you run the program, you will be presented with a menu of operations:

    [ 1 ] Addition
    [ 2 ] Subtraction
    [ 3 ] Multiplication
    [ 4 ] Division

    Choose an operation by entering the corresponding number (1, 2, 3, or 4).
    Enter two numbers when prompted.
    The program will display the result of the chosen operation.

Example Output

**_MY CALCULATOR_**
[ 1 ] Addition
[ 2 ] Subtraction
[ 3 ] Multiplication
[ 4 ] Division
Choose an operation: 1
Enter the first number: 10
Enter the second number: 5
Result: 15

Error Handling

    If the user tries to divide by zero, the program will show an error message: Error: Division by zero is not allowed.
    Invalid inputs will be handled by the program's logic to prevent crashes.
