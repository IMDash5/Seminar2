Console.Write("Введите первое число: ");
string n1 = Console.ReadLine();
int N1 = int.Parse(n1);

Console.Write("Введите второе число: ");
string n2 = Console.ReadLine();
int N2 = int.Parse(n2);

int rev = 0;

if(N1 % N2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    rev = N1 % N2;
    Console.WriteLine($"не кратно, остаток {rev}");
}