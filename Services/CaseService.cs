using Newtonsoft.Json;
using System.IO;
using KatilKimOyunu.Models;

namespace KatilKimOyunu.Services
{
    public class CaseService
    {
        public Case LoadCase(string filePath)
        {
            string json = File.ReadAllText(filePath);

            Case gameCase = JsonConvert.DeserializeObject<Case>(json);

            return gameCase;
        }
    }
}