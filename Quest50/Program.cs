// Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
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

Console.WriteLine("Введите искомое число: ");
int digit;
if (!int.TryParse(Console.ReadLine()!, out digit))
{
    Console.WriteLine("Неверный ввод");
    return;
}
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
ElementSearch(array);


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
            Console.Write(String.Format("{0,5}", input[i, k]));
        }
        Console.WriteLine();
    }
}
void ElementSearch(int[,] array)
{
    string pos = "Искомого числа в массиве нет";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            if (array[i, k] == digit)
            {
                pos = $"Индекс искомого элемента = ({i},{k})";
                break;
            }
        }
    }
    Console.WriteLine(pos);
}