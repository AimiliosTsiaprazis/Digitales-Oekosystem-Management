using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace VorbereitungIHK
{
    class Program
    {
        static void Main(string[] args)
        {
            EnvironmentParameters parametersAquatic = new EnvironmentParameters(20, 80, 6, 60);
            EnvironmentParameters parametersTerrestial = new EnvironmentParameters(30, 100, 8, 90);
            EnvironmentParameters parametersAmphibious = new EnvironmentParameters(25, 75, 7, 80);

            // Aquatic LivingEntities
            Aquatic fish1 = new Fish("Nemo", 2, 70, 40);
            Aquatic fish2 = new Fish("Dory", 4, 90, 60);
            fish1.React(parametersAquatic);
            fish1.Survive();
            fish1.Feed(10, "FishFoodChips");
            fish1.getEnvironment(parametersAquatic);

            // Terrestial LivingEntities
            Terrestial insect1 = new Insect("Bumblebee", 2, 50, 40);
            Terrestial insect2 = new Insect("Spider", 4, 90, 60);
            insect2.React(parametersTerrestial);
            insect2.Survive();
            insect2.Feed(4, "Eggs");
            insect2.getEnvironment(parametersTerrestial);
            
            // Amphibious LivingEntities
            Amphibian frog1 = new Frog("Froggy", 2, 50, 40);
            Amphibian frog2 = new Frog("Frogy", 4, 90, 60);
            frog1.React(parametersAmphibious);
            frog1.Survive();
            frog1.Feed(10, "MiniSpiders");
            frog1.getEnvironment(parametersAmphibious);
        }
    }
}