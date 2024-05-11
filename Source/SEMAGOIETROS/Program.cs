using Files;
using OfficeFile;
using System.Text;


System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


Console.WriteLine("Game sorteado:");

Csv csv = new Csv();
ExcelFile excelFile = new ExcelFile();

//var result = csv.OpenCsv(@"C:\Users\felip\OneDrive\Documents\My games\My game list.csv");
var result = excelFile.Open(@"C:\Users\felip\Source\FL_SEMAGOIETROS\Material\My game list.xlsx");


//print a radom number, the max number is result count
var game = result[new Random().Next(0, result.Count)];
Console.WriteLine("Name: " + game[0]);
Console.WriteLine("Store: " + game[4]);
Console.WriteLine("Player: " + game[1]);
Console.WriteLine("Only Local: " + game[2]);
Console.WriteLine("Better together: " + game[3]);

Console.ReadLine();