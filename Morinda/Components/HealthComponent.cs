using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Morinda
{
    class HealthComponent : Component
    {
        public int healthPoints { get; set; }
        public bool isAlive { get; set; }

        public HealthComponent(int GivenHealth)
        {
            healthPoints = GivenHealth;
            isAlive = true;
        }
    }
}
