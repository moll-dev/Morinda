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
    class RenderSystem : System
    {
        public SpriteBatch spriteBatch { get; set; }
        
        public RenderSystem(EntityManager givenManager, SpriteBatch givenSpriteBatch) : base(givenManager)
        {
            spriteBatch = givenSpriteBatch;
        }


        public void update(float dt)
        {
            List<Entity> entities = manager.getEntitiesWithComponent<RenderComponent>();

            foreach (Entity entity in entities)
            {
                RenderComponent renderComponent = manager.getComponentfromEntity<RenderComponent>(entity);
                TransformComponent transformComponent = manager.getComponentfromEntity<TransformComponent>(entity);

                draw(renderComponent, transformComponent);
            }
        }

        private void draw(RenderComponent rc, TransformComponent tc)
        {
            spriteBatch.Begin();

            //Draw sprite given stuff from renderComponent
            spriteBatch.Draw(rc.texture, new Rectangle((int) tc.position.X, (int) tc.position.X, rc.texture.Width, rc.texture.Height), Color.White);

            spriteBatch.End();
        }
    }
}
