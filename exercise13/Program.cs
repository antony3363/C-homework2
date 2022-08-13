//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

System.Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);

if(a < 100)
    {
        System.Console.WriteLine("третьей цифры нет");
    }
else
{
    
    if (a % 100 < 10)
    {
        System.Console.WriteLine(a);
    }
    else
    {
    while (a > 999)
        {
            a = a / 10;
            
        } 
        a = a % 10; 
        System.Console.WriteLine(a);
    }    
}











