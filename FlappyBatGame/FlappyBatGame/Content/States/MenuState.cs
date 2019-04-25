using System;
using System.Collections.Generic;
using Flappy_Bat.Content.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Flappy_Bat.Content.States
{
    class MenuState : State
    {
        private List<Component> _components;

        public MenuState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base(game, graphicsDevice, content)
        {
            
            SpriteFont buttonFont = content.Load<SpriteFont>("Fonts/TimesNewRoman20");
            Texture2D buttonTexture = content.Load<Texture2D>("Controls/Button");


            Button newGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(300, 200),
                Text = "New Game",
                
            };
            newGameButton.Click += NewGameButton_Click;

            Button loadGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(300, 250),
                Text = "Load Game",
            };
            loadGameButton.Click += LoadGameButton_Click;

            Button quitGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(300, 300),
                Text = "Quit Game",
            };
            quitGameButton.Click += QuitGameButton_Click; ;




            _components = new List<Component>()
            {
                newGameButton,
                loadGameButton,
                quitGameButton,

            };
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            foreach (Button component in _components)
            {
                component.Draw(gameTime, spriteBatch);
            }

            spriteBatch.End();
        }
        public override bool GetStateType()
        {
            Console.WriteLine("MenuState");
            return false;
        }
        private void LoadGameButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Load Game");
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            // Change to a new State
            _game.AssignStart();
            Console.WriteLine("NewGame Here");
            _game.ChangeState(new GameState(_game, _graphicsDevice, _content));
        }

        public override void PostUpdate(GameTime gameTime)
        {
            // REMOVE SPRITES IF NOT NEEDED
            ;
        }

        public override void Update(GameTime gameTime)
        {
            foreach (Button component in _components)
            {
                component.Update(gameTime);
            }
        }

        private void QuitGameButton_Click(object sender, EventArgs e)
        {
                _game.Exit();
        }

      

   

        
    }
}

