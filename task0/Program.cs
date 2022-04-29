/*
Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
Например:
4 -> 16
-3 -> 9
-7 -> 49
*/
Console.WriteLine("Введите число: ");
string info = Console.ReadLine();

Console.WriteLine(info);

int number = Convert.ToInt32(Console.ReadLine());

int rusult = number * number ;

Console.WriteLine(rusult);