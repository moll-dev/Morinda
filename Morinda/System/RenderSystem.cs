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
        public float time;
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
                time += dt;
                RenderComponent renderComponent = manager.getComponentfromEntity<RenderComponent>(entity);
                TransformComponent transformComponent = manager.getComponentfromEntity<TransformComponent>(entity);
                transformComponent.scale = 2     * (float) Math.Sin(time);
                transformComponent.rotation += 0.05f;
                draw(renderComponent, transformComponent);
            }
        }

        private void draw(RenderComponent rc, TransformComponent tc)
        {
            spriteBatch.Begin();

            //Calculate origin and rectangle
            Vector2 texture_origin = new Vector2(rc.texture.Width/2, rc.texture.Height/2);
            Rectangle texture_map = new Rectangle(0, 0, rc.texture.Width, rc.texture.Height);
            
            //Draw stuff using render and transform component
           
            spriteBatch.Draw(rc.texture, tc.position, texture_map, Color.White, tc.rotation, texture_origin, tc.scale, tc.effect, tc.layer);

            //SpriteBatch.Draw (rc.texture, origin, rect, Color.Wheat, (float) tc.rotation, origin, (float) tc.scale, tc.effect, (float) tc.layer);
            //spriteBatch.Draw(rc.texture, new Rectangle((int) tc.position.X, (int) tc.position.Y, rc.texture.Width, rc.texture.Height), Color.White);
            spriteBatch.End();
        }
    }
}
