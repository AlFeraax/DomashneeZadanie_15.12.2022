// Задача 1. По двум заданным числам проверять является ли первое квадратом второго
int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);
if (b * b != a)
{
    Console.Write(a);
    Console.WriteLine(" не является квадратом ");
    Console.Write(b);
}
else if (b * b == a)
{
    Console.Write(a);
    Console.WriteLine(" является квадратом ");
    Console.Write(b);
}