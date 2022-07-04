bool isAgain = true;
do
{
    Console.Write("Enter a number: ");
    int n, sum, i;
    sum = 0;
    n = int.Parse(Console.ReadLine());
    for (i = 0; i <= n; i++)
    {
        sum += i;
    } Console.WriteLine("The sum of the numbers is: " + sum);
    Console.WriteLine("do you want to enter another number? y/n ");
    if (Console.ReadLine() == "y")
    {

    }
    else
    {
        Console.WriteLine("Goodbye!!");
        break;
    }
} while (true);