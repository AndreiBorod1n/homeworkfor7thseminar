// 52. Задайте двумерный массив из целых чисел. 
//     Найдите среднее арифметическое элементов в каждом столбце.
int[,] matrix = new int[3,4];
void FillArray(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }
    }
}
void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i,j]} ");
    }
    Console.WriteLine();
}
}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("Среднее арифметическое цифр в строке равно:");
double sum = 0;
double diffsum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
{
    sum = sum + matrix[i,j];
    diffsum = sum / matrix.GetLength(1);
    if(j == 3)
    {
        Console.Write($"{diffsum} ");
        sum = 0;
        diffsum = 0;
    }
}
}


