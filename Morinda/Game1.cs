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

        RenderSystem rs;

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

            EntityManager em = new EntityManager();
            HealthSystem hs = new HealthSystem(em);
            rs = new RenderSystem(em, spriteBatch);

            Entity e1 = em.createEntity();
            Entity e2 = em.createEntity();
            Entity e3 = em.createEntity();

            Component r1 = new RenderComponent(Content.Load<Texture2D>("grass"));

            Component c1 = new HealthComponent(100);
            Component c2 = new HealthComponent(100);
            Component c3 = new HealthComponent(100);

            em.addComponentToEntity(c1, e1);
            em.addComponentToEntity(c2, e1);
            em.addComponentToEntity(r1, e1);

            hs.update(1.0f);
            hs.printHealth();
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

            GraphicsDevice.Clear(Color.CornflowerBlue);

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
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
            rs.update((float)dt);


        }
    }
}
