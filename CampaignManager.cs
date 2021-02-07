using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager
    {

        public void Add(Campaigns campaign)
        {
            Console.WriteLine("Kampanya sisteme eklendi");
        }

        public void Update(Campaigns campaign)
        {
            Console.WriteLine("Kampanya güncellendi");
        }


        public void Delete(Campaigns campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }

    }
}
