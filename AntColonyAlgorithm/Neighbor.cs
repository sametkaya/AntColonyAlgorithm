using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntColonyAlgorithmApp
{
    class Neighbor
    {
        public static int giveId=0;
        public double distance { get; set; }
        public double pheromoneValue { get; set; }
        public List<LPoint> points;
        public double jValue;
        public double probability;
        public bool isEliminated = false;
        int id = 0;
        public Neighbor(LPoint point1,LPoint point2)
        {
            this.id = Neighbor.giveId;
            Neighbor.giveId++;

            this.points = new List<LPoint>();
            this.points.Add(point1);
            this.points.Add(point2);
            this.distance = MyMath.distanceLPoint(point1, point2);
            this.pheromoneValue = 1;
        }
        public bool isEqual(Neighbor neighbor)
        {
            if (((this.points[0].location.X== neighbor.points[0].location.X) && (this.points[0].location.Y == neighbor.points[0].location.Y)) 
                && ((this.points[1].location.X == neighbor.points[1].location.X) && (this.points[1].location.Y == neighbor.points[1].location.Y)))
            {
                return true;
            }
            else if (((this.points[1].location.X == neighbor.points[0].location.X) && (this.points[1].location.Y == neighbor.points[0].location.Y))
                && ((this.points[0].location.X == neighbor.points[1].location.X) && (this.points[0].location.Y == neighbor.points[1].location.Y)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public LPoint GetDestination(LPoint source)
        {
            if (source == this.points[0])
            {
                return this.points[1];
            }
            else
            {
                return this.points[0];
            }

        }

      

    }
}
