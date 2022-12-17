// Zadacha36

Console.WriteLine("Введите размер массива:");
int length = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное число массива:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное число массива:");
int max = int.Parse(Console.ReadLine()!);

int[] array = new int[length];
int[] FillArray(int length, int min, int max)
{

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" " + array[i]);
    }
}
FillArray(length,min,max);
PrintArray();

int SumNegativeNumOfArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length ; i+= 2)
    {
        sum +=array[i]; 
    }
    return sum;
}

Console.WriteLine();
Console.WriteLine("Сумма нечетных элементов массива равна: " + SumNegativeNumOfArray(array));