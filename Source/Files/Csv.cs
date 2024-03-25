using System.IO;

namespace Files
{
    public class Csv
    {
        public List<string[]> OpenCsv(string pathFile)
        {
            string[] lines = File.ReadAllLines(pathFile);
            List<string> linesList = lines.ToList();

            return linesList.Select(line => line.Split(';')).ToList();
        }
    }
}
