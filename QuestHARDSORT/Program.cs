// Задайте двумерный массив из целых чисел. 
// Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
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
SortAndPrint(array);

void FillArray(int[,] array)
{

    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = rnd.Next(-100, 101);
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
void SortAndPrint(int[,] array)   // Сортировка пузырьком двумерного массива
{
    int[,] sorting = array;

    for (int k = 0; k < sorting.GetLength(0); k++)
    {
        for (int n = 0; n< sorting.GetLength(1); n++)
        {
            for (int i = 0; i < sorting.GetLength(0); i++)
            {
                for (int j = 0; j < sorting.GetLength(1); j++)
                {
                    if (sorting[k, n] < sorting[i, j])
                    {
                        int shift = sorting[k, n];
                        sorting[k, n] = sorting[i, j];
                        sorting[i, j] = shift;
                    }
                }
            }
        }
    }
    Console.WriteLine("Отсортированный массив:");
    for (int i = 0; i < sorting.GetLength(0); i++)
    {
        for (int k = 0; k < sorting.GetLength(1); k++)
        {
            Console.Write(sorting[i, k] + " ");
        }
        Console.WriteLine();
    }
}

