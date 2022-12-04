// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк:");
int rows;
if (!int.TryParse(Console.ReadLine()!, out rows))
{
    Console.WriteLine("Неверный ввод");
    return;
}

Console.WriteLine("Введите количество столбцов:");
int columns;
if (!int.TryParse(Console.ReadLine()!, out columns))
{
    Console.WriteLine("Неверный ввод");
    return;
}
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
AverageColumns(array);

void FillArray(int[,] array)
{

    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = rnd.Next(0, 10);
        }
    }
}
void PrintArray(int[,] input)
{
    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int k = 0; k < input.GetLength(1); k++)
        {
            Console.Write(input[i, k] + " ");
        }
        Console.WriteLine();
    }
}
void AverageColumns(int[,] array)
{
    float[] secondArray = new float[columns];

    for (int k = 0; k < secondArray.Length;)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            float average = 0;
            float sum = 0;
            for (int j = 0; j < array.GetLength(0); j++)
            {
                sum += array[j, i];
            }
             average = sum / rows;
             secondArray[k] = average;
             Console.WriteLine($"Среднее арифметическое столбца {k} = {secondArray[k]}");
             k++;
        } 
    }
}