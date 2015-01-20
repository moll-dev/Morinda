using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Morinda
{
    /// <summary>
    /// System base class
    /// </summary>
    class System
    {
        public EntityManager manager;
        /// <summary>
        /// Updates the system given delta time (dt)
        /// </summary>
        /// <param name="dt"></param>
        void update(float dt);

        public System(EntityManager givenManager)
        {
            manager = givenManager;
        }
    }
}
