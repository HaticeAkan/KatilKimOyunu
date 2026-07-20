using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatilKimOyunu.Models
{
    public class Evidence
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public bool IsCollected { get; set; }

        public bool IsImportant { get; set; }

        public string ImagePath { get; set; }
    }
}
