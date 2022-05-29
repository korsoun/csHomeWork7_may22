// Задача 50.
// Принять позиции элемента и вывести этот элемент или написать, что такого нет.

int [,] FillArray (int[,] array)    // Метод для заполнения массива
{
    Random arrayValues = new Random();
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = arrayValues.Next(-10, 11);
        }
    }
    return array;
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

void GetSearchResult (int[,] array)              // Метод для поиска элемента по его позиции
{
    Console.Write("Введите через пробел позицию элемента (строка столбец):  ");
    int[] coordinateArray = Console.ReadLine().Split().Select(int.Parse).ToArray();              // Получение позиции элемента 
    if(coordinateArray[0] > array.GetLength(0) || coordinateArray[1] > array.GetLength(1))       // Если одна из введенных позиций больше размерности массива, вывод сообщения
    {
        Console.WriteLine("Элемента с такой позицией нет. ");
    }
    else                           // Если позиция присутствует в массиве, вывести ее. Позиция считается в удобном виде для пользователя. Т.е. позиция первой строки не 0, а 1.
    {
Console.WriteLine($"Элемент в позиции {coordinateArray[0]}-я строка, {coordinateArray[1]}-й столбец - это {array[coordinateArray[0] - 1, coordinateArray[1] - 1]}.");
    }
}

int[,] newArray = new int[10, 10];
FillArray(newArray);
ArrayOutput(newArray);
GetSearchResult(newArray);