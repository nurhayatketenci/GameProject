using GameProject.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class ValidationManager:IUserValidationService
    {
       public bool Validate(Gamers gamer)
        {
            if (gamer.GamerId == 1 && gamer.GamerName == "NUR" && gamer.GamerSurname == "HAYAT" && gamer.BirthYear == 2000 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
