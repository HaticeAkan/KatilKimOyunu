using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatilKimOyunu.Models
{
    public class Suspect
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Job { get; set; }

        public string Relationship { get; set; }

        public string Statement { get; set; }

        public bool IsLying { get; set; }

        public string ImagePath { get; set; }
    }
}
