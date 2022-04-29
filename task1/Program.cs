/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 5; b = 25 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> нет
a = -3 b = 9 -> да
*/

Console.WriteLine("Введите два числа: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
int SecondNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber * FirstNumber == SecondNumber)
{
    Console.WriteLine("Число явлется квадратным корнем");
}
else
{
    Console.WriteLine("Число не является квадратным корнем");
}