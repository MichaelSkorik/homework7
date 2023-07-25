
int rows = 3; // Количество строк
int cols = 4; // Количество столбцов

// Создайте генератор случайных чисел
Random random = new Random();

// Создайте и заполните случайными числами двумерный массив
int[,] array = new int[rows, cols];
for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        array[row, col] = random.Next(1, 10); // Генерируем случайное целое число от 1 до 9
    }
}

// Выведите созданный массив
Console.WriteLine("Случайный двумерный массив:");
PrintArray(array);

// Создайте массив для хранения средних значений каждого столбца
double[] columnAverages = new double[cols];

// Найдите сумму элементов в каждом столбце
for (int col = 0; col < cols; col++)
{
    double sum = 0;
    for (int row = 0; row < rows; row++)
    {
        sum += array[row, col];
    }
    // Найдите среднее арифметическое и сохраните его в массив
    columnAverages[col] = sum / rows;
}

// Выведите среднее арифметическое каждого столбца
Console.WriteLine("\nСреднее арифметическое каждого столбца:");
for (int col = 0; col < cols; col++)
{
    Console.Write(columnAverages[col].ToString("0.0") + "; ");
}


    // Метод для вывода массива на экран
    static void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write(array[row, col] + " ");
        }
        Console.WriteLine();
    }
}