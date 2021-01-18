using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Class_Oriented_Low_Object_Based_Engine.COLOB_Classes
{
    //How to create a simple game in the COLOB Engine
    public class GameDemo : ColobEngine
    {

        //Primitive player;
        Sprite player;

        //Store the coin in a variable
        Sprite coin = null;

        //Store the player's last position
        //Necessary for collision
        Dir2 lastPos = Dir2.Zero();

        //Player movement axes
        bool up;
        bool down;
        bool right;
        bool left;


        //Create a level
        //2D array
        //w = wall placement
        //c = coin placement
        //p = player placement
        string[,] Map =
        {
           { "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w" },
            { "w", "", "", "", "w", "", "", "", "", "", "", "", "w", "", "", "", "", "c", "w" },
            { "w", "p", "w", "", "", "", "w", "", "", "", "w", "", "", "", "w", "", "", "", "w" },
            { "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w", "w" }, 
            
        };

        public GameDemo() : base(new Dir2(750, 600), "Colobian Game Sample") { }

        public override void OnStart()
        {

            //Overriding the bacgkrund color at the start of the game
            BackColor = Color.Gray;

            //Set the camera position
            camPos.X = 50;
            camPos.Y = 150;

            //Set the camera scale
            camScale.X = 0.7f;
            camScale.Y = 0.7f;

            //Replacing the characters with their proper sprites
            for (int i = 0; i < Map.GetLength(1); i++)
            {
                for(int j = 0; j <Map.GetLength(0); j++)
                {
                    if(Map[j,i] == "w")
                    {
                        new Primitive(new Dir2(i * 60, j * 60), new Dir2(64, 64), "Ground", Color.Black);
                    }
                    if (Map[j,i] == "c")
                    {
                        coin = new Sprite(new Dir2(i * 57, j * 65), new Dir2(100, 100), "Coin", "Environment/SampleCoin");                     
                    }

                    if (Map[j, i] == "p")
                    {
                        player = new Sprite(new Dir2(i * 65, j * 60), new Dir2(36, 36), "Player", "Character/SamplePlayer");
                        lastPos.X = player.Position.X;
                        lastPos.Y = player.Position.Y;
                    }

                }
            }

        }
        public override void OnDraw()
        {
            //There isn't anything to put here in this example
        }

        
        public override void OnUpdate()
        {

            #region Movement
            //If a certain direction is called upon, add your current position towards that direction
            //By using UniversalBrain.AddDir2(player.Position, direction);
            //(Up and down axes appear to be inverted) 
            if (up) { player.Position = UniversalBrain.AddDir2(player.Position, Dir2.Down()); } 

            if(down) { player.Position = UniversalBrain.AddDir2(player.Position, Dir2.Up()); }

            if(right) { player.Position = UniversalBrain.AddDir2(player.Position, Dir2.Right()); }

            if(left) { player.Position = UniversalBrain.AddDir2(player.Position, Dir2.Left()); }


            #endregion

            #region Collision 
            //Collision detection

            if (player.IsColliding("Ground") != null)
            {
                //If the player collides with ground, set his current position to
                //the last position he was in prior to colliding
                FeatureRichEmbeddedDebugger.Info("Colliding!");
                player.Position.X = lastPos.X;
                player.Position.Y = lastPos.Y;
            }
            else
            {
                //If the player does not collide with ground, set his "lastPos" to his current
                lastPos.X = player.Position.X;
                lastPos.Y = player.Position.Y;
            }

            //Destroy the coin trigger
            if(player.IsColliding("Coin") != null && coin != null)
            {
                GlobalObject col = player.IsColliding("Coin");
                if(col.Tag == coin.Tag)
                {
                    coin.Destroy();
                    coin = null;
                }
            }
            #endregion


        }

        public override void GetKeyDown(KeyEventArgs e)
        {
            //Check for keys pressed, set axes to true
            if(e.KeyCode == Keys.W) { up = true; }
            if(e.KeyCode == Keys.S) { down = true; }
            if(e.KeyCode == Keys.D) { right = true; }
            if(e.KeyCode == Keys.A) { left = true; }
        }

        public override void GetKeyUp(KeyEventArgs e)
        {
            //Check for keys up, set axes to false
            if (e.KeyCode == Keys.W) { up = false; }
            if (e.KeyCode == Keys.S) { down = false; }
            if (e.KeyCode == Keys.D) { right = false; }
            if (e.KeyCode == Keys.A) { left = false; }
        }

    }
}
