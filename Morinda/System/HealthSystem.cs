using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Morinda
{
    class HealthSystem : System
    {

        public HealthSystem(EntityManager entityManager) : base(entityManager)
        {

        }

        public void update(float dt)
        {
            List<Entity> entities = manager.getEntitiesWithComponent<HealthComponent>();

            foreach (Entity entity in entities)
            {
                HealthComponent healthComponent = (HealthComponent) manager.getComponentfromEntity<HealthComponent>(entity);
                healthComponent.healthPoints -= 40;

                if (healthComponent.healthPoints <= 0)
                {
                    healthComponent.isAlive = false;
                }
            }
        }

        public void printHealth()
        {
            List<Entity> entities = manager.getEntitiesWithComponent<HealthComponent>();

            foreach (Entity entity in entities)
            {
                HealthComponent healthComponent = (HealthComponent)manager.getComponentfromEntity<HealthComponent>(entity);
                Console.WriteLine(healthComponent.healthPoints);
            }
        }

    }
}
