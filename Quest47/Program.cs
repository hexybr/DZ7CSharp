// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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
float[,] array = new float[rows, columns];
FillArray(array);
PrintArray(array);

void FillArray(float[,] array)
{
 Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < columns; k++)
        {
            array[i, k] = rnd.Next();
        }
    }
}
void PrintArray(float[,] input)
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