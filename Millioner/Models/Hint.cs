using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Millioner.Models
{
    public class Hint
    {
        public string title { get; set; }
        public bool isUsed = false;

        public override string ToString()
        {
            return title; 
        }
    }
}
