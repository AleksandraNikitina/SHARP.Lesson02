// Program returns array with elements of other array that is in range [10,90].

using System.Globalization;

int[] array = new int[10] { 47, 25, 5, 97, 46, 7, 63, 1, 4, 83 };
int countElements = 0;

foreach (int num in array)
{
    if (num > 10 && num < 90)
    {
        countElements++;
    }
}

int[] result = new int[countElements];
int j = 0;
foreach (int num in array)
{
    if (num > 10 && num < 90)
    {
        result[j] = num;
        j++;
    }
}

Console.Write("[");
foreach(int num in result)
{
    Console.Write($"{num} ");
}
Console.Write("]");