using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Millioner.Models;

namespace Millioner.Services
{
    interface IGamerService
    {
     
         void  AddPoints(uint num);
        Gamer GetGamer();
        Action GetAvailableHints();
        void UseHint(Hint hint, Question question);
    }
}
