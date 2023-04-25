Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");



Console.WriteLine($"The total number of rolls equals to: {total}");

if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
        Console.WriteLine($"Your new total is {total}");
    } 
    else
    {
        Console.WriteLine("Yeahhh  you rolled doubles! You get extra 2 points for that!!!");
        total += 2;
        Console.WriteLine($"Your new total is {total}");
    }
}

if (total >= 15)
{
    Console.WriteLine("Your total score is higher than 14! \nCongrats you are a winner");
}
else
{
    Console.WriteLine("Sorry, you didn't get a total higher than 14! \nSoooo, You looseeee bro!");
}
