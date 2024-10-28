// Задание 1: Поиск элемента в массиве

//  Описание: Задайте массив целых чисел. Напишите программу, которая проверяет,
//  присутствует ли заданное число в массиве. Программа должна вывести:
//  Присутствует/Не присутствует.

// Method 1:

// int[] array = {5, 3, 9, 2, 4, 0, -4, 2, -6};
// int num = 5;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == num)
//     {
//         Console.WriteLine("Exist");
//         break;
//     }
//     else if (i == array.Length-1)
//     {
//         Console.WriteLine("Not exist");
//     }
// }



// Method 2:

int[] array = {5, 3, 9, 2, 4, 0, -4, 2, -6};
int num = 1;

bool isExistNum = false;
// string result = isExistNum ? "Exist." : "Not exist.";

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num)
    {
        isExistNum = true;
        break;
    }    
}
Console.WriteLine(isExistNum ? "Exist." : "Not exist.");
