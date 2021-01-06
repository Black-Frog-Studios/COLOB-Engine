using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Oriented_Low_Object_Based_Engine.COLOB_Classes
{
    public class Dir2
    {

        public float X { get; set; }
        public float Y { get; set; }

        //Dir2 myDirection = Dir2();
        //Defaults the x and y to zero
        public Dir2()
        {
            X = Zero().X;
            Y = Zero().Y;
        }

        //Dir2 myDirection = Dir2(25, 32);
        //Sets the x and y values to then passed in values 
        //In this case, X = 25 and Y = 32
        public Dir2(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        //Dir2 myDirection = Dir2.Zero();
        //Defaults the x and y to zero
        public static Dir2 Zero()
        {
            return new Dir2(0, 0);
        }

        //Dir2 myDirection = Dir2.One();
        //Defaults the x and y to one
        public static Dir2 One()
        {
            return new Dir2(1, 1);
        }

        //Dir2 myDirection = Dir2.Up();
        //Defaults the x to 0 and the y to 1
        public static Dir2 Up()
        {
            return new Dir2(0, 1);
        }

        //Dir2 myDirection = Dir2.Down();
        //Defaults the x to 0 and the y to -1
        public static Dir2 Down()
        {
            return new Dir2(0, -1);
        }

        //Dir2 myDirection = Dir2.Right();
        //Defaults the x to 1 and the y to 0
        public static Dir2 Right()
        {
            return new Dir2(1, 0);
        }

        //Dir2 myDirection - Dir2.Left
        //Defaults the x to -1 and the y to 0
        public static Dir2 Left()
        {
            return new Dir2(-1, 0);
        }


    }
}
