using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Oriented_Low_Object_Based_Engine.COLOB_Classes
{
    public class UniversalBrain
    {

        //Adding 2 directions
        public static Dir2 AddDir2(Dir2 a, Dir2 b)
        {
            float aX = a.X;
            float aY = a.Y;

            float bX = b.X;
            float bY = b.Y;

            Dir2 addedDirection = new Dir2(aX + bX, aY + bY);

            return addedDirection;
        }

        //Subtracting 2 directions
        public static Dir2 SubtractDir2(Dir2 a, Dir2 b)
        {
            float aX = a.X;
            float aY = a.Y;

            float bX = b.X;
            float bY = b.Y;

            Dir2 subtractedDirection = new Dir2(aX - bX, aY - bY);

            return subtractedDirection;
        }

        //Multiplying 2 directions
        public static Dir2 MultiplyDir2(Dir2 a, Dir2 b)
        {
            float aX = a.X;
            float aY = a.Y;

            float bX = b.X;
            float bY = b.Y;

            Dir2 multipliedDirection = new Dir2(aX * bX, aY * bY);

            return multipliedDirection;
        }

        //Dividing 2 directions
        public static Dir2 DivideDir2(Dir2 a, Dir2 b)
        {
            float aX = a.X;
            float aY = a.Y;

            float bX = b.X;
            float bY = b.Y;

            Dir2 dividedDirection = new Dir2(aX / bX, aY / bY);

            return dividedDirection;
        }

        //Add float to direction
        public static Dir2 AddFloatToDir2(Dir2 a, float b)
        {
            Dir2 newDir2 = new Dir2(b, b);
            Dir2 addedDirection = AddDir2(a, newDir2);
            return addedDirection;
        }

        //Subtract float to direction
        public static Dir2 SubtractFloatToDir2(Dir2 a, float b)
        {
            Dir2 newDir2 = new Dir2(b, b);
            Dir2 addedDirection = SubtractDir2(a, newDir2);
            return addedDirection;
        }

        //Multiply float to direction
        public static Dir2 MultiplyFloatToDir2(Dir2 a, float b)
        {
            Dir2 newDir2 = new Dir2(b, b);
            Dir2 addedDirection = MultiplyDir2(a, newDir2);
            return addedDirection;
        }

        //Add float to direction
        public static Dir2 DivideFloatToDir2(Dir2 a, float b)
        {
            Dir2 newDir2 = new Dir2(b, b);
            Dir2 addedDirection = DivideDir2(a, newDir2);
            return addedDirection;
        }

        public static float Distance(Dir2 a, Dir2 b)
        {

            float cX = (a.X - b.X) * (a.X - b.X);
            float cY = (a.Y - b.Y) * (a.Y - b.Y);
            float cZ = cX + cY;
            float d = (float)Math.Sqrt(cZ);

            return d;
        }

        //something
        public static int ObjectNetworkTargetedAction_ReadyIndexOffice()
        {
            return 1;
        }


    }
}
