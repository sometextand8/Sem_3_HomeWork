// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


void kubN(int number)
{
    int ind = 1;


    while (number+1 > ind)
    {
        double answer = Math.Pow(ind, 3);
        Console.Write($"{answer} ");
        ind++;
    }
}


kubN(5);