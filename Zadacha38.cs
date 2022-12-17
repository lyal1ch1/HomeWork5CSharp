// Zadacha36

Console.WriteLine("Введите размер массива:");
int length = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное число массива:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное число массива:");
int max = int.Parse(Console.ReadLine()!);

double[] array = new double[length];
double[] FillArray(int length, int min, int max)
{

    for (int i = 0; i < length; i++)
    {
       double doublePart =new Random().NextDouble() ;
       double number = doublePart*(max-min) + min;
       number = Math.Round(number, 2);
       array[i] = number; 


    }
    return array;
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("  " + array[i]);
    }
}
FillArray(length,min,max);
PrintArray();

double MaxValueOfArray(double[] array)
{
    double max = array[0]; 
    for (int i = 0; i < array.Length; i++)
    {
     if (array[i] > max )
     {
        max = array[i];
     }   
    }
    return max;
}
double MinValueOfArray(double[] array)
{
    double min = array[0]; 
    for (int i = 0; i < array.Length; i++)
    {
     if (min > array[i] )
     {
        min = array[i];
     }   
    }
    return min;
}
Console.WriteLine();
Console.WriteLine(MaxValueOfArray(array));
Console.WriteLine(MinValueOfArray(array));
double result = Math.Round((MaxValueOfArray(array) - MinValueOfArray(array)),2);
Console.WriteLine("Разница между максимальным и минимальным элементом массива равен: " + result);