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
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        double t = 0.0;
        double dt = 0.01;

        double currentTime = 0.0;
        double accumulator = 0.0;

        EntityManager em;
        RenderSystem rs;
        InputSystem ks;
        ActionSystem cs;
        Entity e1;

        Command walkCommand;
        Dictionary<Keys, Command> keymap;

        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //DUMB TEST CODE HERE

            base.Initialize();

            em = new EntityManager();

            HealthSystem hs = new HealthSystem(em);
            rs = new RenderSystem(em, spriteBatch);
            ks = new InputSystem(em);
            cs = new ActionSystem(em);
            
            e1 = em.createEntity();

            walkCommand = new WalkCommand(em);
            keymap = new Dictionary<Keys, Command>();
            keymap.Add(Keys.W, walkCommand);


            Component r1 = new RenderComponent(Content.Load<Texture2D>("guy"));
            Component t1 = new TransformComponent(new Vector2(200, 100), 1.0f, 0.0f);
            Component c1 = new HealthComponent(100);
            Component i1 = new InputComponent(keymap);

            em.addComponentToEntity(c1, e1);
            em.addComponentToEntity(t1, e1);
            em.addComponentToEntity(r1, e1);
            em.addComponentToEntity(i1, e1);

        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);

            //foreach (Keys key in Keyboard.GetState().GetPressedKeys())
            //{
            //    Console.Write(key);
            //}
            //Console.WriteLine();

            Keys[] keys = Keyboard.GetState().GetPressedKeys();

            foreach (Keys key in keys)
            {
                Console.Write(key.ToString());
                /*
                if (keymap.ContainsKey(key))
                {
                    Console.WriteLine(key);
                    keymap[key].execute(e1);
                }
                 */
            }

            if (keys.Length > 0)
                Console.WriteLine();

            //ks.update((float) dt);
            //cs.update((float) dt);


            GraphicsDevice.Clear(Color.DarkSeaGreen);

            double newTime = gameTime.ElapsedGameTime.Milliseconds;
            double frameTime = newTime - currentTime;
           
            currentTime = newTime;

            accumulator += frameTime;

            while( accumulator >= dt )
            {

                //Do physics shit here

                t += dt;
                accumulator -= dt;
            }

        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkSlateBlue);
            base.Draw(gameTime);
            rs.update((float)dt);
        }
    }
}
