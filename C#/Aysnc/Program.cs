using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
/*
var lines =File.ReadAllLines("TextFile1.txt");

foreach (var line in lines)
{
//  Console.WriteLine(line);
}
var linesA = File.ReadAllLinesAsync("TextFile1.txt")
.ContinueWith(t=> // task will only start when above async method is done 
{
//Task Will Be Completed
if (t.IsFaulted) // Checks task gives any error or not 
{
Console.Error.WriteLine(t.Exception);
}
foreach (var line in t.Result)
{
Console.WriteLine(line);
}
} 
);
Console.ReadKey();
//Console.WriteLine("I am here");
//Make sure the main thread doesnt exit until "ContinuePart Run With 
//Console.WriteLine(linesA.Status);
//linesA.Wait(); // (Wait)It's blocking the thread, so it's similar to Sync
*/


async Task<int> ReadFile()
{
    //Async and Await makes the above big code of Aysnc much easier
    var lines = await File.ReadAllLinesAsync("TextFile1.txt");
        //await will pause the execution of the current method 
        //until the async task that is been completed
    foreach (var line in lines)
    {
        Console.WriteLine(line);
    }

    return 1;
}
var x = await ReadFile();
Console.WriteLine(x);
