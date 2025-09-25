using System;

Console.WriteLine("Calculator Program:");

Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {(double)num1 / num2}");


// hi im trying to learn ways to write c# without overhead of a project file
// I did some research and found out about donet-script
// you can install dotnet script by running: dotnet tool install -g dotnet-script
// then you can execute a file like this one by running: dotnet script Calculator.cs



