using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace FlappyBatGame
{

    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Player mPlayerSprite;

        //Scrolling scrolling1;
        //Scrolling scrolling2;

        //Trees scrolling3;
        //Trees scrolling4;

        //Stars scrolling5;
        //Stars scrolling6;

        //ScrollingWalls Walls;
        //ScrollingWalls Walls1;





        public enum GAME_STATE_ENUM
        {
            Menu,
            Playing,
            Paused,
            Dead
        }

        private GAME_STATE_ENUM _currGameState;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = ScreenGlobals.SCREEN_WIDTH;
            graphics.PreferredBackBufferHeight = ScreenGlobals.SCREEN_HEIGHT;
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
            IsMouseVisible = true;
            // TODO: Add your initialization logic here
         
            mPlayerSprite = new Player(graphics.GraphicsDevice);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            GameContent gameContent = new GameContent(Content);

            // Create a new SpriteBatch, which can be used to draw textures.

            spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here


            // Create a new SpriteBatch, which can be used to draw textures.


            ////Sky
            //scrolling1 = new Scrolling(Content.Load<Texture2D>("Sky"), new Rectangle(0, 0, ScreenGlobals.SCREEN_WIDTH, ScreenGlobals.SCREEN_HEIGHT));

            //scrolling2 = new Scrolling(Content.Load<Texture2D>("Sky"), new Rectangle(ScreenGlobals.SCREEN_WIDTH, 0, ScreenGlobals.SCREEN_WIDTH, ScreenGlobals.SCREEN_HEIGHT));
            ////Trees
            //scrolling3 = new Trees(Content.Load<Texture2D>("Trees"), new Rectangle(0, 0, ScreenGlobals.SCREEN_WIDTH, ScreenGlobals.SCREEN_HEIGHT));
            //scrolling4 = new Trees(Content.Load<Texture2D>("Trees"), new Rectangle(ScreenGlobals.SCREEN_WIDTH, 0, ScreenGlobals.SCREEN_WIDTH, ScreenGlobals.SCREEN_HEIGHT));

            ////Stars
            //scrolling5 = new Stars(Content.Load<Texture2D>("Stars"), new Rectangle(0, 0, ScreenGlobals.SCREEN_WIDTH, ScreenGlobals.SCREEN_HEIGHT));
            //scrolling6 = new Stars(Content.Load<Texture2D>("Stars"), new Rectangle(ScreenGlobals.SCREEN_WIDTH, 0, ScreenGlobals.SCREEN_WIDTH, ScreenGlobals.SCREEN_HEIGHT));

           // Walls = new ScrollingWalls(Content.Load<Texture2D>("Columns"), new Vector2(230, 85), new Rectangle(160, 0, 32, 96));
            //Walls1 = new ScrollingWalls(Content.Load<Texture2D>("Columns"), new Vector2(230, 85), new Rectangle(160, 0, 32, 96));

            mPlayerSprite.LoadContent(this.Content);
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

            //Sky
            //if (scrolling1.rectangle.X + scrolling1.texture.Width <= 0)
            //    scrolling1.rectangle.X = scrolling2.rectangle.X + scrolling2.texture.Width;

            //if (scrolling2.rectangle.X + scrolling2.texture.Width <= 0)
            //    scrolling2.rectangle.X = scrolling1.rectangle.X + scrolling1.texture.Width;


            ////Trees
            //if (scrolling3.rectangle.X + scrolling3.texture.Width <= 0)
            //    scrolling3.rectangle.X = scrolling4.rectangle.X + scrolling4.texture.Width;

            //if (scrolling4.rectangle.X + scrolling4.texture.Width <= 0)
            //    scrolling4.rectangle.X = scrolling3.rectangle.X + scrolling3.texture.Width;


            ////Stars
            //if (scrolling5.rectangle.X + scrolling5.texture.Width <= 0)
            //    scrolling5.rectangle.X = scrolling6.rectangle.X + scrolling6.texture.Width;

            //if (scrolling6.rectangle.X + scrolling6.texture.Width <= 0)
            //    scrolling6.rectangle.X = scrolling5.rectangle.X + scrolling5.texture.Width;

            //Walls

            //Random random = new Random();
            //int heighty = random.Next(100, 200);
            //int heightchange = new int();

            //if (heighty >= 50)
            //    heightchange = 150;
            //if (heighty >= 150)
            //    heightchange = 200;
            //if (heighty >= 50)
            //    heightchange = 300;


            //Walls.texturePos.X += -10;

            //Walls.texturePos.Y = -150;

            //if (Walls.texturePos.X <= 0)
            //{

            //    Walls.texturePos.Y =Walls.texturePos.Y+ 200;
            //    Walls.texturePos.X = ScreenGlobals.SCREEN_WIDTH;

            //}



            //Walls1.texturePos.X += -10;
            //Walls1.texturePos.Y = ScreenGlobals.SCREEN_HEIGHT-150;

            //if (Walls1.texturePos.X <= 0)
            //{
            //    Walls1.texturePos.X = ScreenGlobals.SCREEN_WIDTH;

            //    Walls1.texturePos.Y +=0 ;
            //}


            //scrolling1.Update();
            //scrolling2.Update();

            //scrolling3.Update();
            //scrolling4.Update();

            //scrolling5.Update();
            //scrolling6.Update();


            // TODO: Add your update logic here


            // GAME OVER
            if (mPlayerSprite.getCurrState() == mPlayerSprite.getDead())
            {
                // probably add a game over state or menu
                Exit();
            }

         
                _currGameState = GAME_STATE_ENUM.Playing;
      
            // _currentState.PostUpdate(gameTime);
            // PLAY
#pragma warning: initialized initial gamestate for testing


            if (_currGameState == GAME_STATE_ENUM.Playing)
            {
                if (mPlayerSprite == null)
                    LoadContent();
                mPlayerSprite.Update(gameTime);
            }

            // PAUSE
            // ADD A MENU HERE


       
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);


                spriteBatch.Begin();


            //Draw the game

            //scrolling1.Draw(spriteBatch);
            //scrolling2.Draw(spriteBatch);

            //scrolling3.Draw(spriteBatch);
            //scrolling4.Draw(spriteBatch);

            //scrolling5.Draw(spriteBatch);
            //scrolling6.Draw(spriteBatch);

            //Walls.Draw(spriteBatch);
            //Walls1.Draw(spriteBatch);


            mPlayerSprite.Draw(this.spriteBatch);
                spriteBatch.End();
    


            base.Draw(gameTime);
        }
    }
}
