using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign camp);
        void Delete(Campaign camp);
        void Update(Campaign camp);
    }
}
