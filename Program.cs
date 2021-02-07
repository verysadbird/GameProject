using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Gamer gamer1 = new Gamer();
            gamer1.TC = 12345;
            gamer1.Name = "Game";
            gamer1.Surname = "Boi";
            gamer1.ID = 1;
            gamer1.DateOfBirth = 1987;

            Gamer gamer2 = new Gamer();
            gamer2.TC = 56789;
            gamer2.Name = "Tech";
            gamer2.Surname = "Girl";
            gamer2.DateOfBirth = 1996;


            AccountManager accountManager = new AccountManager(new UserValidationManager());
            accountManager.Add(gamer1);

            Campaigns campaign1 = new Campaigns();
            campaign1.CampaignName = "10% İndirim";
            campaign1.CampaignId = 1;
            campaign1.Description = "Her oyunda 10% indirim";
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            Games game1 = new Games();
            game1.GameId = 5;
            game1.GameName = "Cyberpunk 2077";
            game1.Description = "Cyberpunk";
            Orders order1 = new Orders();
            order1.OrderId = 2;

            OrderManager orderManager = new OrderManager(new UserValidationManager());
            orderManager.AddOrder(gamer1, game1);

            orderManager.AddOrder(gamer2, game1, campaign1);



        }
    }
}
