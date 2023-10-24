using System.Linq;


/*string[] names = { "Tom", "Dick", "Harry", "Mary", "Maria", "Armir", "Vanesa", "Geri" };*/

//IEnumerable<string> filteredNames = names.Where(n => n.Length >= 4);

//var filteredNames = names
//                        .Where(n => n.Contains('a'))
//                        .OrderBy(n => n.Length).Take(2)
//                        .Select(n => n.ToUpper());

/*var filteredNames = 
    (from n in names
    where n.Contains('a')
    orderby n.length
    select n.ToLower());


foreach (var n in filteredNames)
{
    Console.WriteLine(n);
}*/

//Console.WriteLine(filteredNames);

/*Console.WriteLine("#############################");

var numbers = new List<int> { 1 };
IEnumerable<int> query = numbers.Select(n => n * 10);
// Build query
numbers.Add(2); // Sneak in an extra element
foreach (int n in query)
Console.WriteLine(n + "|"); // 10|20|

Console.WriteLine("#############################");*/

/*var nums = new List<int>() { 1, 2 };
IEnumerable<int> qry = nums.Select(n => n * 10);
foreach (int n in qry) Console.Write(n + "|"); // 10 | 20 |

nums.Clear();
foreach (int n in qry) Console.WriteLine(n + "|"); // < nothing >

*/

/*string[] musos = { "David Gilmour", "Roger Waters", "Rick Wright", "Nick Mason" };

var queries = musos.OrderBy(m =>
m.Split().Last());

foreach (var m in queries)
    Console.WriteLine(m);*/



/*Thread t = new Thread(Go);
t.Start();
Thread.Sleep(5000);
*//*t.Join();*//*
Console.WriteLine();
Console.WriteLine("Thread t has ended!");

void Go()
{
    for (int i = 0; i < 1000; i++) Console.Write("y");
}*/


Task task = Task.Run(() =>
{
    Console.WriteLine("Task started");
    Thread.Sleep(2000);
    Console.WriteLine("Foo");
});
Console.WriteLine(task.IsCompleted);  // False
task.Wait();  // Blocks until task is complete