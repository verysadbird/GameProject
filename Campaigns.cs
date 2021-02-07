using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Campaigns : ICampaignService
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string Description { get; set; }
    }
}
