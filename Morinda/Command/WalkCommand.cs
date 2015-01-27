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
    class WalkCommand : Command
    {
        public EntityManager entityManager;

        public WalkCommand(EntityManager givenEntityManager)
        {
            entityManager = givenEntityManager;
        }

        public void execute(Entity entity)
        {
            //Console.Write("Updated ");
            TransformComponent tc = entityManager.getComponentfromEntity<TransformComponent>(entity);
            tc.position = new Vector2(tc.position.X, tc.position.Y + 5);


        }
    }
}
