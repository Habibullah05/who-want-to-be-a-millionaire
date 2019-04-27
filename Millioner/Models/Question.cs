using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Millioner.Models
{

    public class Answer
    {
        public string answer { get; set; }
        public bool IsCorrect = false;
        public override string ToString()
        {
            return answer;
        }
    }

    [Serializable]
    public class Question
    {
        public int num = 0;
        public string Query { get; set; }
        public Answer[] answers = new Answer[4];


    }
}
