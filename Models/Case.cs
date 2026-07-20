using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatilKimOyunu.Models
{
    public class Case
    {
        public string Title { get; set; }

        public Victim Victim { get; set; }

        public List<Suspect> Suspects { get; set; }

        public List<Evidence> Evidences { get; set; }

        public List<CameraRecord> CameraRecords { get; set; }

        public List<PhoneMessage> PhoneMessages { get; set; }

        public List<DiaryEntry> DiaryEntries { get; set; }
    }
}
