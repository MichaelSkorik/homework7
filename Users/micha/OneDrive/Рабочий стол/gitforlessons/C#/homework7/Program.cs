
int rows = 3;
int cols = 4;
int[,] array = GenerateRandomArray(rows, cols);

Console.WriteLine("Сгенерированный массив:");
PrintArray(array);

int row, col;
Console.Write("Введите номер строки: ");
if (int.TryParse(Console.ReadLine(), out row) && row >= 1 && row <= rows)
{
    Console.Write("Введите номер столбца: ");
    if (int.TryParse(Console.ReadLine(), out col) && col >= 1 && col <= cols)
    {
        // Скорректируем введенные значения для доступа к массиву
        row -= 1;
        col -= 1;

        int? element = GetElementAtPosition(array, row, col);

        if (element.HasValue)
        {
            Console.WriteLine($"Значение элемента на позиции ({row + 1}, {col + 1}): {element.Value}");
        }
        else
        {
            Console.WriteLine($"Такого элемента в массиве нет.");
        }
    }
    else
    {
        Console.WriteLine("Некорректный номер столбца.");
    }
}
else
{
    Console.WriteLine("Некорректный номер строки.");
}

    static int[,] GenerateRandomArray(int rows, int cols)
{
    Random random = new Random();
    int[,] array = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = random.Next(1, 100); // Здесь можно настроить диапазон случайных чисел.
        }
    }

    return array;
}

static int? GetElementAtPosition(int[,] array, int row, int col)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    if (row >= 0 && row < rows && col >= 0 && col < cols)
    {
        return array[row, col];
    }
    else
    {
        return null; // Возвращаем null, если такого элемента нет.
    }
}

static void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}