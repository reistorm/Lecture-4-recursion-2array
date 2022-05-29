string[,] table = new string[2, 5]; // таблица строк
// table[0,0] table[0,1] table[0,2] ... table[0,4]
// table[1,0] table[1,1] table [1,2] ... table[1,4]
// ...

// table[1, 2] = "слово"; // чтобы обратиться к нужному элементу, указываем наим массива
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"{table[rows, columns]}-");
//     }
// }

// Двумерный массив
// int[,] matrix = new int[3, 4];
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Для того, чтобы не вводить самому число строк, столбцов
// использовать i < matrix.GetLength(0), т.е.

// int[,] matrix1 = new int[3, 4];
// for (int i = 0; i < matrix1.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix1.GetLength(1); j++)
//     {
//         Console.Write($"{matrix1[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Опишем метод, который создаст массив и заполнит его

void PrintArray(int[,] matr) // аргумент - прмоуг.таблица чисел
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] matr = new int[3, 4];
PrintArray(matr);

// заполнение матрицы
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
