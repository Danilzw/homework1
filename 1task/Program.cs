//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


System.Console.Write("Введите первое число:");
int firstnumber = int.Parse(Console.ReadLine());

System.Console.Write("Введите второе число:");
int secondnumber = int.Parse(Console.ReadLine());

int max = firstnumber;

if(firstnumber > secondnumber)
{
    System.Console.WriteLine(firstnumber + " Большее число");
}
else
{
    System.Console.WriteLine(secondnumber + " Большее число");
}
