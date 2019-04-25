using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace flappybird
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Scrolling scrolling1;
        Scrolling scrolling2;

        Trees scrolling3;
        Trees scrolling4;

        Stars scrolling5;
        Stars scrolling6;

        ScrollingWalls Walls;





        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";


            graphics.PreferredBackBufferWidth = ScreenGlobals.SCREEN_WIDTH;
            graphics.PreferredBackBufferHeight = ScreenGlobals.SCREEN_HEIGHT;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //Sky
            scrolling1 = new Scrolling(Content.Load<Texture2D>("Sky"), new Rectangle(0, 0, ScreenGlobals.SCREEN_WIDTH, ScreenGlobals.SCREEN_HEIGHT));

            scrolling2 = new Scrolling(Content.Load<Texture2D>("Sky"), new Rectangle(ScreenGlobals.SCREEN_WIDTH, 0, ScreenGlobals.SCREEN_WIDTH, ScreenGlobals.SCREEN_HEIGHT));
            //Trees
            scrolling3 = new Trees(Content.Load<Texture2D>("Trees"), new Rectangle(0, 0, ScreenGlobals.SCREEN_WIDTH, ScreenGlobals.SCREEN_HEIGHT));
            scrolling4 = new Trees(Content.Load<Texture2D>("Trees"), new Rectangle(ScreenGlobals.SCREEN_WIDTH, 0, ScreenGlobals.SCREEN_WIDTH, ScreenGlobals.SCREEN_HEIGHT));

            //Stars
            scrolling5 = new Stars(Content.Load<Texture2D>("Stars"), new Rectangle(0, 0, ScreenGlobals.SCREEN_WIDTH, ScreenGlobals.SCREEN_HEIGHT));
            scrolling6 = new Stars(Content.Load<Texture2D>("Stars"), new Rectangle(ScreenGlobals.SCREEN_WIDTH, 0, ScreenGlobals.SCREEN_WIDTH, ScreenGlobals.SCREEN_HEIGHT));

            Walls = new ScrollingWalls(Content.Load<Texture2D>("Columns"), new Vector2(230, 85), new Rectangle(160, 0, 32, 96));


        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
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

            // TODO: Add backgrounds here


            //If first pictures left edge + its whole width is less than or equal to 0
            //Then, 

            //Sky
            if(scrolling1.rectangle.X + scrolling1.texture.Width <=0)
                scrolling1.rectangle.X = scrolling2.rectangle.X + scrolling2.texture.Width;
            
            if (scrolling2.rectangle.X + scrolling2.texture.Width <= 0)
                scrolling2.rectangle.X = scrolling1.rectangle.X + scrolling1.texture.Width;


            //Trees
            if (scrolling3.rectangle.X + scrolling3.texture.Width <= 0)
                scrolling3.rectangle.X = scrolling4.rectangle.X + scrolling4.texture.Width;

            if (scrolling4.rectangle.X + scrolling4.texture.Width <= 0)
                scrolling4.rectangle.X = scrolling3.rectangle.X + scrolling3.texture.Width;


            //Stars
            if (scrolling5.rectangle.X + scrolling5.texture.Width <= 0)
                scrolling5.rectangle.X = scrolling6.rectangle.X + scrolling6.texture.Width;

            if (scrolling6.rectangle.X + scrolling6.texture.Width <= 0)
                scrolling6.rectangle.X = scrolling5.rectangle.X + scrolling5.texture.Width;



            scrolling1.Update();
            scrolling2.Update();

            scrolling3.Update();
            scrolling4.Update();

            scrolling5.Update();
            scrolling6.Update();



            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            

            scrolling1.Draw(spriteBatch);
            scrolling2.Draw(spriteBatch);

            scrolling3.Draw(spriteBatch);
            scrolling4.Draw(spriteBatch);

            scrolling5.Draw(spriteBatch);
            scrolling6.Draw(spriteBatch);

            Walls.Draw(spriteBatch);

            
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
