//По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер дня недели: ");
int daynumber = Convert.ToInt32(Console.ReadLine());
if (daynumber == 1)
{
    Console.WriteLine("это Понедельник");
}
if (daynumber == 2)
{
    Console.WriteLine("это Вторник");
}
if (daynumber == 3)
{
    Console.WriteLine("это Среда");
}
if (daynumber == 4)
{
    Console.WriteLine("это Четверг");
}
if (daynumber == 5)
{
    Console.WriteLine("это Пятница");
}
if (daynumber == 6)
{
    Console.WriteLine("это Суббота");
}
if (daynumber == 7)
{
    Console.WriteLine("это Воскресенье");
}