//exer 1
// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";

// var itemNumber = 0;
// foreach (var item in fraudulentOrderIDs)
// {
//     Console.WriteLine($"The item number: {itemNumber} in the array is: {item}");
//     itemNumber++;
// }

//extern 2
// int[] inventory = { 200, 450, 700, 175, 250 };

// int sum = 0;
// foreach (int items in inventory)
// {
//     sum += items;
// }

// Console.WriteLine($"The sum of all array elements is: {sum}");

//challenge
string[] fraudulentOrderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

var counter = 1;
foreach (var item in fraudulentOrderIDs)
{
    if (item.StartsWith('B'))
    {
        Console.WriteLine($"The number {counter} ID that  needs further investigation is: {item}");
        counter++;
    }
}