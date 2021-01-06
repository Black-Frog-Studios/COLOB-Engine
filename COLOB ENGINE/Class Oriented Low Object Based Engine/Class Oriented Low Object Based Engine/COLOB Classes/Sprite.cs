using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Class_Oriented_Low_Object_Based_Engine.COLOB_Classes
{
    public class Sprite : GlobalObject
    {

        //The location of the sprite png file
        public string Directory = "";
        public Bitmap spriteSprite = null;

        //Called when initialized
        public Sprite(Dir2 Position, Dir2 Scale, String Tag, String Location)
        {
            this.Position = Position;
            this.Scale = Scale;
            this.Tag = Tag;
            this.Directory = Location;

            //Go to the "Debug" file in your file explorer
            //Click on "Assets"
            //You can add in your sprites there and then add in their location
            //This engine only supports PNG files for sprites
            //When passing in the directory, DO NOT include the ".png" 

            //Load in the sprite
            Image tmp = Image.FromFile($"Assets/Art/{Directory}.png");
            spriteSprite = new Bitmap(tmp, (int)this.Scale.X, (int)this.Scale.Y);

            //Logging and registering the sprite
            FeatureRichEmbeddedDebugger.Info(this.Tag + " has been added to the " +
             "GlobalSpriteCollection");
            ColobEngine.RegisterSprite(this);
            ColobEngine.RegisterObject(this);

        }

        /*NON FUNCTIONAL
         * DO NOT USE THIS FUNCTION
        public Sprite(Dir2 Position, Dir2 Scale, Sprite reference)
        {
            this.Position = Position;
            this.Scale = Scale;
            this.Tag = reference.Tag;

            spriteSprite = reference.spriteSprite;
 

            //Logging and registering the sprite
            FeatureRichEmbeddedDebugger.Info(this.Tag + " has been added to the " +
             "GlobalSpriteCollection");
            ColobEngine.RegisterSprite(this);
            ColobEngine.RegisterObject(this);

        } */



        //Get rid of the sprite
        public void Destroy()
        {
            FeatureRichEmbeddedDebugger.Info(this.Tag + " has been removed from the " +
                "GlobalSpriteCollection");
            ColobEngine.UnregisterSprite(this);
            ColobEngine.UnregisterObject(this);

        }


    }
}
