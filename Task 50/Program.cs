void PrintArray(int[,]arr)
{
    Console.WriteLine("--------------------------");
    for(int i = 0; i<arr.GetLength(0); i++)
    {
        Console.Write("|");
        for(int j = 0; j<arr.GetLength(1); j++)
        {
            if(arr[i,j]<0)
            {
                if(arr[i,j]==-10)
                {
                    Console.Write($" {arr[i,j]} |");
                }
                else Console.Write($" {arr[i,j]}  |");
            }
            else if(arr[i,j]==10)
            {
                Console.Write($"  {arr[i,j]} |");    
            }
            else Console.Write($"  {arr[i,j]}  |");

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
            arr[i,j] = new Random().Next(-10, 10);
        }
    }
    Console.WriteLine();
}
void FindElement(int[,]arr)
{
    Console.WriteLine("Уточните позицию элемента в массиве.");
    Console.Write("Строка: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Столбец: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int o =0;
    for(int i = 0;i<arr.GetLength(0);i++)
    {
        for(int j =0;j<arr.GetLength(1); j++)
        {
            if((i == m-1) & (j==n-1))
            {
                Console.WriteLine($"Элемент с заданной вами позицией принимает значение {arr[i,j]}." );
                o++;
            }
        }
    }
    if(o==0)
    {
        Console.WriteLine("Элемент с заданной вами позицией отсутствует в массиве.");
    }
}
    
int[,]array = new int[4,4];
FillArray(array);
PrintArray(array);
FindElement(array);