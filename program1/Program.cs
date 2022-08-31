// Нахождение большего и меньшего из двух чисел
{ 
    Console.WriteLine("Введите 2 числа");
    int number, numberTwo;
    Console.WriteLine("Введите первое число -");
    number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число -");
    numberTwo = Convert.ToInt32(Console.ReadLine());

    bool suppose0 = number > numberTwo;
    bool suppose1 = number == numberTwo;
    bool suppose2 = number < numberTwo;

  if (suppose0)
{
Console.WriteLine($"Число {number} больше чем {numberTwo}");
}
else if (suppose1)
{
Console.WriteLine($"Числа {number} и {numberTwo} равны");
}
else
{
Console.WriteLine($"Число {numberTwo} больше чем {number}");
}}