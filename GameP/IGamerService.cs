using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business
{
    public  interface IGamerService
    {
        void Add(Gamers gamer);
        void Delete(Gamers gamer);
        void Update(Gamers gamer);
    }
}
