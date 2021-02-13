using GameProject.Business;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " Game Added " + " Price " + game.GamePrice);
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " Game Deleted ");
        }

      
    }
}
