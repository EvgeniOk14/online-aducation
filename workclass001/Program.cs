Console.Clear();
int n = new Random().Next(10,100);
Console.WriteLine("casual number n is: " + n);
int n1 = n / 10; // quantity of dozens
int n2 = n % 10; // quantity of units
 if (n1 > n2)
 {
    Console.WriteLine("the biggest  figure in a casual number is: " + n1);
    Console.WriteLine("the smallest figure in a casual number is: " + n2);
 }
  else if (n2 > n1)
  {
    Console.WriteLine("the biggest  figure in a casual number is: " + n2);
    Console.WriteLine("the smallest figure in a casual number is: " + n1);
  }
