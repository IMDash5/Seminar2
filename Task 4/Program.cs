Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int Num = int.Parse(num);

if (Num % 7 == 0)
{
    if (Num % 23 == 0) 
    {
        Console.WriteLine("Da");
    }
}
else 
{
    Console.WriteLine("Net");
}