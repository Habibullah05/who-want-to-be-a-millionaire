using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Millioner.Models;
using System.Windows.Forms;

namespace Millioner.Services
{
    class GamerService : IGamerService
    {
        private Gamer gamer = new Gamer() { Name = "Anatan" };
            Action action ;


        public void AddPoints(uint num)
        {
            gamer.NumPoint = num;
        }

        public Action GetAvailableHints()
        {
            return action;
        }

        public void UseHint(Hint hint, Question question)
        {
            if (!hint.isUsed)
            {
                Answer answer =new Answer();

                foreach (var item in question.answers)
                {
                    if (item.IsCorrect)
                    {
                        answer = item;
                    }
                }

                if (gamer.hints[0].title == hint.title)
                {
                    gamer.hints[0].isUsed = !gamer.hints[0].isUsed;
                    action = null;
                }
                else if (gamer.hints[1].title == hint.title)
                {
                    gamer.hints[1].isUsed = !gamer.hints[1].isUsed;

                    action = () => { MessageBox.Show("Most people in the room voted for option:"+answer,"Hall assistance!!!"); };
                }
                if (gamer.hints[2].title == hint.title)
                {
                    gamer.hints[2].isUsed = !gamer.hints[2].isUsed;

                    action = () => { MessageBox.Show("We called Putin!\n He thinks the right answer:"+answer,"Call a friend"); };
                }
            }
          


        }

        public Gamer GetGamer()
        {
            return gamer;
        }
    }
}
