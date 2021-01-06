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

        //something
        public static int ObjectNetworkTargetedAction_ReadyIndexOffice()
        {
            return 1;
        }


    }
}
