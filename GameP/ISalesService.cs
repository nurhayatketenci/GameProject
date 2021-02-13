using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Abstract
{
   public interface ISalesService
    {
        void Sales(Gamers gamer, Game game);
        void CampaignSales(Gamers gamer, Game game, Campaign campaign);
    }
}
