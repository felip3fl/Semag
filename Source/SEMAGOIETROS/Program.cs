using Files;

Console.WriteLine("Game sorteado:");

Csv csv = new Csv();

var result = csv.OpenCsv(@"C:\Users\felip\OneDrive\Documents\Games\My game list.csv");


//print a radom number, the max number is result count
Console.WriteLine(result[new Random().Next(0, result.Count)][0]);