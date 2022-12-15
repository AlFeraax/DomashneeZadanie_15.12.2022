// Задание 5. Показать последнюю цифру трёхзначного числа.
int number = new Random().Next(100, 999);
int lastDigit = (number % 10);
Console.Write("Дано число: ");
Console.WriteLine(number);
Console.Write("Его крайняя цифра равна: ");
Console.WriteLine(lastDigit);