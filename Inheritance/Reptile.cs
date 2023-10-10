using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public Reptile() 
        {
        
        }

        public Reptile(string protection, bool laysEggs, int lungs, string size)
        {
            Protection = protection;
            LaysEggs = laysEggs;
            Lungs = lungs;
            Size = size;
        }

        public string Protection { get; set; }
        public bool LaysEggs { get; set; }
        public int Lungs { get; set; }
        public string Size { get; set; }

    }
}
