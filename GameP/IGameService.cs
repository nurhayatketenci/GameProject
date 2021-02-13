using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business
{
    public interface IGameService
    {
        void Add(Game gamer);
        void Delete(Game gamer);
    
    }
}
