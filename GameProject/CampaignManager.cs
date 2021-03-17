using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager:ICampaignService
    {
        public void Add(Sales sales)
        {
            Console.WriteLine("Kampanya eklendi." +sales.SalesDetails + "nda %21 kampanya var");
        }
    }
}
