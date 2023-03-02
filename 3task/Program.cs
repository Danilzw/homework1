// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

System.Console.Write("Введите ваше число:");
int number = int.Parse(Console.ReadLine());

if(number % 2 == 0)
{
    System.Console.WriteLine("Ваше число четное!");
}
else
{
    System.Console.WriteLine("Ваше число не четное!");
}