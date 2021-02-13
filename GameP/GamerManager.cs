using GameProject.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamers gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine(gamer.GamerName + "gamer added ");
            }
            else
            {
                Console.WriteLine(gamer.GamerName + "could not be added ");
            }
           
        }

        public void Delete(Gamers gamer)
        {
            Console.WriteLine(gamer.GamerName + "gamer deleted ");
        }

        public void Update(Gamers gamer)
        {
            Console.WriteLine(gamer.GamerName + "gamer updated ");
        }
    }
}
