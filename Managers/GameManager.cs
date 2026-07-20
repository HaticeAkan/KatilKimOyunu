using KatilKimOyunu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatilKimOyunu.Managers
{
    public class GameManager
    {
        public static GameManager Instance { get; } = new GameManager();

        private GameManager()
        {
            CollectedEvidenceIds = new List<string>();
            AskedQuestionIds = new List<string>();
            Notes = new List<string>();

            Score = 0;
        }
        public Case CurrentCase { get; set; }
        // İncelenen bölümler
        public bool HasVisitedCrimeScene { get; set; }
        public bool HasReadAutopsy { get; set; }
        public bool HasCheckedPhone { get; set; }
        public bool HasCheckedCameras { get; set; }
        public bool HasSearchedHouse { get; set; }

        // Bulunan deliller
        public List<string> CollectedEvidenceIds { get; set; }

        // Sorulan sorular
        public List<string> AskedQuestionIds { get; set; }

        // Yazılan notlar
        public List<string> Notes { get; set; }

        // Puan
        public int Score { get; set; }
        

        

    }
}
