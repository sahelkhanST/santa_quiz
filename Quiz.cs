using System;
public class Quiz
{
 public static void Main(string [] args)
 {
    int count=0;
    Console.WriteLine("enter your name:");
    string name=Console.ReadLine();
    Console.WriteLine($"Hello {name}, Welcome to Santa Quiz \n");
    Console.WriteLine("What is the capital of Japan?");
    string solar=Console.ReadLine();
    string lower1=solar.ToLower();
    if(lower1=="tokyo")
    {
    count++;
    Console.WriteLine("Correct! You've earned a gift.");
    }
    else
    {
    Console.WriteLine("Oops! That's not correct.");
    }
    Console.WriteLine("What is the largest country in the world by area?");
    string continents=Console.ReadLine();
    string lower2=continents.ToLower();
    if(lower2=="russia")
    {
    count++;
    Console.WriteLine("Correct! You've earned a gift.");
    }
    else
    {
    Console.WriteLine("Oops! That's not correct.");
    }
    Console.WriteLine( "What is the longest river in the world?");
    string currency=Console.ReadLine();
    string lower3=currency.ToLower();
    if(lower3=="nile river")
    {
    count++;
    Console.WriteLine("Correct! You've earned a gift.");
    }
    else
    {
    Console.WriteLine("Oops! That's not correct.");
    }
    Console.WriteLine("What is the largest land animal?");
    string world=Console.ReadLine();
    string lower4=world.ToLower();
    if(lower4=="african elephant")
    {
    count++;
    Console.WriteLine("Correct! You've earned a gift.");
    }
    else
    {
    Console.WriteLine("Oops! That's not correct.");
    }
    Console.WriteLine("What is the symbol for gold on the periodic table?");
    string moon=Console.ReadLine();
    string lower5=moon.ToLower();
    if(lower5=="au")  
    {
    count++;
    Console.WriteLine("Correct! You've earned a gift.");
    }
    else
    {
    Console.WriteLine("Oops! That's not correct.");
    }
    Console.WriteLine($"santa Quiz is completed \n Congratulations you answered {count} questions correctly.So,You earned {count} gift(s) from santa");
 }
}

