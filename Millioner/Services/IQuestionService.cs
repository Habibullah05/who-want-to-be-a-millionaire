using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Millioner.Models;

namespace Millioner.Services
{
    interface IQuestionService
    {
        void SetQuestions();
        Question Next_Question(bool newQuestions) ;
    }
}
