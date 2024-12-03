using System;

namespace character
{
    class Character
    {
        private string name;
        private int health;
        private int damage;
        private int defence;

        public Character(string name, int health, int damage, int defence)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
            this.defence = defence;
        }

        public Character()
        {
            this.name = "Unknown";
            this.health = 100;
            this.damage = 1;
            this.defence = 0;
        }

        public void showStats()
        {
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Health: {this.health}");
            Console.WriteLine($"Damage: {this.damage}");
            Console.WriteLine($"Defence: {this.defence}");
        }

        public void takeDamage( int damage )
        {
            this.health = Math.Max(this.health - Math.Max(damage, 0), 0);
        }

        public void attack(Character target)
        {
            target.takeDamage(this.damage);
        }
    }
}