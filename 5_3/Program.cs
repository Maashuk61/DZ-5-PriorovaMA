// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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
    int result1 = 0;
    for (int j = 0; j < array.Length; j++)
    {
        int result = array[j];
        if (j % 2 > 0) result1 = result1 + result;
    }
    Console.WriteLine(result1);
}

int [] massive = RandomArray(10, -10, 20);
Console.WriteLine(string.Join(", ", massive));
CountArray(massive);