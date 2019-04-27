using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Millioner.Models;

namespace Millioner.Services
{
    public class QuestionService : IQuestionService
    {
        /* public  void AddQuestion()
         {
             using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
             {
                 XmlSerializer serializer = new XmlSerializer(typeof(List<Question>));

                 serializer.Serialize(fs, Questions);
             }
         }*/
        /* private List<Question> Questions = new List<Question>()
         {

             new Question()
             {
                 num =1,
                 Query="В какое насекомое не превращался князь Гвидон в \"Сказке о царе Салтане\"?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "Комар",IsCorrect=false },
                      new Answer(){ answer= "Пчела",IsCorrect=true },
                       new Answer(){ answer= "Шмель",IsCorrect=false },
                        new Answer(){ answer= "Муха",IsCorrect=false }
                 }

             },
               new Question(){
                   num=2,
                 Query="Что изобрёл в 19 веке англичанин Джордж Стефенсон?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer=   "Пароход",IsCorrect=false },
                      new Answer(){ answer=  "Паровоз",IsCorrect=true },
                       new Answer(){ answer= "Параплан",IsCorrect=false },
                        new Answer(){ answer="Парашют",IsCorrect=false }
                 }

             },
                 new Question(){
                     num=3,
                 Query="В каком фильме можно услышать фразу: \"Возьму с собой „Идиота“, чтобы не скучать в троллейбусе\"?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "Веселые ребята",IsCorrect=false },
                      new Answer(){ answer= "Волга-Волга",IsCorrect=false },
                       new Answer(){ answer= "Цирк",IsCorrect=false },
                        new Answer(){ answer= "Весна",IsCorrect=true }
                 }

             },
                   new Question(){
                       num=4,
                 Query="Какую фамилию носил главный герой поэмы А. Твардовского?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "Тёркин",IsCorrect=true },
                      new Answer(){ answer= "Толстой ",IsCorrect=false },
                       new Answer(){ answer= "Швабрин",IsCorrect=false },
                        new Answer(){ answer= "Калачев",IsCorrect=false }
                 }

             },
                     new Question(){
                         num=5,
                 Query="Какая первая буква Арабского алфавита,",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "ا",IsCorrect=true },
                      new Answer(){ answer= "لأ",IsCorrect=false },
                       new Answer(){ answer= "ف",IsCorrect=false },
                        new Answer(){ answer= "ل",IsCorrect=false }
                 }

             },
                       new Question(){
                            num=6,
                 Query="Как называют звезду, которая указала волхвам место рождения Христа?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "Вифл",IsCorrect=false },
                      new Answer(){ answer= "Навсикая",IsCorrect=false },
                       new Answer(){ answer= "Вифлеемская",IsCorrect=true },
                        new Answer(){ answer= "христианскfz",IsCorrect=false }
                 }

             },
                         new Question(){
                              num=7,
                 Query="Как называют период времени, когда солнце в северных широтах не опускается за горизонт?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "пассат",IsCorrect=false },
                      new Answer(){ answer= "Полярный день",IsCorrect=true },
                       new Answer(){ answer= "Торонто ",IsCorrect=false },
                        new Answer(){ answer= "антипассат",IsCorrect=false }
                 }

             },
                           new Question(){
                                num=8,
                 Query="Какой советский космонавт получил первую космическую почту?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "Юрий Гагарин",IsCorrect=false },
                      new Answer(){ answer= "Владимир Шаталов",IsCorrect= true},
                       new Answer(){ answer= "Юрий Батурин",IsCorrect=false },
                        new Answer(){ answer= "Г. Т. Береговой",IsCorrect=false }
                 }

             },
                             new Question(){
                                  num=9,
                 Query="Какое прозвище носил король Англии Ричард I?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "Львиное Сердце",IsCorrect=true },
                      new Answer(){ answer= "солнце",IsCorrect=false },
                       new Answer(){ answer= "Первый",IsCorrect=false },
                        new Answer(){ answer= "Счастливый",IsCorrect=false }
                 }

             },
                               new Question(){
                                    num=10,
                 Query="Каким предметом китайцы стараются не пользоваться в преддверии Нового года, чтобы не разрушить счастья?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "Булавa",IsCorrect=false },
                      new Answer(){ answer= "бритвой",IsCorrect=false },
                       new Answer(){ answer= "Мяч",IsCorrect=false },
                        new Answer(){ answer= "Нож",IsCorrect=true }
                 }

             },
                                 new Question(){
                                      num=11,
                 Query="Как называют манекенщицу супер-класса?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "Топ-модель",IsCorrect=true },
                      new Answer(){ answer= "Тарзан",IsCorrect=false },
                       new Answer(){ answer= "Маникен",IsCorrect=false },
                        new Answer(){ answer= "Стилист",IsCorrect=false }
                 }

             },
                                   new Question(){
                                        num=12,
                 Query="Какой цвет получается при смешении синего и красного?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "цемент",IsCorrect=false },
                      new Answer(){ answer= "Зеленый",IsCorrect=false },
                       new Answer(){ answer= "Фиолетовый",IsCorrect=true },
                        new Answer(){ answer= "карлики",IsCorrect=false }
                 }

             },
                                     new Question(){
                                           num=13,
                 Query="Как назывался верховный орган власти в Древнем Риме?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "Сенат",IsCorrect=true },
                      new Answer(){ answer= "Цезарь",IsCorrect=false },
                       new Answer(){ answer= "Парламент",IsCorrect=false },
                        new Answer(){ answer= "Народ",IsCorrect=false }
                 }

             },
                                       new Question(){
                                           num=14,
                 Query="На какой птице летала Дюймовочка?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "Кукушка",IsCorrect=false },
                      new Answer(){ answer= "Самолет",IsCorrect=false },
                       new Answer(){ answer= "Ласточка",IsCorrect=true },
                        new Answer(){ answer= "Синица",IsCorrect=false }
                 }

             },
                                         new Question(){
                                             num=15,
                 Query="Как называется официальная резиденция Президента США в Вашингтоне?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "Белый дом",IsCorrect=true },
                      new Answer(){ answer= "Вашингтон",IsCorrect=false },
                       new Answer(){ answer= "Пентагон",IsCorrect=false },
                        new Answer(){ answer= "Кремль",IsCorrect=false }
                 }

             },
                                           new Question(){
                                               num=16,
                 Query="Скольким каратам соответствует чистое золото?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "24",IsCorrect=true },
                      new Answer(){ answer= "15",IsCorrect=false },
                       new Answer(){ answer= "2",IsCorrect=false },
                        new Answer(){ answer= "0",IsCorrect=false }
                 }

             },
                                             new Question(){
                                                  num=17,
                 Query="В какой области не присуждают Нобелевскую премию?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "Литература",IsCorrect=false },
                      new Answer(){ answer= "Премия мира",IsCorrect=false },
                       new Answer(){ answer= "Математика",IsCorrect=true },
                        new Answer(){ answer= "физика",IsCorrect=false }
                 }

             },
                                               new Question(){
                                                    num=18,
                 Query="Чего больше всего в воздухе?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "Кислорода",IsCorrect=false },
                      new Answer(){ answer= "Угликислого газа",IsCorrect=false },
                       new Answer(){ answer= "Воды",IsCorrect=false },
                        new Answer(){ answer= "Азота",IsCorrect=true }
                 }

             },
                                                 new Question(){
                                                      num=19,
                 Query="Что, согласно народной мудрости, следует уносить в случае опасности?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "Руки",IsCorrect=false },
                      new Answer(){ answer= "Ноги",IsCorrect=true },
                       new Answer(){ answer= "в воду",IsCorrect=false },
                        new Answer(){ answer= "Печень",IsCorrect=false }
                 }

             },
                                                   new Question(){
                                                        num=20,
                 Query="Чем были скреплены перья на крыльях мифологического героя Икара?",
                 answers=new Answer[]
                 {
                     new Answer(){ answer= "Воском",IsCorrect=true },
                      new Answer(){ answer= "Слюной",IsCorrect=false },
                       new Answer(){ answer= "клеем",IsCorrect=false },
                        new Answer(){ answer= "кровью",IsCorrect=false }
                 }

             },

         };*/
        private List<Question> Questions = new List<Question>();
        private string path = "Question.xml";
        private int index = -1;
        


        public Question Next_Question(bool newQuestions)
        {
            if (newQuestions)
            {
                index = -1;
            }

            if (index==-1)
            {
                SetQuestions();
            }
            ++index;
            if (index<Questions.Count)
            {
                return Questions[index];
            }
            return null;
        }
        //Dictionary<> для очков
        public void SetQuestions()
        {
            if (Questions!=null)
            {
                Questions=new List<Question>();
            }
            
            using (Stream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Question>));
                Random random = new Random();
               
                List<Question> tmp = serializer.Deserialize(fs) as List<Question>;
                for (int i = 0; i < 15; i++)
                {
                    bool isSame = false;
                    int rand=random.Next(1, 20);
                    foreach (var item in Questions)
                    {
                        if (item.num==rand)
                        {
                            isSame = true;
                        }
                    }
                    if (isSame!=true)
                    {
                        Questions.Add(tmp[rand-1]);
                    }
                    else
                    {
                        --i;
                    }

                }  
              
            }   
        }
    }
}
