static int GetCubed(int x)
{
    return (x * x * x);
}

static int GetSquare(int y)
{
    return (y * y);
}

Console.WriteLine("Learn your squares and cubes!");

while (true)
{
    bool isDataValid = false;
    int userNum = 0;

    while (isDataValid == false)
    {
        Console.WriteLine("Please enter a positive integer:");
        userNum = int.Parse(Console.ReadLine());

        if (userNum <= 0)
        {
            Console.WriteLine("Please enter a valid number!");
        }

        else if (userNum > 1290)
        {
            Console.WriteLine("Sorry, this number is too large, please choose a number less than or equal to 1,290.");
        }
        else
        {
            isDataValid = true;
        }
    }

    Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", "Number", "Squared", "Cubed"));
    Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", "======", "=======", "====="));

    for (int i = 1; i <= userNum; i++)
    {
        Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", i, GetSquare(i), GetCubed(i)));
    }

    Console.WriteLine("Would you like to restart? Enter YES or Y to continue, or enter any other key to exit");
    string restart = Console.ReadLine().ToUpper();

    if (restart == "Y" || restart == "YES")
    {
        continue;
    }
    else
    {
        Console.WriteLine("Thanks for playing! Exiting now...");
        break;
    }

}
