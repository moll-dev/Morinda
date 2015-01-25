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
    class ActionComponent
    {
        public Dictionary<Keys, Command> actionMap;

        public ActionComponent(Dictionary<Keys, Command> givenActionMap)
        {
            actionMap = givenActionMap;
        }
    }
}
