
int[] array = new int[10] {-3, 5, 2, 0, -7, 6, 9, 10, 3, -2};

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1; // array[i] = -1 * array[i];
    Console.Write(array[i] + " ");
}
