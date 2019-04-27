using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Millioner.View;
using Millioner.Services;

namespace Millioner.Presenter
{
    class MainPresenter
    {
        private IMainForm mainForm;
        private IQuestionService questionService;
        private IGamerService gamerService;
        public IView View { get { return mainForm; } }

        public MainPresenter(IMainForm mainForm, IQuestionService questionService,IGamerService gamerService)
        {
            this.mainForm = mainForm;
            this.questionService = questionService;
            this.gamerService = gamerService;
            EventSubscription();
        }

        private void EventSubscription()
        {
            mainForm.SetQuestionEvent += MainForm_SetQuestionEvent;
            mainForm.AnswerEvent += MainForm_AnswerEvent;
            mainForm.HintEvent += MainForm_HintEvent;
        }

        private void MainForm_HintEvent(object sender, HintEventArgs e)
        {
           if (!e.hint.isUsed) {
            gamerService.UseHint(e.hint, e.question);
            mainForm.SetGamer(gamerService.GetGamer());
                mainForm.SetAvailableHints(gamerService.GetAvailableHints());

           }
        }

        private void MainForm_AnswerEvent(object sender, AnswerEventArgs e)
        {
           

            gamerService.AddPoints(e.num);
            mainForm.SetGamer(gamerService.GetGamer());
            if (gamerService.GetGamer().NumPoint== 1000000)
            {
                mainForm.WinGame();
            }
            if (e.answer.IsCorrect)
            {
                mainForm.Answer_True();
            }
            else
            {
                mainForm.GameOver();
            }

        }
              

        //private void MainForm_AnswerEvent(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void MainForm_SetQuestionEvent(object sender, NewQuestionEventArgs e)
        {
            mainForm.SetQuestion(questionService.Next_Question(e.newQuestion));
        }
    }
}
