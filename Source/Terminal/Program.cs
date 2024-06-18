using Files;
using OfficeFile;
using Terminal;


System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

string choice = "S";
string filePath = @"Files\My game list.xlsx";
if (File.Exists(filePath) == true) {

    for (int number = 5; number >= 1; number -- )  {

        var count = new AscFont();
        List<string> numbers = count.Numbers;
        Console.WriteLine(numbers[number]);
        await Task.Delay(1000);
        Console.Clear();

    }

    while (choice == "S" || choice == "s") {

        Console.WriteLine("\nGame sorteado:");

        Csv csv = new Csv();
        ExcelFile excelFile = new ExcelFile();

        
        var result = excelFile.Open(@"Files\My game list.xlsx");

        


        //print a radom number, the max number is result count
        var game = result[new Random().Next(0, result.Count)];
        Console.WriteLine("Name: " + game[0]);
        Console.WriteLine("Store: " + game[4]);
        Console.WriteLine("Player: " + game[1]);
        Console.WriteLine("Only Local: " + game[2]);
        Console.WriteLine("Better together: " + game[3]);

        Console.WriteLine("\nDeseja continuar? [S/N]: ");
        choice = Console.ReadLine();

    }

} else {
    Console.WriteLine("Erro");

    Console.ReadKey();
}

public class AscFont : AscNumber {


}
