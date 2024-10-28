// The program shows whether a certain number is in an array. 
// The output should be "yes" or "no".
// [1 3 4 19 3]

// int[] array1 = new int[5];
// int[] array2 = new int[5] {1, 3, 4, 19, 3};
// int[] array3 = new int[] {1, 3, 4, 19, 3};

int[] array = { 8, 3, 8, 19, 9 };
int num = 8;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == num)
//     {
//         Console.WriteLine("Yes");
//         i = array.Length;
//     }
//     if (i == array.Length-1)
//     {
//         Console.WriteLine("No");
//     }
// }

bool isExistNum = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num)
    {
        isExistNum = true;
        break;
    }
}

// Console.WriteLine(isExistNum);

// string result = isExistNum ? "Yes" : "No";
// Console.WriteLine(result);
Console.WriteLine(isExistNum ? "Yes" : "No");