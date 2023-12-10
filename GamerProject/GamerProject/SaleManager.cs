using System;

namespace GamerProject
{
    public class SaleManager : ISaleService

    {
         ICampaignService _campaignService;
         private IGamerService _gamerService;
        

        public SaleManager(ICampaignService campaignService, IGamerService gamerService)
        {
            _campaignService = campaignService;
            _gamerService = gamerService;
        }

        public SaleManager(IGamerService campaignService)
        {
            throw new NotImplementedException();
        }

        public void Add(Sale sale)
        {
            Console.WriteLine(sale.Gamer.FirstName + " " + sale.Gamer.LastName + " bought " + sale.Game.Name + " for " + sale.Price + " TL on " + sale.SaleDate + ".");
        }

        public void Remove(Sale sale)
        {
            Console.WriteLine("Oyun satışı silindi");
        }

        public void Update(Sale sale)
        {
            Console.WriteLine("Oyun satışı güncellendi");
        }
    }
}