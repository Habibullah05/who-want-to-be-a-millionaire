using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Millioner.Services;
using Millioner.Models;
using Millioner.View;
using System.Media;
//using System.Media;
using System.Threading;


namespace Millioner
{
    public partial class MainForm : Form, IMainForm
    {
        private Question question;
        Label label;

        private List<Label> labels = new List<Label>();
        public event EventHandler<NewQuestionEventArgs> SetQuestionEvent;
        public event EventHandler<AnswerEventArgs> AnswerEvent;
        public event EventHandler<HintEventArgs> HintEvent;

        private Gamer gamer = new Gamer();
      //  SoundPlayer player = new SoundPlayer(@"Music.wav");
        private bool isMusic = true;
        private byte indexlabels = 0;

        public MainForm()
        {

            InitializeComponent();

           // player.Play();

            labels.Add(label_1);
            labels.Add(label_2);
            labels.Add(label_3);
            labels.Add(label_4);
            labels.Add(label_5);
            labels.Add(label_6);
            labels.Add(label_7);
            labels.Add(label_8);
            labels.Add(label_9);
            labels.Add(label_10);
            labels.Add(label_11);
            labels.Add(label_12);
            labels.Add(label_13);
            labels.Add(label_14);
            labels.Add(label_15);

        }
        public void SetQuestion(Question question)
        {

            label_A.Enabled = true;
            label_B.Enabled = true;
            label_C.Enabled = true;
            label_D.Enabled = true;

            this.question = question;
            label_Question.Text = question.Query;
            label_A.Text += question.answers[0].answer;
            label_B.Text += question.answers[1].answer;
            label_C.Text += question.answers[2].answer;
            label_D.Text += question.answers[3].answer;
        }

        public void AnswerClick(object sender, EventArgs e)
        {
            label = sender as Label;

            label.BackColor = Color.Orange;
            label.ForeColor = Color.White;
            // label.Text.Substring(2);
            // Thread.Sleep(2000);
            foreach (Answer item in question.answers)
            {
                if (item.ToString() == label.Text.Substring(2))
                {

                    AnswerEvent?.Invoke(sender, new AnswerEventArgs()
                    {
                        answer = item,
                        num = uint.Parse(labels[indexlabels].Text.Substring((indexlabels >= 9 ? 6 : 5)))
                    });
                }
            }



        }


        public void Answer_True()
        {
            label.BackColor = Color.Green;


            ++indexlabels;
            LabelsColor(indexlabels - 1, indexlabels);
            NewQuestion();
            // Thread.Sleep(2000);
            SetQuestionEvent?.Invoke(this, new NewQuestionEventArgs() { newQuestion = false });




        }
        private void NewQuestion()
        {
            label_Question.Text = "";
            label_A.Text = "A:";
            label_B.Text = "B:";
            label_C.Text = "C:";
            label_D.Text = "D:";
            label.BackColor = Color.Transparent;
        }
        private void LabelsColor(int num1, int num2)
        {
            labels[num1].BackColor = Color.Transparent;
            labels[num1].ForeColor = Color.DarkOrange;
            labels[num2].BackColor = Color.Orange;
            labels[num2].ForeColor = Color.White;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            LabelsColor(indexlabels, 0);
            SetQuestionEvent?.Invoke(this, new NewQuestionEventArgs() { newQuestion = true });
        }

        bool IView.ShowDialog()
        {
            return this.ShowDialog() == DialogResult.OK;
        }

        void IMainForm.GameOver()
        {
            // label.BackColor = Color.Green;
            EndGame();
            MessageBox.Show(gamer.Name + "You played\n Your points:" + gamer.NumPoint, "Game over!!!");

        }

        void IMainForm.WinGame()
        {
            EndGame();
            MessageBox.Show("You win:" + gamer.Name + "\n Win:" + gamer.NumPoint, "WIN GAME!!!");
        }
        private void EndGame()
        {
            button_50x50.BackColor = Color.Transparent;
            button_call.BackColor = Color.Transparent;
            button_hall.BackColor = Color.Transparent;
            button_50x50.Enabled = true;
            button_call.Enabled = true;
            button_hall.Enabled = true;
            NewQuestion();
            LabelsColor(indexlabels, 0);
            indexlabels = 0;
            SetQuestionEvent?.Invoke(this, new NewQuestionEventArgs() { newQuestion = true });

        }

        private void Click_Hint(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.Black;
            button.Enabled = false;


            switch (button.Text)
            {
                case ".": HintEvent?.Invoke(this, new HintEventArgs() { hint = gamer.hints[0], question = this.question }); break;
                case "..": HintEvent?.Invoke(this, new HintEventArgs() { hint = gamer.hints[1], question = this.question }); break;
                case "...": HintEvent?.Invoke(this, new HintEventArgs() { hint = gamer.hints[2], question = this.question }); break;

            }

        }


        public void SetGamer(Gamer gamer)
        {
            this.gamer = gamer;
        }

        //private void button_Music_Click(object sender, EventArgs e)
        //{
        //    isMusic = !isMusic;

        //    if (isMusic)
        //    {
        //        player.Play();
        //    }
        //    else
        //    {
        //        player.Stop();
        //    }



        //}

        public void SetAvailableHints(Action action)
        {
            if (action != null)
            {
                action.Invoke();

            }
            else
            {
                if (question.answers[0].IsCorrect || question.answers[2].IsCorrect)
                {
                    label_B.Text = "";
                    label_B.Enabled = false;
                    label_D.Text = "";
                    label_D.Enabled = false;
                }
                else
                {
                    label_A.Text = "";
                    label_A.Enabled = false;
                    label_C.Text = "";
                    label_C.Enabled = false;

                }
            }
        }
    }
}
