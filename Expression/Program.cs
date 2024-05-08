using Expressions;

var expressions = new ExpressionService();

var msDevs = expressions.GetAllPersons("Microsoft Developer").ToList();
var appleTesters = expressions.GetAllPersons("Tester Apple ").ToList();

Console.WriteLine($"Microsoft developers count: {msDevs.Count}");
msDevs.ForEach(x => x.PrintProperties());

Console.WriteLine($"Apple testers count: {appleTesters.Count}");
appleTesters.ForEach(x => x.PrintProperties());