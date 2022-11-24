/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int pw (int a, int b)
{
    int result = a;
    for (int i=1; i<b; i++)
        result = result*a;
    return result;
}

Console.WriteLine("Ведите число 1");
int x=int.Parse(Console.ReadLine());
Console.WriteLine("Ведите число 2");
int y=int.Parse(Console.ReadLine());
Console.WriteLine(pw(x,y));