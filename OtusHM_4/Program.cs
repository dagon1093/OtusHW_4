// See https://aka.ms/new-console-template for more information
using OtusHM_4;

Console.WriteLine("Hello, World!");

var s = new Stack("a", "b", "c");
// size = 3, Top = 'c'
Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
var deleted = s.Pop();
// Извлек верхний элемент 'c' Size = 2
Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size}");
s.Add("d");
// size = 3, Top = 'd'
Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
s.Pop();
s.Pop();
s.Pop();
// size = 0, Top = null
Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");

s.Add("a");
s.Add("b");
s.Add("c");

var s2 = new Stack("1", "2", "3");
s.Merge(s2);

Console.WriteLine($"Top {s.Top} Size {s.Size}");

var s3 = Stack.Concat(new Stack("1", "2", "3"), new Stack("a", "b", "c"), new Stack("g", "h", "k"));

Console.WriteLine($"Top {s3.Top} Size {s3.Size}");

