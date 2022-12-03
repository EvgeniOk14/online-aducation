Console.Clear(); // cleaning the display
int n = new Random().Next(100,1000); // to get a three-digit random number
Console.WriteLine("the casual number is: " + n); // print the casual number
int n1 = n / 100; // make a division by one hundred
int n3 = n % 10; // make a division by ten without a remainder 
int Y = n1 * 10 + n3; // CREATE A FULL VALUE NAMBER
Console.WriteLine("print a new number without a middle figure: " + Y);
