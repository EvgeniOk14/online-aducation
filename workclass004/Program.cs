Console.Clear();
int n1 = new Random().Next(1,100);
Console.WriteLine("первое случайное число:" + " " + n1);
int n2 = new Random().Next(1,100);
Console.WriteLine("второе случайное число:" + " " + n2);

    int k = n1 % n2;
    Console.WriteLine("Остаток от деления первого числа на второе равен: " + k);

        if (k != 0) 
 {
              Console.WriteLine("Остаток от деления равен " + k);
 }
        else 
 {
              Console.WriteLine("n1 кратно n2"); 
}
