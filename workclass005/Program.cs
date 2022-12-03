Console.Clear();
Console.WriteLine("input a number N: ");
int N = Convert.ToInt32(Console.ReadLine());
 if (N % 7 == 0 && N % 23 == 0)
   {
    Console.WriteLine("Yes, the number is multiple of 7 and 23 ");
   }
 else
 {
    Console.WriteLine("No, the number is not multiple of 7 and 23 ");
 }
