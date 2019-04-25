using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Flappy_Bat.Content.States
{

    

    public class GameState : State
    {
        Player mPlayer;
        Game1 game;

        public GameState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base (game, graphicsDevice, content)
        {
            this.game = game;
            
        }
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            
        }
        public override bool GetStateType()
        {
            return true;
        }
        public override void PostUpdate(GameTime gameTime)
        {
            ;
        }

        public override void Update(GameTime gameTime)
        {
            ;
        }
    }
}
