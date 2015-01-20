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
    /// Entity Class:
    ///     Encapsulates a GUID
    /// </summary>
    class Entity
    {
        // Encapsulated ID
        public Guid id;

        /// <summary>
        /// Generates an Entity based on a givenGuid
        /// </summary>
        /// <param name="givenGuid"></param>
        public Entity(Guid givenGuid)
        {
            id = givenGuid;
        }

        /// <summary>
        /// Generates an Entity by grabbing a new GUID
        /// </summary>
        public Entity()
        {
            id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return id.ToString();
        }
    }
}
