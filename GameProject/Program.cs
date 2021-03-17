using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {  
            Gamer gamer1 = new Gamer();

            gamer1.Id = 2;
            gamer1.FirstName = "HASAN";
            gamer1.LastName = "DOĞRU";
            gamer1.BirthDay = 1987;
            gamer1.IdentityNumber = 9865475;

            GamerManager gamerManager = new GamerManager(new UserValidateManager());
            gamerManager.Add(new Gamer{Id = 1, BirthDay = 1990, FirstName = "RIDVAN", LastName = "BOZKIR", IdentityNumber = 123654987});
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);

            SalesManager salesManager = new SalesManager();

            salesManager.Buy(gamer1);

            Sales sales = new Sales();

            sales.Id = 1;
            sales.GamerId = 2;
            sales.Number = 54874;
            sales.SalesDetails = "Bilgisayar satışı";

            CampaignManager campaignManager = new CampaignManager();

            campaignManager.Add(sales);

        }
    }
}
