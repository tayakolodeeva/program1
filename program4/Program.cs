// Все четные от 1 до N
{ 
    Console.WriteLine("Введите число");
    int numberN;
    Console.WriteLine("Введите число -");
    numberN = Convert.ToInt32(Console.ReadLine());
    for (int i=1; i < numberN; i++) 
 {
    if (i % 2 == 0) 
{
    Console.Write(i + " ");
}
}
Console.ReadKey();
}

