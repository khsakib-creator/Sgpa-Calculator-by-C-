using System;
class Sgpabysakib{
    static void Main()
    {
        Console.WriteLine("Made by Sakib:");
        Console.WriteLine("Enter your username:");
        string userName = Console.ReadLine();
        Console.WriteLine("Enter ID");
        string ID = Console.ReadLine();

        Console.WriteLine("You can enter only four course by calculating sgpa");
        float a, b, c, d, e, f, g, h, i, j, k, l, m, o, n, x;
        Console.WriteLine("Enter your 1t subject gpa by float number");
        a = Single.Parse(Console.ReadLine());
        Console.WriteLine("Enter your 2nd subject gpa by float number");
        b = Single.Parse(Console.ReadLine());
        Console.WriteLine("Enter your 3rd subject gpa by float number");
        c = Single.Parse(Console.ReadLine());
        Console.WriteLine("Enter your 4th subject gpa by float number");
        d = Single.Parse(Console.ReadLine());
        Console.WriteLine("Enter your 1st subject credit hour ");
        g = Single.Parse(Console.ReadLine());
        Console.WriteLine("Enter your 2nd subject credit hour ");
        h = Single.Parse(Console.ReadLine());
        Console.WriteLine("Enter your 3rd subject credit hour ");
        i = Single.Parse(Console.ReadLine());
        Console.WriteLine("Enter your 4th subject credit hour ");
        j = Single.Parse(Console.ReadLine());
        k = a * g;
        l = b * h;
        m = c * i;
        n = d * j;
        e = k + l + m + n;
        x = g + h + i + j;
        f = e / x;
       
        Console.WriteLine("Username is: " + userName);
        Console.WriteLine("ID is: " + ID);
        Console.WriteLine("your sgpa is " + f);
    }
}