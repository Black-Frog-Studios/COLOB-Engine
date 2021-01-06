using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Class_Oriented_Low_Object_Based_Engine.COLOB_Classes
{
    public class Primitive : GlobalObject
    {

        public Color color = Color.Red;

        //Called when initialized
        //Primitive shape = new Primitive(new Dir2(15, 3), new Dir2(2, 2), "Rectangle", Color.Blue);
        public Primitive(Dir2 pos, Dir2 scale, string Tag, Color color)
        {
            this.Position = pos;
            this.Scale = scale;
            this.Tag = Tag;
            this.color = color;
            FeatureRichEmbeddedDebugger.Info(this.Tag + " has been added to the " +
                "GlobalPrimitiveCollection");
            ColobEngine.RegisterPrimitive(this);
            ColobEngine.RegisterObject(this);
        }

        //Get rid of the primitive
        public void Destroy()
        {
            FeatureRichEmbeddedDebugger.Info(this.Tag + " has been removed from the " +
                "GlobalPrimitiveCollection");
            ColobEngine.UnregisterPrimitive(this);
            ColobEngine.UnregisterObject(this);
        }

    }
}
