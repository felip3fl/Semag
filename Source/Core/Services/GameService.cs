using Core.Models;
using OfficeFile;

namespace Core.Services
{
    public class GameService
    {
        public List<Game> _gameList = new();

        public void LoadFileGame()
        {
            ExcelFile excelFile = new ExcelFile();

            var gameFromFile = excelFile.Open(@"Files\My game list.xlsx");

            var gameFromFileWithoutHeader = RemoveHeaderFromList(gameFromFile);

            
            foreach (var item in gameFromFileWithoutHeader)
            {
                Game game = new();
                game.Name = (string)item[0];
                game.Store = (string)item[4];
                game.Player = Convert.ToByte( item[1]);
                game.OnlyLocal = (bool)item[2];
                game.BetterTogether = (bool)item[3];
                game.Finish = (bool)item[5];

                _gameList.Add(game);
            }

        }

        private List<List<object>> RemoveHeaderFromList(List<List<object>> fileWithHeader)
        {
            fileWithHeader.Remove(fileWithHeader[0]);
            return fileWithHeader;
        }
    }
}
