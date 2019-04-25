using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace FlappyBatGame
{
    class Skins : Sprite
    {
        const string PLAYER_ASSETNAME = "!$ReBat";
        const string PLAYER_NEXT_ASSETNAME = "!$ReBat_se";
        const string PLAYER_FINAL_ASSETNAME = "!$ReBat_xe";

        public new void LoadContent(ContentManager theContentManager, string newAssetName)
        {
            base.LoadContent(theContentManager, newAssetName);
            Scale = 1.0f;
            FrameSize = Size.Width;
        }

        public new void Update(GameTime theGameTime, Vector2 speed, Vector2 direction)
        {
            base.Update(theGameTime, speed, direction);
        }

        public override void Draw(SpriteBatch theSpriteBatch)
        {
            base.Draw(theSpriteBatch);
        }
    }
}
