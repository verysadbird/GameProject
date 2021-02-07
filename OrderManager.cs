using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager
    {
        IUserValidationService _userValidationService;

        public OrderManager(IUserValidationService userValidation)
        {
            _userValidationService = userValidation;
        }
        public void AddOrder(Gamer gamer, Games game)
        {
            if(_userValidationService.Validate(gamer) == true)
                Console.WriteLine(gamer.Name + " kullanıcısı " + game.GameName + " oyununu aldı");
            else
                Console.WriteLine("İşlem başarısız");
        }

        public void AddOrder(Gamer gamer, Games game, Campaigns campaign)
        {
            Console.WriteLine(gamer.Name + " kullanıcısı " + game.GameName + " oyununu aldı\nKampanyanız: " + campaign.CampaignName);
        }


        public void OrderCancellation(Gamer gamer, Games game)
        {
            Console.WriteLine(gamer.Name + " kullanıcısının " + game.GameName + " oyunu için siparişi iptal edildi ");
        }


    }
}
