using System;

    class Program
    {
        static void Main()
        {
            //CenterCoordinates
            Console.WriteLine(Point3D.CenterCoordinates().ToString());
            Console.WriteLine("");
            // New point
            Point3D point = new Point3D(3, 5, 6);
            Console.WriteLine(point.ToString());
            Console.WriteLine("");
            //Another point
            Point3D point2 = new Point3D(6, 5, 4);
            Console.WriteLine(point.ToString());
            Console.WriteLine("The distance between the above 2 points is: " + DistanceCalculations.Distance(point, point2));
            
            //Path
            Path pathList = new Path();
            pathList.path.Add(point);
            pathList.path.Add(point2);
            Console.WriteLine("First point of sequence of points");
            Console.WriteLine(pathList.path[0]);
            //Save and load
            PathStorage.SavePath(pathList);
            Path LoadedList = PathStorage.LoadPath("../../path.txt");
        }
    }

