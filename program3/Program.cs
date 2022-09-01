// Является ли число чётным?
{ 
    Console.WriteLine("Введите число");
    int numberN;
    Console.WriteLine("Введите число -");
    numberN = Convert.ToInt32(Console.ReadLine());
    
  if (numberN % 2==0)
{
Console.WriteLine($"Число четное {numberN}");
}
else
{
Console.WriteLine($"Число не является четным {numberN}");
}}
