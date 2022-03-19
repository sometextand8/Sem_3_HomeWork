// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


void palindrom(string input)    // Метод принимает строку из числовых значений.
{
    int len = input.Length;
    int maxvalue = 5;
    

    if (len < maxvalue)
    {
        Console.WriteLine("Вы ввели не пятизначное значение");
    }

    else
    {
        for (int i = 0; i < len; ++i)
        {
            if (char.IsDigit(input[i]) == true)
            {

                for (int j = 0; j < len/2; ++j)
                {
                    
                    if (input[j] == input[len - j - 1])
                    {
                        Console.WriteLine("Палиндром");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Не палиндром");
                        break;
                    }
                }
                break;
            }

            else
            {
                Console.WriteLine("Вы ввели не число, повторите попытку");
                break;
            }
    }   }
}


palindrom("123321");




void fillarray(int[] collection)                        //Добавляет в массив случайные числа от 1 до 10
{
    int len = collection.Length;
    int pos = 0;

    while (pos < len)
    {
        collection[pos] = new Random().Next(1, 10);
        pos++;
    }
}


void printarray(int[] collection)                       //Печатает массив
{
    int len = collection.Length;
    int pos = 0;

    while (pos < len)
    {
        Console.Write($"{collection[pos]}");
        pos++;
    }
}

int[] array = new int[5]; 

fillarray(array);
printarray(array);
Console.WriteLine();

int len = array.Length;


for (int i = 0; i < len/2; i++)
{
    if (array[i] == array[len - i - 1])
    {
        Console.WriteLine("палиндром");
    }
    else
    {
        Console.WriteLine("не палиндром");
    }
    break;
}