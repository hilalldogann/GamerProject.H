using System;

namespace GamerProject
{
    public class GameManager:IGameService
    {
        private IGamerService _gamerService;

        public GameManager(IGamerService gamerService)
        {
            _gamerService = gamerService;
        }

        public void Add(Game game)
        {
            Console.WriteLine("Oyun Kaydedildi");
        }

        public void Remove(Game game)
        {
            Console.WriteLine("Oyun silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi");
        }
    }
}