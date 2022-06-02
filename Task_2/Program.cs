// В двумерном массиве n*k заменить четные элементы на противоположные
void PrintArray (int[,] matr)
{
for (int i=0;i<matr.GetLength(0);i++)
{
    for (int j=0;j<matr.GetLength(1);j++)
    {
        Console.Write($"{matr[i,j]} ");
    }
Console.WriteLine();
}
}
    
void FillArray (int[,] matr)
{
for (int i=0;i<matr.GetLength(0);i++)
{
    for (int j=0;j<matr.GetLength(1);j++)
    {
        matr[i,j]=new Random().Next(1,10);
    }
}
}

void EvenToNeg (int[,] matr)
{
for (int i=0;i<matr.GetLength(0);i++)
{
    for (int j=0;j<matr.GetLength(1);j++)
    {
        if (matr[i,j]%2==0) matr[i,j]=-matr[i,j];
    }
}
}


Console.Write("Enter your number of rows: ");
int n=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter your number of columns: ");
int k=int.Parse(Console.ReadLine()??"0");
int[,]matr=new int[n,k];
FillArray(matr);
Console.WriteLine();
PrintArray(matr);
Console.WriteLine();
EvenToNeg(matr);
PrintArray(matr);
