// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите количество строк");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[lines, columns];
FillArrayRandomNumbers(array);
Console.WriteLine();
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int t = 0; t < array.GetLength(1) - 1; t++)
        {
            if (array[i, t] < array[i, t + 1])
            {
                int temp = 0;
                temp = array[i, t];
                array[i, t] = array[i, t + 1];
                array[i, t + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
PrintArray(array);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
Console.WriteLine();
}