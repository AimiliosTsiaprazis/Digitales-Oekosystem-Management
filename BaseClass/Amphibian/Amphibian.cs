using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace VorbereitungIHK
{
    abstract class Amphibian : LivingEntity
    {
        public Amphibian(string name, int age, int health, int energyLevel) : base(name, age, health, energyLevel)
        {

        }
        
    }
}