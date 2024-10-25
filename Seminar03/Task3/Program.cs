// Program prodacts of the first and the last elements, 
// the second and the penultimate elements and so on. 
// // Show result as a new array.
// Example:
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (7 has no pair)

int[] array = {1, 3, 0, 2, 7, -5, 4, 2, 3};
int[] arrResult = new int[array.Length/2];

// for (int i = 0; i < array.Length/2; i++)
// {
//     arrResult[i] = array[i] * array[array.Length-1-i];
// }

// for (int i = 0; i < arrResult.Length; i++)
// {
//     Console.Write(arrResult[i] + " ");
// }


int left = 0;
int right = array.Length - 1;

while (left < right)
{
    arrResult[left] = array[left] * array[right];
    left++;
    right--;
}
for (int i = 0; i < arrResult.Length; i++)
{
    Console.Write(arrResult[i] + " ");
}