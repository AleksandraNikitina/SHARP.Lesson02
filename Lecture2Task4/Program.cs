int n = 5;
int[] array = { 2, -14, 7, 9, 9 };
int i = 0;
int max = array[0];

while(i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i+1;
}
Console.WriteLine(max);
