using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace VorbereitungIHK
{
    class Fish : Aquatic
    {
        public Fish(string name, int age, int health, int energyLevel) : base(name, age, health, energyLevel)
        {

        }
        public override void Feed(int amount, string FoodType)
        {
            if (amount < 10)
            {
                EnergyLevel += 10;
            }
            else if (amount > 10 && amount < 20)
            {
                EnergyLevel += 20;
            }
            else if (amount > 20 && amount < 30)
            {
                EnergyLevel += 30;
            }
            else
            {
                for (int i = 0; i <= 100; i++)
                {
                    if (i + EnergyLevel == 100)
                    {
                        EnergyLevel = i;
                    }
                    else
                    {
                        System.Console.WriteLine("Es ist zu viel zu essen!");
                    }
                }
            }
        }
        public override void Survive()
        {
            System.Console.WriteLine("Survival is done!");
        }
        public override void getEnvironment(EnvironmentParameters env)
        {
            if (env.Temperatur < 18 || env.Temperatur > 32 && env.Luftfeuchtigkeit < 50 && env.Lichtintensitaet < 30)
            {
                System.Console.WriteLine("Environment is bad!");
            }
            else
            {
                System.Console.WriteLine("Environement is good!");
            }
        }
    }
}