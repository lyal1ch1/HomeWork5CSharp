// Zadacha34

Console.WriteLine("Введите размер массива:");
int num = int.Parse(Console.ReadLine()!);
int[] array = new int[num];
int[] FillArray(int num)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int PositiveNumOfArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}

FillArray(num);
PrintArray();
Console.WriteLine();
Console.WriteLine("В данном массиве " +  PositiveNumOfArray(array) + " четных чисел");
