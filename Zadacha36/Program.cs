//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
//[3, 7, 23, 12] -> 19  [-4, -6, 89, 6] -> 0

int[] Array = GetArray(4);
Console.WriteLine($"[{String.Join(",", Array)}]");
Console.WriteLine($"Сумма элементов на нечетных индексах равна {SumArray(Array)}");


int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-5, 20);
    }
    return res;
}

int SumArray(int[] Array2)
{
    int sum = 0;

   
    for (int i = 1; i < Array2.Length; i = i + 2)
    {

        sum = sum + Array2[i];
    }
    return sum;
}







