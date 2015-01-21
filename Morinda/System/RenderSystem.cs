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
        
        public override RenderSystem(EntityManager givenManager, SpriteBatch givenSpriteBatch) : base(givenManager)
        {
            spriteBatch = givenSpriteBatch;
        }


        public void update(float dt)
        {
            List<Entity> entities = manager.getEntitiesWithComponent<RenderComponent>();

            foreach (Entity entity in entities)
            {
                RenderComponent renderComponent = (RenderComponent) manager.getComponentfromEntity<RenderComponent>(entity);
                draw(renderComponent);
            }
        }

        private void draw(RenderComponent renderComponent)
        {
            spriteBatch.Begin();

            //Draw sprite given stuff from renderComponent
            spriteBatch.Draw(renderComponent.texture, new Rectangle(100, 100, renderComponent.texture.Width, renderComponent.texture.Height), Color.White);

            spriteBatch.End();
        }
    }
}
