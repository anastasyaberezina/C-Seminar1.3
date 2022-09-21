// Программа, принимающая на вход одно число N, а на выходе показывает все целые числа в промежутке от -N до N

Console.WriteLine("Введи число: ");
int N = int.Parse(Console.ReadLine());
int N2 = -N;

while(N2<=N)
{
 Console.WriteLine(N2+" ");
 N2++;
}
