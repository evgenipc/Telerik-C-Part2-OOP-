using System;

    
 public struct Point3D
    {
        //  point properties
        public int x;
        public int y;
        public int z;
        //  center properties - readonly
        private static readonly int x0 = 0;
        private static readonly int y0 = 0;
        private static readonly int z0 = 0;
        //  Constructor 
        public Point3D(int x,int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

         // overriding ToString method
        public override string ToString()
        {
            string result;

            result = "X = " + this.x + "\nY = " + this.y + "\nZ = " + this.z;
            return result;
        }
        // Method returning the coordinates
        public static object CenterCoordinates()
        {
            return new Point3D(x0, y0, z0);
        }

  
    }


