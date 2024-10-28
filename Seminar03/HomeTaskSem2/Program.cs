// Program counts even elements of array.

int[] array = new int[10] { 47, 25, 5, 97, 46, 7, 63, 1, 4, 83 };
int count = 0;

foreach (int num in array)
{
    if (num%2==0)
    {
        count++;
    }
}

Console.WriteLine(count);