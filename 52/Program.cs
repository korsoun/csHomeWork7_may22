// Задача 52.
// Задать массив и найти среднее арифметическое каждого столбца.

void FillArray (int[,] array)    // Метод для заполнения массива
{
    Random arrayValues = new Random();
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = arrayValues.Next(-10, 11);
        }
    }
    
}

void ArrayOutput (int[,] array)            // Метод по выводу массива в консоль
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0, 5}", array[i, j]);
        }
        Console.WriteLine();
    }
}

void GetColumnsAverage (int[,] array)     // Метод по нахождению среднего в столбцах
{
    Console.WriteLine("Средние значения каждого столбца: ");
    for(int j = 0; j < array.GetLength(1); j++)             // Прохождение строк и столбцов иное, чем раньше. Берем столбец и обрабатываем каждое значение в его строчках.
    {
        double columnSum = 0;        // Сумма значений в столбце.
        for(int i = 0; i < array.GetLength(0); i++)
        {
            columnSum += array[i, j];  // Собираем значения в сумму.
        }
        string columnAverage = string.Format("{0:f2}", (columnSum / array.GetLength(0)));   // Делим на количество строк. Результат переводим в строку для форматирования.
        Console.WriteLine($"{j + 1}-го {columnAverage};"); // Вывод строки с результатами.
    }
}

Console.Write("Введите через пробел количество строк и столбцов:  ");    
int[] arrayDimentions = Console.ReadLine().Split().Select(int.Parse).ToArray(); // Получение размерности массива. 
int[,] newArray = new int[arrayDimentions[0], arrayDimentions[1]];   // Объявление заданного массива.

FillArray(newArray);    // Заполнить массив.
ArrayOutput(newArray);  // Вывести в консоль.
GetColumnsAverage(newArray); // Найти средние в столбцах.