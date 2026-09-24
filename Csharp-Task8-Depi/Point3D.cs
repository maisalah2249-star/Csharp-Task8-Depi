using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Task8_Depi
{
    class Point3D : IComparable, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }


        public Point3D()
        {

        }

        public Point3D(int x): this ()
        {
            X = x;
        }

        public Point3D(int x, int y, int z) : this(x)
        {
            Y = y;
            Z = z;
        }

        public override string ToString()
        {

            return ($"Points are: ({X} , {Y} , {Z})");
        }

        public int CompareTo(object?  obj)
        {
            Point3D  other = (Point3D)obj;

            int result = X.CompareTo(other.X);

            if(result == 0)
            {
                result = Y.CompareTo(other.Y);
            }

            return result;

        }


        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

    }

}