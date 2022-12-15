// задача 4. Выяснить является ли число чётным
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Это число четное.");
}
else if (number % 2 != 0)
{
    Console.WriteLine("Это число не четное.");
}