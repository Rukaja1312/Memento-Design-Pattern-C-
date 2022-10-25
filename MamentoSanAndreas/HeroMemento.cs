using System;
namespace MamentoSanAndreas
{
    public class HeroMemento
    {
        public HeroMemento(int patrons, int health, int money)
        {
            Patrons = patrons;
            Health = health;
            Money = money;
        }

        public int Patrons { get; set; }
        public int Health { get; set; }
        public int Money { get; set; }
    }
}

