// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int N = Convert.ToInt32(Console.ReadLine());
int[,] t = new int[N, N];
int M = 0;
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        M++;
        if ((M % 2) != 0)
        {
            t[i, j] = 1;
            Console.Write("{0} ", t[i, j]);
        }
        else
        {
            t[i, j] = 0;
            Console.Write("{0} ", t[i, j]);
        }

    }
    Console.WriteLine();
}