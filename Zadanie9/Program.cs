// Задание 9. Выяснить, кратно ли число заданному, если нет, вывести остаток.
double number = new Random().Next(2, 9);
Console.WriteLine("Введите двузначное число: ");
int entNumber = Convert.ToInt32(Console.ReadLine());
if (entNumber % number == 0)
{
    Console.Write("Дано число: ");
    Console.WriteLine(number);
    Console.Write("Введено число: ");
    Console.WriteLine(entNumber);
    Console.WriteLine("Введенное число кратно данному");
}
else if (entNumber % number != 0)
{
    Console.Write("Дано число: ");
    Console.WriteLine(number);
    Console.Write("Введено число: ");
    Console.WriteLine(entNumber);
    Console.Write("Введенное число не кратно данному, остаток от деления составляет: ");
    Console.WriteLine(entNumber % number);
}