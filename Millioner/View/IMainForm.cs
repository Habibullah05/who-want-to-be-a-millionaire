using Millioner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Millioner.View
{
    interface IMainForm:IView
    {

        //event EventHandler<AnswerEventArgs> AnswerEvent;
        //void AnswerClick(object sender, EventArgs e);
        event EventHandler<NewQuestionEventArgs> SetQuestionEvent;
        event EventHandler<AnswerEventArgs> AnswerEvent;
        event EventHandler<HintEventArgs> HintEvent;
        void SetQuestion(Question question);
        void SetGamer(Gamer gamer);
        void SetAvailableHints(Action action);
        void Answer_True();
        void GameOver();
        void WinGame();
    }
    public class AnswerEventArgs : EventArgs
    {
        public Answer answer { get; set; } = new Answer();
        public uint num { get; set; }
        
    }
    public class NewQuestionEventArgs : EventArgs
    {
        public bool newQuestion;

    }
    public class HintEventArgs: EventArgs
    {
        public Hint hint { get; set; } = new Hint();
        public Question question { get; set; } = new Question();

    }
}
