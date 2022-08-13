//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

System.Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
if (a == 6 ^ a == 7)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}
