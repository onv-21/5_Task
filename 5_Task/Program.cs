// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] array = new int[7];
int N = 0;
int M = 0;
for (int i = 0; i < 7; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    N += array[i];
    M = N /7;
    Console.WriteLine("{0} ", array[i]);
}
Console.WriteLine();
Console.WriteLine("Среднее арифметическое {0}",M);