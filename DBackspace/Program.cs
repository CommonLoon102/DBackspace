using DBackspace;

Solver solver = new("xxxxfyyaaaas", "faas");
Console.WriteLine(solver.IsSolvable() ? "YES" : "NO");
Console.WriteLine(solver.Steps);
Console.ReadLine();
