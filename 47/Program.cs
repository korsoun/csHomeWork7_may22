// Задача 47.
// Задать двумерный массив. заполненныйслучайными вещественными числами.

double [,] FillArray (double[,] array)    // Метод для заполнения массива
{
    Random prevValues = new Random();
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            double floatValue = prevValues.NextDouble() * 10;                   // С целой частью не более 10, с двумя знаками после запятой 
            string formatingFloatVal = string.Format("{0:f2}", floatValue);
            array[i, j] = Convert.ToDouble(formatingFloatVal);
        }
    }
    return array;
}

void ArrayOutput (double[,] array)            // Метод по выводу массива в консоль
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] newArray = new double[m, n];

FillArray(newArray);
ArrayOutput(newArray);