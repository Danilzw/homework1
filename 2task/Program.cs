// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.Write("Введите первое число:");
int firstnumber = int.Parse(Console.ReadLine());

System.Console.Write("Введите второе число:");
int secondnumber = int.Parse(Console.ReadLine());

System.Console.Write("Введите третье число:");
int thirdnumber = int.Parse(Console.ReadLine());

int max = firstnumber;

if(max < firstnumber)
{
    max = firstnumber;
}
if(max < secondnumber)
{
    max = secondnumber;
}
if(max< thirdnumber)
{
    max = thirdnumber;
}

System.Console.WriteLine(max + " Максимальное число");