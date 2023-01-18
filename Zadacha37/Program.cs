//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3  [6 7 3 6] -> 36 21

int[] Array = GetArray(6);
Console.WriteLine($"[{String.Join(",", Array)}]");
Console.WriteLine($"[{String.Join(",", ProizArray(Array))}]");

int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(1, 20);
    }
    return res;

}


int[] ProizArray(int[] Array1)
{


    int N = Array1.Length;
    int[] Array2 = new int[N / 2];
   
    for (int i = 0; i < N / 2; i++)
    {
        Array2[i] = Array1[i] * Array1[N - 1 - i];
    }
    return Array2;
}
