using Core.Services;
using Files;
using OfficeFile;
using Terminal;


System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

AscNumber ascNumber = new AscNumber();
GameService gameService = new GameService();
gameService.LoadFileGame();

string filePath = @"Files\My game list.xlsx";


if (File.Exists(filePath) == true) {

    Console.Clear();
    Console.WriteLine("Adicione quantos jogadores você deseja: ");
    int players = Convert.ToInt32(Console.ReadLine());

    countSystem();



    Console.WriteLine("\nGame sorteado:");

    var numeroPosicaoSorteado = new Random().Next(0, gameService._gameList.Count);
    var game = gameService._gameList[numeroPosicaoSorteado];

    Console.WriteLine("Name: " + game.Name);
    Console.WriteLine("Store: " + game.Store);
    Console.WriteLine("Player: " + game.Player);
    Console.WriteLine("Only Local: " + game.OnlyLocal);
    Console.WriteLine("Better together: " + game.BetterTogether);

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
