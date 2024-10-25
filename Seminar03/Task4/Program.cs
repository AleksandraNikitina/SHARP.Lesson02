// Program takes as input a number.
// Create the array from digits of this number.
// The zero element of array is the third digit of number 
// and the first element of array is the second digit of number.
// Example:
// 456 => [6 5 4]
// 781 => [1 8 7]

Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

int numCopy = num;
int countDigits = 0;

while (numCopy != 0)        //Counts digits of number
{
    countDigits++;
    numCopy /= 10;
}

int[] array = new int[countDigits];    //Create array for digits as a result

for (int i = 0; i < array.Length; i++)  //Fill array
{
    array[i] = num % 10;
    num /= 10;
}

Console.Write("[");
for (int i = 0; i < array.Length; i++)     //Output
{
    Console.Write(array[i] + " ");
}
Console.Write("]");