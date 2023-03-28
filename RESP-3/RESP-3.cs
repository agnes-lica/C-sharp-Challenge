using System;

class Program {
    static int ff(int n)
    {
        if (n == 1) return 1;
        if (n % 2 == 0) return ff(n / 2);
        return ff((n - 1) / 2) + ff((n + 1) / 2);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(ff(7));
    }
}
