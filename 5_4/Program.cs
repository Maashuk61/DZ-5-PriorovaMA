// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int [] arr = {14, 25, 41, 99, 13, 25, 6, 8};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int DifferenceMaxMin(int[] array)
{
    int min = array[0];
    int max = array[0];

    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= min)
            {
                min = array[i];
            } 
            else
            {
                if (max < array[i])
                {
                  max = array[i];
                }
            }            
        }
    int result = max - min;
    return result;
}

PrintArray(arr);
int res = DifferenceMaxMin(arr);
Console.WriteLine(res);