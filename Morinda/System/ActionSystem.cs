#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion


namespace Morinda
{
    /// <summary>
    /// System that controls your entities. Perhaps a bit beyond my scope considering it is
    /// written to be generic. AI and Network should also be able to control entities.
    /// </summary>
    class ActionSystem : System
    {
        public ActionSystem(EntityManager givenManager) : base(givenManager)
        {

        }

        public void update(float dt)
        {
            Console.WriteLine("hey there");

            /*
             *  Get respective input from sources either Player, AI, or Network
             */
            List<Entity> entities = manager.getEntitiesWithComponent<InputComponent>();

            foreach (Entity entity in entities)
            {
                InputComponent inputComponent = manager.getComponentfromEntity<InputComponent>(entity);
                
                
            }
        }

        public void updateState(KeyboardState keyState, MouseState mouseState)
        {

        }
    }
}
