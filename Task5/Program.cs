int a = Num("Введите n ");

int Num(string arg)
{
    Console.Write(arg);
    string n = Console.ReadLine();
    int N = int.Parse(n);
    return N;
}





int Module(int N)
{
    int mod = N;
    if (N < 0)
    {
        return -mod;
    }
    else
    {
        return mod;
    }
    return mod;
}

Console.WriteLine(Module(a));
