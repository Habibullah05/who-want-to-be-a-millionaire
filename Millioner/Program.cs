using System;
using System.Collections.Generic;
using System.Linq;
using Millioner.View;
using Millioner.Services;
using System.Windows.Forms;
using Millioner.Presenter;

namespace Millioner
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            #region IOC setting
            IOC.Regisrter<MainForm, IMainForm>();
            IOC.Regisrter<QuestionService, IQuestionService>();
            IOC.Regisrter<GamerService, IGamerService>();
           IOC.Regisrter<MainPresenter>();
            IOC.Build();
            #endregion
            MainPresenter mainPresenter = IOC.Resolve<MainPresenter>();
            Application.Run((Form)mainPresenter.View);
        }
    }
}
