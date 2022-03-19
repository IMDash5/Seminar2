Console.Write("Введите трёхзначное число: ");
string num = Console.ReadLine();
int Num = int.Parse(num);

int result = (Num % 100) % 10;
Console.WriteLine(result);
