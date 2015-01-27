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
    class TransformComponent : Component
    {
        public float rotation;
        //public enum Direction { N, NE, E, SE, S, SW, W, NW };
        public float scale;
        public Vector2 position;
        public int layer;
        public SpriteEffects effect;

        public TransformComponent(Vector2 givenPos, float givenScale, float givenRotation)
        {
            position = givenPos;
            scale = givenScale;
            rotation = givenRotation;
            //direction = Direction.E;
            layer = 0;
            effect = SpriteEffects.None;
        }
    }
}
