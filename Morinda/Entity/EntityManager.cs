using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Morinda
{
    /// <summary>
    /// Manages entities
    /// </summary>
    class EntityManager
    {
        public Dictionary<Entity, List<Component>> entityComponentMap;

        /// <summary>
        /// Constructs a new Entity Manager
        /// </summary>
        public EntityManager()
        {
            entityComponentMap = new Dictionary<Entity, List<Component>>();
        }


        /// <summary>
        /// Create a new Entity
        /// </summary>
        /// <returns>newly created Entity</returns>
        public Entity createEntity()
        {
            // NOTE: I'm using the default method of generating GUID's
            Entity newEntity = new Entity();
            entityComponentMap.Add(newEntity, new List<Component>());
            return newEntity;
        }


        public void addComponentToEntity(Component component, Entity entity)
        {
            //addComponent(Component component)toEntity(Entity entity)
            entityComponentMap[entity].Add(component);      
        }


        public List<Entity> getEntitiesWithComponent<T>()
        {
            List<Entity> entitiesWithComponent = new List<Entity>();

            // Iterate through entities...
            foreach (var entityComponents in entityComponentMap)
            {
                // ...and their components
                foreach (Component component in entityComponents.Value)
                {
                    // Add an entity to the list if it contains the component
                    if(component.GetType() == typeof(T))
                    {
                        entitiesWithComponent.Add(entityComponents.Key);
                    }
                }
            }
            return entitiesWithComponent;
        }


        public T getComponentfromEntity<T>(Entity entity)
        {
            foreach(Component component in entityComponentMap[entity])
            {
                if(component.GetType() == typeof(T))
                {
                    return (T)component;
                }
            }
            return default(T);
        }


        public List<Component> getComponents(Entity entity)
        {
            return entityComponentMap[entity];
        }
    }
}
