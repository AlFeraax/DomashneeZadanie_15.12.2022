// Задание 3. Найти максимальное из трех чисел
int a = new Random().Next(0, 50);
int b = new Random().Next(0, 50);
int c = new Random().Next(0, 50);
int max = a;
if (b > a)
    max = b;
if (c > b)
    max = c;
if (c > a)
    max = c;

Console.Write("Дано число ");
Console.WriteLine(a);
Console.Write("Дано число ");
Console.WriteLine(b);
Console.Write("Дано число ");
Console.WriteLine(c);
Console.Write(max);
Console.WriteLine(" это наибольшее число");