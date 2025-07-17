using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace VorbereitungIHK
{
    abstract class LivingEntity
    {
        // Atribute
        private string name;
        private int age;
        private int health;
        private int energyLevel;

        // Constructor
        public LivingEntity(string name, int age, int health, int energyLevel)
        {
            this.name = name;
            this.age = age;
            this.health = health;
            this.energyLevel = energyLevel;
        }
        // Public Get-Set Methoden
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        public int EnergyLevel
        {
            get { return this.energyLevel; }
            set { this.energyLevel = value; }
        }

        public abstract void Survive();
        public abstract void Feed(int amount, string FoodType);
        public abstract void getEnvironment(EnvironmentParameters env);
        public void React(EnvironmentParameters env)
        {
            if (env.Temperatur < 18 || env.Temperatur > 32)
            {
                EnergyLevel -= 10;
                System.Console.WriteLine("Es ist zu kalt oder zu heiß!");
            }
            if (env.PhWert < 6 || env.PhWert > 8)
            {
                Health -= 5;
                System.Console.WriteLine("Lebewesen ist krank!");
            }
        }
        public void Reproduce()
        {
            System.Console.WriteLine("Reproduktion is done!");
        }
    }
}