using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Oriented_Low_Object_Based_Engine.COLOB_Classes
{
    public class GlobalObject
    {
        public Dir2 Position = null;
        public Dir2 Scale = null;
        public string Tag = "";

        //If the object is colliding, return that object
        public GlobalObject IsColliding(string tag)
        {

            foreach (GlobalObject b in ColobEngine.GlobalCollection)
            {
                if(b.Tag == tag)
                {
                    if(this.Position.X < b.Position.X + b.Scale.X && this.Position.X + this.Scale.X > b.Position.X && 
                    this.Position.Y < b.Position.Y + b.Scale.Y && this.Position.Y + this.Scale.Y > b.Position.Y)
                    {
                        return b;
                    } 

                }
            }

            return null;
        }


    }
}
