using System;

namespace GamerProject
{
    public class Sale
    {
        public int Id { get; set; }
        public Gamer Gamer { get; set; }
        public Game Game { get; set; }
        public double Price => Game.Price;
        public DateTime SaleDate { get; set; }
    }
}