// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] array =new int[4,4];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i,j]= new Random().Next(30);
        Console.Write(array[i,j]+ "\t");
    }
    Console.WriteLine();
}

 void SumStringMatrix(int[,] matrix)
{
    int index = 0;
    int minsum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else
        if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    string line = string.Empty;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        line += matrix[index, j] + "\t"; 
        
    }
    Console.WriteLine($"Строка с минимальной суммой элементов равна {line}. ");
}

Console.WriteLine("--------------");
SumStringMatrix(array);
