namespace GamerProject
{
    internal abstract class Program
    {
        public static void Main(string[] args)
        {
            GameManager gameManager = new GameManager(null);
            CampaignManager campaignManager = new CampaignManager(null);
            SaleManager saleManager = new SaleManager(null);

            Game game = new Game
            {
                Id = 1,
                Name = "Snake Game",
                Price = 100
            };

            Gamer gamer = new Gamer
            {
                Id = 1,
                BirthYear = 1995,
                FirstName = "ENGİN",
                LastName = "DEMİROG",
                IdentityNumber = 12345678901
            };
            Campaign campaign = new Campaign
            {
                Id = 1,
                Name = "GTA",
                DiscountRate = 5
            };

            Sale sale = new Sale
            {
                Id = 1,
                Game = game,
                Gamer = gamer
            };

            saleManager.Add(sale);


        }
    }
}