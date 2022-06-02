// В двумерном массиве показать позицию числа, заданного пользователем
// или указать, что такого элемента нет
void PrintMatrix (int[,]matr)
{
    for (int i=0;i<matr.GetLength(0);i++)
    {
        for (int j=0;j<matr.GetLength(1);j++)
            Console.Write($"{matr[i,j]} ");
        Console.WriteLine();
    }
}
    
int [,] FillMatrix (int rows, int columns, int minValue, int maxValue)
{
    int[,]matrix=new int[rows,columns];
    var Random=new Random();
    for (int i=0;i<rows;i++)
        for (int j=0;j<columns;j++)
            matrix[i,j]=new Random().Next(minValue,maxValue);
    return matrix;
}

(int,int)? IndexOf(int[,]matrix,int value)
{
    for (int i=0;i<matrix.GetLength(0);i++)
        for (int j=0;j<matrix.GetLength(1);j++)
            if (matrix[i,j]==value)
               return (i,j);                                 
    return null;              
}

Console.Clear();
Console.Write("Enter amount of matrix rows: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of matrix columns: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter left side of matrix elements: ");
int start = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter right side of matrix elements: ");
int finish = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = FillMatrix(rows,columns,start,finish);
Console.WriteLine();
Console.WriteLine("Your matrix:");
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
Console.Write("Enter value to find in matrix: ");
int value = int.Parse(Console.ReadLine() ?? "0");
(int,int)? position = IndexOf(matrix,value);
if(position==null)
    Console.WriteLine("There is no value in matrix");
else
    Console.WriteLine($"Position of element: {position.Value.Item1} {position.Value.Item2}");
