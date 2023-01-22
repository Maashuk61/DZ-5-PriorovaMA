// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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
        if (array [j] % 2 == 0)  count = count + 1;
    }
    Console.WriteLine(count);
}

int [] massive = RandomArray(10, 100, 999);
Console.WriteLine(string.Join(", ", massive));
CountArray(massive);
