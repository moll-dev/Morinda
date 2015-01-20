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
    /// Holds data for rendering
    /// </summary>
    class RenderComponent : Component
    {
        public Texture2D texture { get; set; }
        
        //Add type
        public RenderComponent(Texture2D givenTexture)
        {
            texture = givenTexture;
        }
    }
}
