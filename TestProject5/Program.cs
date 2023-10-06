
using System;
// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// var str = "a";
// var str1 = "a ";

// Console.WriteLine(str.Trim() == str1.Trim().ToUpper());

// Console.WriteLine();

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");


// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox") == false);
// Console.WriteLine(!pangram.Contains("fox"));

// What is logical negation?

// string pangram = "The quick and lazy fox jumps over the lazy dog";
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));


// var purchaseAmount = 500;
// var discount = 0;

// if (purchaseAmount >= 1000)
// {
//     discount = 100;
// }
// else {
//     discount = 50;
// }

// Console.WriteLine(discount);

// Console.WriteLine("#");

// purchaseAmount = 10001;
// Console.WriteLine(purchaseAmount);

// var discount1 = purchaseAmount > 1000 ? 100 : 50;

// Console.WriteLine(discount1);


// COIN FLIP CHALLENGE

    // var counter = 10;
    // for (int i = 0; i <= counter; i++)
    // {
    //     Random number = new Random();
    //     var coinFlip = number.Next(0,2);
        
    //    Console.WriteLine((coinFlip == 0) ? "Heads" : "Tails");
    // }

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Counter: {i}");

    Random role = new Random();
    var value = role.Next(0, 2);
    Console.WriteLine();
    Console.WriteLine("Your value is: " + value);

    var permission = (value == 0) ? "Admin" : "Manager";
    
    Console.WriteLine("Your role is: " + permission);

    // if (value == 0)
    // {
    //     permission = "Admin";
    //     Console.WriteLine("Your role is: " + permission);  
    // }
    // else
    // {
    //     permission = "Manager";
    //     Console.WriteLine("Your role is: " + permission);
    // }

    Random number = new Random();
    var level = number.Next(0, 56);
    Console.WriteLine("Your level is: " + level);


    if (permission == "Admin" && level == 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else if(permission == "Admin" && level <= 55)
    {
        Console.WriteLine("Welcome, Admin user.");
    }
    else if(permission == "Manager" && level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else if(permission == "Manager" && level < 20)
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}