using Files;
using OfficeFile;
using Terminal;


System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

AscNumber ascNumber = new AscNumber();

string choice = "S";
string filePath = @"Files\My game list.xlsx";


if (File.Exists(filePath) == true) {

    Console.Clear();
    Console.WriteLine("Adicione quantos jogadores você deseja: ");
    int players = Convert.ToInt32(Console.ReadLine());

    countSystem();


    while (choice == "S" || choice == "s") {

        Console.WriteLine("\nGame sorteado:");

        Csv csv = new Csv();
        ExcelFile excelFile = new ExcelFile();

        
        var result = excelFile.Open(@"Files\My game list.xlsx");

        
        // _gameList[10]

        //print a radom number, the max number is result count
        var numeroPosicaoSorteado = new Random().Next(0, result.Count);
        var game = result[numeroPosicaoSorteado];

        Console.WriteLine("Name: " + game[0]);
        // Console.WriteLine("Name: " + _gameList[4].Name);
        Console.WriteLine("Store: " + game[4]);
        //Console.WriteLine("Store: " +  _gameList[4].Store);
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

void countSystem() {

    for (int number = 5; number >= 1; number -- )  {

    Console.WriteLine(ascNumber.Numbers[number]);
    Thread.Sleep(1000);
    Console.Clear();

    }
}

public class AscFont : AscNumber {


}
