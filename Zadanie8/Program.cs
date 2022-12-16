// Задание 8. Удалить вторую цифру трёхзначного числа
int number = new Random().Next(100, 999);
int lastTwoDigits = (number % 100);
int middleDigit = (lastTwoDigits / 10);
if (lastTwoDigits <= 99)
{
    Console.Write("Дано число: ");
    Console.WriteLine(number);
    Console.Write("Его среднеяя цифра это: ");
    Console.WriteLine(middleDigit);
    int anotherDigit = ((number - lastTwoDigits) / 10) + (number % 10);
    Console.Write("Убирая среднюю цифру мы получаем число: ");
    Console.WriteLine(anotherDigit);
}