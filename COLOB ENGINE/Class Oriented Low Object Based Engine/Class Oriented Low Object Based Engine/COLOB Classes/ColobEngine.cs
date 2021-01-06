using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Class_Oriented_Low_Object_Based_Engine.COLOB_Classes
{

    class GraphicallyImmersiveUnit : Form
    {
        public GraphicallyImmersiveUnit()
        {
            CustomRenderedNetworkTool();
        }

        private void CustomRenderedNetworkTool()
        {
            //Needed to create a smooth window
            this.DoubleBuffered = true;
        }

    }


    public abstract class ColobEngine
    {

        #region Global Variables

        private Dir2 ScreenSize = new Dir2(1500, 1000);
        private string gameTitle = "Game Name";
        private GraphicallyImmersiveUnit Window = null;
        private Thread GameLoopThread = null;

        //These variables can be overrided by the game class
        protected Color BackColor = Color.Red;
        protected Dir2 camPos = Dir2.Zero();
        protected Dir2 camScale = Dir2.One();

        //Global list of all primitives
        public static List<Primitive> GlobalPrimitiveCollection = new List<Primitive>();

        //Global list of all sprites
        public static List<Sprite> GlobalSpriteCollection = new List<Sprite>();

        //List of everything
        public static List<GlobalObject> GlobalCollection = new List<GlobalObject>();

        #endregion

        //Called when initialized
        public ColobEngine(Dir2 ScreenSize, string Title)
        {

            FeatureRichEmbeddedDebugger.Generic("Thank you for using the COLOB Engine");
            FeatureRichEmbeddedDebugger.Generic("Thank you for using the COLOB Engine");

            //Set basic game information
            this.ScreenSize = ScreenSize;
            this.gameTitle = Title;

            //Create the game window
            Window = new GraphicallyImmersiveUnit();
            Window.Size = new Size(1000, 600);
            Window.Text = this.gameTitle;
            Window.Paint += RenderGame; /*Window.Paint will render the game for you*/
            Window.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Window.FormClosed += BackwardsCompatibleEdificeForTerminatingHacks;

            //User input
            Window.KeyDown += Window_KeyDown;
            Window.KeyUp += Window_KeyUp;

            //Call the Start method BEFORE the game runs
            OnStart();

            GameLoopThread = new Thread(GameLoop);
            GameLoopThread.Start();


            //Begins running a standard application message loop on the current thread, 
            //and makes the specified form visible.
            Application.Run(Window);

        }

        //Stop the thread when we close the window
        private void BackwardsCompatibleEdificeForTerminatingHacks(object sender, FormClosedEventArgs e)
        {
            GameLoopThread.Abort();
        }

        //Check for not pressing a key (not abstract)
        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            GetKeyUp(e);
        }

        //Check for pressing a key (not abstract)
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            GetKeyDown(e);
        }

        #region Tracking Natives System

        //This region includes several lists wich track ALL global objects

        //Called when creating a new primitive
        //All primitives are tracked within this list
        public static void RegisterPrimitive(Primitive shape)
        {
            GlobalPrimitiveCollection.Add(shape);
        }

        //Called to remove a primitive from the list
        public static void UnregisterPrimitive(Primitive shape)
        {
            GlobalPrimitiveCollection.Remove(shape);
        }

        //Called when creating a new sprite
        //All sprites are tracked within this list
        public static void RegisterSprite(Sprite shape)
        {
            GlobalSpriteCollection.Add(shape);
        }

        //Called to remove a sprite from the list
        public static void UnregisterSprite(Sprite shape)
        {
            GlobalSpriteCollection.Remove(shape);
        }

        //Called when creating a new GlobalObject
        //All objects are tracked within this list
        public static void RegisterObject(GlobalObject shape)
        {
            GlobalCollection.Add(shape);
        }

        //Called to remove an object from the list
        public static void UnregisterObject(GlobalObject shape)
        {
            GlobalCollection.Remove(shape);
        }

        #endregion


        //This is done in order to refresh the GUI (not GIU) consistently
        void GameLoop()
        {
            //As long as the thread is running, the loop will continue to be called
            while(GameLoopThread.IsAlive)
            {
                try
                {
                    OnDraw();
                    Window.BeginInvoke((MethodInvoker)delegate { Window.Refresh(); });
                    OnUpdate();
                    Thread.Sleep(10);
                }
                catch
                {
                    FeatureRichEmbeddedDebugger.Warning("Window has not been found!");
                }
            }
        }

        //By default, this is not refreshed consistently. 
        //This will be changed through the GameLoop thread
        private void RenderGame(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Background color
            g.Clear(BackColor);

            //Set camera position
            g.TranslateTransform(camPos.X, camPos.Y);

            //Set camera scale
            g.ScaleTransform(camScale.X, camScale.Y);


            //Load in each created primitive
            foreach (Primitive shape in GlobalPrimitiveCollection)
            {
                g.FillRectangle(new SolidBrush(shape.color), shape.Position.X, 
                shape.Position.Y, shape.Scale.X, shape.Scale.Y);
            }

            //Load in each created primitive
            foreach (Sprite sprite in GlobalSpriteCollection)
            {
                g.DrawImage(sprite.spriteSprite, sprite.Position.X, sprite.Position.Y, 
                    sprite.Scale.X, sprite.Scale.Y);
            }


        }

        #region Abstract Functions

        //The following functions are abstract and must be 
        //overridden by the children class (the game class)

        //Called at the Start
        public abstract void OnStart();

        //For movement, input, physics, etc
        public abstract void OnUpdate();

        //For drawing, graphics, etc
        public abstract void OnDraw();

        //Check for a key being pressed (abstract, will be overridden)
        public abstract void GetKeyDown(KeyEventArgs e);
        
        //Check for a key not being pressed (abstract, will be overridden)
        public abstract void GetKeyUp(KeyEventArgs e);

        #endregion

    }
}
