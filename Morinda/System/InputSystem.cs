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
    class InputSystem : System
    {
        public InputSystem(EntityManager entityManager) : base(entityManager)
        {

        }

        public void update(float dt)
        {
            List<Entity> entities = manager.getEntitiesWithComponent<InputComponent>();

            foreach (Entity entity in entities)
            {
                InputComponent inputComponent = manager.getComponentfromEntity<InputComponent>(entity);
                
                //Get input from other places based on inputComponent's source
                inputComponent.keysPressed = Keyboard.GetState().GetPressedKeys();
            }
        }
    }
}
