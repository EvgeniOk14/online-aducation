Console.Clear();
Console.WriteLine("input fist number N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second number M: ");
int M = Convert.ToInt32(Console.ReadLine());
  if (M > N)
        Console.WriteLine("You inputted a wrong sequence, first number has to be more then second. Please try it again! ");
  else if  (N % M == 0) 
   Console.WriteLine("second number is a multiple of the fist ");
  else
   Console.WriteLine($"second number is not a multiple of the fist. The remainder is {N%M} ");
