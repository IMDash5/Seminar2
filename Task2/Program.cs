Random rnd = new Random();
int value = rnd.Next(10, 99);
Console.WriteLine(value);

 int maxNum = value / 10;
 if(maxNum < value % 10) maxNum = value % 10;
 Console.Write(maxNum);