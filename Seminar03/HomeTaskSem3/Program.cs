// Create an array of real numbers. 
// Find a difference between max & min elements of array.

double[] array = new double[] { 4.35, 6.84, 0.28, 1.57, 64.3, 7.35, 25.76 };
double min = array[0];
double max = array[0];

foreach (double num in array)
{
    if (num > max)
    {
        max = num;
    }
    else if (num < min)
    {
        min = num;
    }
}

Console.WriteLine(max-min);