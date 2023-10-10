using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public Bird()
        {

        }

        public Bird(string wingSpan, bool migratory, string beak, string plumage)
        {
            WingSpan = wingSpan;
            Migratory = migratory;
            Beak = beak;
            Plumage = plumage;
        }

        public string WingSpan { get; set; }
        public bool Migratory { get; set; }
        public string Beak { get; set; }
        public string Plumage { get; set;}

    }
}
