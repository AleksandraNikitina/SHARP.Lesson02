// Output array of digits of number.

using System.Globalization;

int num = 4;
int countDigits = 0;

int numCopy = num;
while (numCopy > 0)
{
    countDigits++;
    numCopy /= 10; // num = num/10;
}
// Console.WriteLine(countDigits);

int[] digits = new int[countDigits];

for (int i = countDigits - 1; i >= 0; i--)
{
    digits[i] = num % 10;
    num /= 10;
}

Console.Write("[");
foreach (int e in digits)
{
    Console.Write($"{e} ");
}
Console.Write("]");