// Задание 7. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите двузначное число от 10 до 99");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = (number % 10);
int firstDigit = (number / 10);
if (firstDigit > secondDigit)
{
    Console.Write("Наибольшее из двух чисел равно: ");
    Console.WriteLine(firstDigit);
}
else if (firstDigit < secondDigit)
{
    Console.Write("Наибольшее из двух чисел равно: ");
    Console.WriteLine(secondDigit);
}