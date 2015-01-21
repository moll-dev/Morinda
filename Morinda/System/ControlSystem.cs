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
    class ControlSystem : System
    {
        Input input;

        public ControlSystem(EntityManager givenManager) : base(givenManager)
        {
           
        }

        public override void update(float dt)
        {
            Console.WriteLine("hey there");
        }

        public void updateState(KeyboardState keyState, MouseState mouseState)
        {

        }
    }
}
