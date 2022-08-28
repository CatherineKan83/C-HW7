void PrintArray(double[,]arr)
{
    Console.WriteLine("--------------------------");
    for(int i = 0; i<arr.GetLength(0); i++)
    {
        Console.Write("|");
        for(int j = 0; j<arr.GetLength(1); j++)
        {
            if(arr[i,j]<0)
            {
                if(arr[i,j]%1==0)
                {
                    Console.Write($" {arr[i,j]}  |");
                }
                else Console.Write($"{arr[i,j]} |");
            }
            else if(arr[i,j]%1==0)
            {
                Console.Write($"  {arr[i,j]}  |");    
            }
            else Console.Write($" {arr[i,j]} |");

        }
        Console.WriteLine();
      }
      Console.WriteLine("---------------------------");
}
void FillArray(double[,]arr)
{
     for(int i = 0;i<arr.GetLength(0);i++)
     {
          for(int j =0;j<arr.GetLength(1); j++)
          {
                arr[i,j] = Convert.ToDouble(new Random().Next(-100, 101)/10.0);
           }
       }
       Console.WriteLine();
}
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,]array = new double[m,n];
FillArray(array);
PrintArray(array);