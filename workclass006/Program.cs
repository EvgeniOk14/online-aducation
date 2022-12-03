Console.WriteLine("input the first number N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input the second number M: ");
int M = Convert.ToInt32(Console.ReadLine());
int k = N*N; // square of first number
int y = M*M; // square of second number
if (k == M)
Console.WriteLine("Yes, the second number is the square of the first");
 else if (y == N)
Console.WriteLine("Yes, the first number is the square of the second");
else 
Console.WriteLine("No, both of numbers are not the square of each other");