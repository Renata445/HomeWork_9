void NaturalNumbers(int M, int N)
{
    int start = M;
	int end = N;
	if(M > N)
	{
	    start = N;
		end = M;
    }
    for(int i = end; i >= start; i--)
    {
        Console.Write($"{i} ");
    }
}

Console.Clear();
Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(M, N);