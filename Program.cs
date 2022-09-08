// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Employee Payroll using Threads");
string[] words = ThreadDemo.CreateWordArray(@"http://www.gutenberg.org/files/54700/54700-0.txt");
Console.WriteLine("Size of array after splitting the content: " + words.Length);
#region ParallelTasks
Parallel.Invoke(() =>
{
    Console.WriteLine("Begin first task...");
    ThreadDemo.GetLongestWord(words);
},// close 1st action
() =>
{
    Console.WriteLine("Begin second task...");
    ThreadDemo.GetMostCommonWords(words);
},
() =>
{
    Console.WriteLine("Begin third task...");
    ThreadDemo.GetMostCommonWords(words);
}// close third action
);// close parallel.invoke
#endregion
//Console.ReadKey();










