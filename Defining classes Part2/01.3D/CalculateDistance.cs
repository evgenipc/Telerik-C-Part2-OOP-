using System;

class DistanceCalculations
{

    public static double Distance(Point3D PointA, Point3D PointB)
    {
        return Math.Sqrt((PointA.x - PointB.x) * (PointA.x - PointB.x) +
                         (PointA.y - PointB.y) * (PointA.y - PointB.y) +
                         (PointA.z - PointB.z) * (PointA.z - PointB.z));
    }
}
