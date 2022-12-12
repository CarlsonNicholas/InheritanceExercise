using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public string ReptileSpecies { get; set; }
        public Boolean HasTail { get; set; }
        public string MainColor { get; set; }
        public string BodySize { get; set; }

    }
}
