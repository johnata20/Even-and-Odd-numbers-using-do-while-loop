int inp, x;

Console.Write("Enter an integer : ");
inp = Convert.ToInt32(Console.ReadLine());

if (inp > 0 && inp % 2 == 0)
{
    x = 2;
    Console.Write("Even numbers from 1 to {0} : ", inp);
    do
    {
        Console.Write("{0} ", x);
        x += 2;
    } while (x <= inp);
}

if (inp > 0 && inp % 2 != 0)
{
    x = 1;
    Console.Write("Odd numbers from 1 to {0} : ", inp);
    do
    {
        Console.Write("{0} ", x);
        x += 2;
    } while (x <= inp);
}

if (inp == 0)
    Console.WriteLine("The input is zero.");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

