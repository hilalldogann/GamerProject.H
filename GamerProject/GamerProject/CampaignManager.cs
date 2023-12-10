using System;

namespace GamerProject
{
    public class CampaignManager: ICampaignService
    {
        ICampaignService _campaignService;
        IGamerService _gamerService;

        public CampaignManager(ICampaignService campaignService, IGamerService gamerService)
        {
            _campaignService = campaignService;
            _gamerService = gamerService;
        }

        public CampaignManager(IGamerService campaignService)
        {
            throw new NotImplementedException();
        }


        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Kaydedildi");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}