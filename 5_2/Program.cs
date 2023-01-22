// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
int[] RandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for(int i = 0; i <array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

void CountArray(int[] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array [j] >= 10 && array [j] <=99)  count = count + 1;
    }
    Console.WriteLine(count);
}

int [] massive = RandomArray(123, 0, 150);
Console.WriteLine(string.Join(", ", massive));
CountArray(massive);