// Показать двумерный массив размером m*n, заполненный целыми числами
Console.Write("Enter your number of rows: ");
int m=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter your number of columns: ");
int n=int.Parse(Console.ReadLine()??"0");
int[,]matr=new int[m,n];
for (int i=0;i<m;i++)
{
    for (int j=0;j<n;j++)
    {
        matr[i,j]=new Random().Next(1,10);
        Console.Write($"{matr[i,j]} ");
    }
Console.WriteLine();
}

