using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Millioner.Models
{
    public class Gamer
    {
       public uint NumPoint = 0;

        public string Name { set; get; }
       public List<Hint> hints { get; set; } = new List<Hint> {
            new Hint(){title="50x50"},
            new Hint(){title="Hall"},
            new Hint(){title="Call"}

        };
    }
}
