using GameProject.Business.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign camp)
        {
            Console.WriteLine(camp.CampaignName+" Added"+" %"+camp.CampaignDiscount+ " discount");
        }

        public void Delete(Campaign camp)
        {
            Console.WriteLine(camp.CampaignName + " Deleted");
        }

        public void Update(Campaign camp)
        {
            Console.WriteLine(camp.CampaignName + " Updated");
        }
    }
}
