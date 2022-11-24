/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int summa (string arg)
{
    int result =0;
    for (int i=0; i<arg.Length; i++)
        result = result + int.Parse(arg.Substring (i,1));
    return result;
}

Console.WriteLine("введите число");
string  str =  Console.ReadLine();
Console.WriteLine(summa(str));
