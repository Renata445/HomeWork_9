void SumNumbers(int M, int N)
{
    int sum = 0;
    int start = M;
	int end = N;
	if(M > N)
	{
	    start = N;
		end = M;
    }
    for(int i = start; i <= end; i++)
    {
        sum += i;
    }
    Console.WriteLine($"Сумма = {sum}");
}

Console.Clear();
Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
SumNumbers(M, N);