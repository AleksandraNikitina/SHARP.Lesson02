//  Задание 4: Удаление всех отрицательных чисел

//  Описание: Задайте массив целых чисел. Напишите программу, которая удаляет все
//  отрицательные числа из массива и возвращает новый массив, содержащий только
//  неотрицательные числа.

using System.Globalization;

int[] array = { 2, 5, 8, 3, -2, -7, -4, 0, -3, 2, 6, 46, -64 };
int countDigits = 0;

foreach (int num in array)
{
    if (num >= 0)
    {
        countDigits++;
    }
}

int[] result = new int[countDigits];
int j = 0;

for (int i= 0; i < array.Length; i++)
{
    if (array[i] >= 0)
    {
        result[j] = array[i];
        j++;
    }
}

Console.Write("[");
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}
Console.Write("]");