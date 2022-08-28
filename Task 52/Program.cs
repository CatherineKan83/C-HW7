void PrintArray(int[,]arr)
{
    Console.WriteLine("--------------------------");
    for(int i = 0; i<arr.GetLength(0); i++)
    {
        Console.Write("|");
        for(int j = 0; j<arr.GetLength(1); j++)
        {
            if(arr[i,j]==10)
            {
                Console.Write($" {arr[i,j]} |");    
            }
            else Console.Write($" {arr[i,j]}  |");

        }
        Console.WriteLine();
    }
    Console.WriteLine("---------------------------");
}
void FillArray(int[,]arr)
{
    for(int i = 0;i<arr.GetLength(0);i++)
    {
        for(int j =0;j<arr.GetLength(1); j++)
        {
           arr[i,j] = new Random().Next(0, 10);
        }
    }
    Console.WriteLine();
}
void FindMean(int[,]arr)
{
    double sum = 0;
    int j=0;
    while(j < arr.GetLength(1))
    {
        for(int i =0; i<arr.GetLength(0); i++)
        {
            sum=sum+ arr[i, j];
        }
    Console.WriteLine($"Среднее арифметическое чисел {j+1} столбца равно {Convert.ToDouble(sum/arr.GetLength(0))} .");
    j++;
    sum=0;
    }
    Console.WriteLine();
} 
Console.Write("Введите количество строчек массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,]array = new int[m,n];
FillArray(array);
PrintArray(array);
FindMean(array);