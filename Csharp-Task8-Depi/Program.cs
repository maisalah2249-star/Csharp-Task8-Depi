namespace Csharp_Task8_Depi
{
    class Program
    {
        static int ReadInt(string message)
        {
            int value;

            Console.Write(message);

            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid input. Try again: ");
            }

            return value;
        }


        static void Main()
        {
            //Point3D

            Console.WriteLine("Point 3D");


            // Test ToString
            Point3D P = new Point3D(10, 10, 10);

            Console.WriteLine(P.ToString());


            // Read Point 1
            Console.WriteLine("\nEnter Point 1:");

            int x1 = ReadInt("X = ");
            int y1 = ReadInt("Y = ");
            int z1 = ReadInt("Z = ");

            Point3D P1 = new Point3D(x1, y1, z1);


            // Read Point 2
            Console.WriteLine("\nEnter Point 2:");

            int x2 = ReadInt("X = ");
            int y2 = ReadInt("Y = ");
            int z2 = ReadInt("Z = ");

            Point3D P2 = new Point3D(x2, y2, z2);


            // Display Points
            Console.WriteLine("\nP1 = " + P1);
            Console.WriteLine("P2 = " + P2);


            // Test ==
            Console.WriteLine("\nP1 == P2: " + (P1 == P2));


            // Array of Points
            Point3D[] points =
            {
                new Point3D(5, 20, 10),
                new Point3D(2, 30, 15),
                new Point3D(5, 10, 20),
                new Point3D(1, 40, 25)
            };


            // Sort
            Array.Sort(points);


            Console.WriteLine("\nSorted Points:");

            foreach (Point3D point in points)
            {
                Console.WriteLine(point);
            }


            // Clone
            Point3D clonedPoint = (Point3D)P1.Clone();

            Console.WriteLine("\nCloned Point:");
            Console.WriteLine(clonedPoint);



            //Maths
            Console.WriteLine("\nMaths");

            Console.WriteLine("Add = " + Maths.Add(10, 5));

            Console.WriteLine("Subtract = " + Maths.Subtract(10, 5));

            Console.WriteLine("Multiply = " + Maths.Multiply(10, 5));

            Console.WriteLine("Divide = " + Maths.Divide(10, 5));



           

            Console.WriteLine("\nDuaration");


            // Create Durations

            Duration D1 = new Duration(1, 10, 15);

            Duration D2 = new Duration(3600);

            Duration D3 = new Duration(7800);

            Duration D4 = new Duration(666);


            Console.WriteLine("D1 = " + D1);

            Console.WriteLine("D2 = " + D2);

            Console.WriteLine("D3 = " + D3);

            Console.WriteLine("D4 = " + D4);


            // D3 = D1 + D2

            D3 = D1 + D2;

            Console.WriteLine("\nD1 + D2 = " + D3);


            // D3 = D1 + 7800

            D3 = D1 + 7800;

            Console.WriteLine("D1 + 7800 = " + D3);


            // D3 = 666 + D3

            D3 = 666 + D3;

            Console.WriteLine("666 + D3 = " + D3);


            // D3 = ++D1

            D3 = ++D1;

            Console.WriteLine("++D1 = " + D3);


            // D3 = --D2

            D3 = --D2;

            Console.WriteLine("--D2 = " + D3);


            // D1 = D1 - D2

            D1 = D1 - D2;

            Console.WriteLine("D1 - D2 = " + D1);


            // D1 > D2

            if (D1 > D2)
            {
                Console.WriteLine("D1 is greater than D2");
            }


            // D1 <= D2

            if (D1 <= D2)
            {
                Console.WriteLine("D1 is less than or equal to D2");
            }


            // if (D1)

            if (D1)
            {
                Console.WriteLine("D1 has a duration.");
            }
            else
            {
                Console.WriteLine("D1 is zero.");
            }


            // DateTime Object

            DateTime date = DateTime.Now;

            Console.WriteLine("\nDateTime Object:");

            Console.WriteLine(date);
        }
    }
}
