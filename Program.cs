// See https://aka.ms/new-console-template for more information
Console.Write("Input 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2nd number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int square = num2 * num2;
// можно удалить строку int square = num2... и внизу прописать 
// if (num1 == num2 * num2)
if (num1 == square)
{
    Console.Write("First number is a square of 2nd number");
}
else
{
    Console.Write("First number is not a square of second number");
}