/**
*--------------------------------------------------------------------
* File name: Program.cs
* Project name: lab7
*--------------------------------------------------------------------
* Author’s name and email: Justin Dubin, dubinj@etsu.edu
* Course-Section: CSCI 1250-001
* Creation Date: 03 Apr 2022
*
-------------------------------------------------------------------
*/
CountSheep();
XO();
static void CountSheep()
{
        System.Console.WriteLine("Enter non-negative integer here: ");
        int place = Convert.ToInt32(Console.ReadLine());
        if(place <= 0)
        {
             System.Console.WriteLine("Cannot enter a negative number! ");
        }
        else if(place >= 0)
        {
            for (int i = 1; i <= place; i++)
                {       
                    System.Console.WriteLine(i + " sheep...");
                }
        }
}
static void XO()
{
    System.Console.WriteLine("Enter (x) and (o) as many times as you'd like!");
    System.Console.WriteLine("If there are the same number of each, true will be returned. If not, false will be returned.");
    System.Console.Write("Enter Here: ");
    string entry = Console.ReadLine().ToLower();

    string[] x = entry.Split("x");
    string[] o = entry.Split("o");

    if(x.Length == o.Length)
    {
        Console.WriteLine("True!");
    }
    else if(x.Length != o.Length)
    {
        Console.WriteLine("False!");
    }
}
