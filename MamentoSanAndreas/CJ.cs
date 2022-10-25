using System;
namespace MamentoSanAndreas
{
    public class CJ
    {
        private int health;
        private int patrons;
        private int money;

        public CJ(int health, int money, int patrons)
        {
            this.health = health;
            this.patrons = patrons;
            this.money = money;
        }

        public void Shoot()
        {
            if (patrons > 0)
            {
                patrons--;
                Console.WriteLine($"Shoot. Current patrons {patrons}");
            }
            else
            {
                Console.WriteLine("No more patrons.");
            }
        }

        public void Crime()
        {
            if (health > 0)
            {
                health--;
                Console.WriteLine($"The police are after me. Health: {health}");
            }
            else
            {
                Console.WriteLine("You are under arrest.Pay bail");
                money--;
            }
        }

        public HeroMemento Save()
        {
            Console.WriteLine($"You have made a save. Patrons:{patrons}, Health: {health}, Money: {money}");
            return new HeroMemento(patrons, health, money);
        }

        public void RestoreState(HeroMemento cj)
        {
            this.patrons = cj.Patrons;
            this.health = cj.Health;
            this.money = cj.Money;

            Console.WriteLine($"Current Patrons: {patrons}, Health: {health}, Money: {money}");
        }
    }
}