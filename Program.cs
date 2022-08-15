// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное само на себя)

Console.Clear();

Console.Write("Введите число ");
Int number = Convert.ToInt32(Console.ReadLine());

//int sqrt = number * number;
// or number *= number; 

Int sqrt1 = Convert.ToInt32(Math.Pow(number, 2));

Console.Write("Число в квадрате: " + sqrt1);

