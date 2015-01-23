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
        public float scale;
        public Vector2 position;

        public TransformComponent(Vector2 givenPos, float givenScale, float givenRotation)
        {
            position = givenPos;
            scale = givenScale;
            rotation = givenRotation;
        }
    }
}
