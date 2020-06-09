using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace AntColonyAlgorithmApp
{
    class LPoint
    {
        public static int idCounter = 0;
        public int id;
        public Point location { get; }
        public bool isStartPoint;
        public List<Neighbor> neighbors { get; }
        private double pheromoneValue { get; set; }
        private bool isHome { get; set; }
        public LPoint(int x, int y)
        {
            this.id = LPoint.idCounter;
            LPoint.idCounter++;
            this.location = new Point(x,y);
          
            this.neighbors = new List<Neighbor>();
           
        }
        public void setHome()
        {
            this.isHome = true;
        }

        public void addNeighbor(Neighbor neighbor)
        {
            this.neighbors.Add(neighbor);
        }
        public bool isInNeighbors(Neighbor neighbor)
        {
           
            foreach (Neighbor item in this.neighbors)
            {
                if (item.isEqual(neighbor))
                {
                    return true;
                }
            }

            return false;
        }
    
    }
}
