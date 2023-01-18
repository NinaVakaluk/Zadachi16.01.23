//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] Array = GetArray(5);
Console.WriteLine($"[{String.Join(",", Array)}]");

Console.WriteLine($"Количество четных чисел равно {Quantity(Array)}");


int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);

    }
    return res;
}

int Quantity(int[] Chet)
{
    int count = 0;

    foreach (int el in Chet)
    {
        if (el % 2 == 0)
        {
            count++;
        }
    }
    return count;
}