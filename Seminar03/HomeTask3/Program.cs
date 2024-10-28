// Задание 3: Поиск среднего значения массива

//  Описание: Задайте массив из 10 целых чисел. Найдите среднее значение элементов
//  массива.

int[] array = new int[10] { 2, -5, 0, 3, 7, -1, 0, -34, -4, 99 };
int sum = 0;

foreach (int num in array)
{
    sum = sum + num;
}
int average = sum / array.Length;

Console.WriteLine(average);
