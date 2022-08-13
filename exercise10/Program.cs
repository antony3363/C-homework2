//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

System.Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);

a = a / 10;
a = a % 10;
System.Console.WriteLine(a);




