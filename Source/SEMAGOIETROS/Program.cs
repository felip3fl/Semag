using Files;
using OfficeFile;
using System.Text;


System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


Console.WriteLine("Game sorteado:");

Csv csv = new Csv();
ExcelFile excelFile = new ExcelFile();

var result = csv.OpenCsv(@"C:\Users\felip\OneDrive\Documents\My games\My game list.csv");
var result2 = excelFile.Open(@"C:\Users\felip\OneDrive\Documents\My games\My game list.xlsx");


//print a radom number, the max number is result count
Console.WriteLine(result[new Random().Next(0, result.Count)][0]);