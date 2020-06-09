using CenterSpace.NMath.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntColonyAlgorithmApp
{
    class World
    {
        public enum RandomNumberGenerators{
            Beta=0,
            Uniform = 1,
            Exponential = 2,
            Gamma = 3,
           
        }
        public static List<LPoint> locations;
        public static List<Neighbor> neighbors;
        public static RandomNumberGenerators generatorChoice=0;

        public static int locationCount = 0;
        public static int margin = 20;



        public static int witdh = 0;
        public static int height = 0;
        public static int runTimes = 0;
        private static List<int> witdhNumbers;
        private static List<int> heightNumbers;
        public static bool isSet = false;

        public static Data theBest;

        public static RandomNumberGenerator rnd;
        public static void setWorld(int witdh, int height)
        {
            World.locations = new List<LPoint>();
            World.neighbors = new List<Neighbor>();
            World.runTimes = 0;
            World.witdh = witdh;
            World.height = height;
            World.witdhNumbers = new List<int>();
            for (int i = 0; i < World.witdh - World.margin; i++)
            {
                World.witdhNumbers.Add(i);
            }
            World.heightNumbers = new List<int>();
            for (int i = 0; i < World.height - World.margin; i++)
            {
                World.heightNumbers.Add(i);
            }

            World.isSet = true;


        }
        public static void CreateAColony(int antSize)
        {
            Random rnd = new Random();
            int rLPoint = rnd.Next(World.locations.Count);
            LPoint selectedLPoint = World.locations[rLPoint];
            selectedLPoint.isStartPoint = true;
            Colony.setColony(selectedLPoint, antSize);

        }



        public static  void TurnAllPointOneTime()
        {
            for (int i = 0; i < World.locationCount; i++)
            {
                Colony.allAntsTakeStep();

            }
        }

        public static  void RunWord(int times)
        {
             World.rnd = null;
            switch (World.generatorChoice)
            {
                case World.RandomNumberGenerators.Uniform:
                    World.rnd = new RandGenUniform();
                    break;
                case World.RandomNumberGenerators.Exponential:
                    World.rnd = new RandGenExponential();
                    break;
                case World.RandomNumberGenerators.Gamma:
                    World.rnd = new RandGenGamma();
                    break;
                default:
                    World.rnd = new RandGenBeta();
                    break;

            }



            World.theBest = new Data();

            for (int i = 0; i < times; i++)
            {
                World.TurnAllPointOneTime();
                World.Evaporative();
                runTimes++;
            }


        }

        public static void Evaporative()
        {
            List<Neighbor> willDeleteNeighbours = new List<Neighbor>();
            foreach (Neighbor neighbor in World.neighbors)
            {
                if (neighbor.isEliminated)
                {
                    continue;
                }
                neighbor.pheromoneValue = Math.Round(neighbor.pheromoneValue * (1-Colony.evaporativeRate),5);
                if (neighbor.pheromoneValue < 0.8)
                {
                    neighbor.isEliminated = true;
               
                }
            }
        

/*
            foreach (Neighbor neighbor in willDeleteNeighbours)
            {
                World.neighbors.Remove(neighbor);
                foreach (LPoint point in locations)
                {
                    point.neighbors.Remove(neighbor);
                }
            }*/
          

        }

        public static void ResetWorld()
        {

           // World.neighbors = new List<Neighbor>(World.neighborsListCopy);

            foreach (Neighbor item in World.neighbors)
            {
                item.pheromoneValue = 1;
                item.jValue = 0;
                item.isEliminated = false;
            }
           // World.locations = new List<LPoint>(World.locationListCopy);
            /*foreach (LPoint item in World.locations)
            {
                foreach (Neighbor item2 in item.neighbors)
                {
                    item2.pheromoneValue = 1;
                    item2.jValue = 0;
                }
            }*/
            World.runTimes = 0;
            World.theBest = new Data();
        
        }


        public static void CreateRandomWorld(int locationCount)
        {
            World.locationCount = locationCount;

            Random rnd = new Random();
            //chreate locations
            int rx = 0;
            int x = 0;
            int ry = 0;
            int y = 0;
            for (int i = 0; i < World.locationCount; i++)
            {
                rx = rnd.Next(World.witdhNumbers.Count);
                x = World.witdhNumbers[rx];
                World.witdhNumbers.RemoveAt(rx);

                ry = rnd.Next(World.heightNumbers.Count);
                y = World.heightNumbers[ry];
                World.heightNumbers.RemoveAt(ry);

                LPoint nLpoint = new LPoint(x + margin, y + margin);
                World.locations.Add(nLpoint);
          
            }

            foreach (LPoint item1 in World.locations)
            {
                foreach (LPoint item2 in World.locations)
                {
                    if (!item2.Equals(item1))
                    {
                        Neighbor nNeighbour = new Neighbor(item1, item2);

                        if (!item1.isInNeighbors(nNeighbour) && !item2.isInNeighbors(nNeighbour))
                        {
                            item1.addNeighbor(nNeighbour);
                            item2.addNeighbor(nNeighbour);
                            neighbors.Add(nNeighbour);
                        }
                     
                     
                    }
                }
            }
          
       
        }
        // kare bir dünya oluşturur.
        // noktalar matrisi
        /*public void CreateSequareWord(int distance = 10)
        {
            int count = this.witdh / distance;

            LPoint[,] array = new LPoint[count, count];
            for (int y = 0; y < count; y++)
            {
                for (int x = 0; x < count; x++)
                {
                    array[y, x] = new LPoint(x * distance, y * distance);
                }
            }

            for (int y = 0; y < count; y++)
            {
                for (int x = 0; x < count; x++)
                {
                    if (0 <= (x - 1))
                    {
                        Neighbor nNeighbor = new Neighbor(array[y, x], array[y, x - 1]);
                        if (array[y, x].isInNeighbors(nNeighbor))
                        {
                            array[y, x].neighbors.Add(nNeighbor);
                        }
                        if (array[y, x - 1].isInNeighbors(nNeighbor))
                        {
                            array[y, x - 1].neighbors.Add(nNeighbor);
                        }
                    }
                    if (0 <= (y - 1))
                    {
                        Neighbor nNeighbor = new Neighbor(array[y, x], array[y - 1, x]);
                        if (array[y, x].isInNeighbors(nNeighbor))
                        {
                            array[y, x].neighbors.Add(nNeighbor);
                        }
                        if (array[y - 1, x].isInNeighbors(nNeighbor))
                        {
                            array[y - 1, x].neighbors.Add(nNeighbor);
                        }
                    }
                    if (0 <= (x - 1) && 0 <= (y - 1))
                    {
                        Neighbor nNeighbor = new Neighbor(array[y, x], array[y - 1, x - 1]);
                        if (array[y, x].isInNeighbors(nNeighbor))
                        {
                            array[y, x].neighbors.Add(nNeighbor);
                        }
                        if (array[y - 1, x - 1].isInNeighbors(nNeighbor))
                        {
                            array[y - 1, x - 1].neighbors.Add(nNeighbor);
                        }
                    }
                    if (count > (x + 1))
                    {
                        Neighbor nNeighbor = new Neighbor(array[y, x], array[y, x + 1]);
                        if (array[y, x].isInNeighbors(nNeighbor))
                        {
                            array[y, x].neighbors.Add(nNeighbor);
                        }
                        if (array[y, x + 1].isInNeighbors(nNeighbor))
                        {
                            array[y, x + 1].neighbors.Add(nNeighbor);
                        }
                    }
                    if (count > (y + 1))
                    {
                        Neighbor nNeighbor = new Neighbor(array[y, x], array[y + 1, x]);
                        if (array[y, x].isInNeighbors(nNeighbor))
                        {
                            array[y, x].neighbors.Add(nNeighbor);
                        }
                        if (array[y + 1, x].isInNeighbors(nNeighbor))
                        {
                            array[y + 1, x].neighbors.Add(nNeighbor);
                        }
                    }
                    if (0 <= (x - 1) && count > (y + 1))
                    {
                        Neighbor nNeighbor = new Neighbor(array[y, x], array[y + 1, x - 1]);
                        if (array[y, x].isInNeighbors(nNeighbor))
                        {
                            array[y, x].neighbors.Add(nNeighbor);
                        }
                        if (array[y + 1, x - 1].isInNeighbors(nNeighbor))
                        {
                            array[y + 1, x - 1].neighbors.Add(nNeighbor);
                        }
                    }
                    if (count > (x + 1) && 0 <= (y - 1))
                    {
                        Neighbor nNeighbor = new Neighbor(array[y, x], array[y - 1, x + 1]);
                        if (array[y, x].isInNeighbors(nNeighbor))
                        {
                            array[y, x].neighbors.Add(nNeighbor);
                        }
                        if (array[y, x - 1].isInNeighbors(nNeighbor))
                        {
                            array[y, x - 1].neighbors.Add(nNeighbor);
                        }
                    }
                    if (count > (x + 1) && count > (y + 1))
                    {
                        Neighbor nNeighbor = new Neighbor(array[y, x], array[y + 1, x + 1]);
                        if (array[y, x].isInNeighbors(nNeighbor))
                        {
                            array[y, x].neighbors.Add(nNeighbor);
                        }
                        if (array[y + 1, x + 1].isInNeighbors(nNeighbor))
                        {
                            array[y + 1, x + 1].neighbors.Add(nNeighbor);
                        }
                    }
                }
            }


        }*/
        //rasgele test lokasyonları
        //heniz bitmedi
        /*
        public void CreateTestWorld()
        {
            LPoint p1 = new LPoint(10,10);
            this.locations.Add(p1);
            LPoint p2 = new LPoint(30, 10);
            this.locations.Add(p2);
            LPoint p3 = new LPoint(10, 30);
            this.locations.Add(p3);
            LPoint p4 = new LPoint(10, 10);
            this.locations.Add(p4);
            LPoint p5 = new LPoint(60, 10);
            this.locations.Add(p5);
            LPoint p6 = new LPoint(20, 20);
            this.locations.Add(p6);
            LPoint p7 = new LPoint(40, 50);
            this.locations.Add(p7);
            LPoint p8 = new LPoint(80, 30);
            this.locations.Add(p8);
            LPoint p9 = new LPoint(30, 90);
            this.locations.Add(p9);
            LPoint p10 = new LPoint(70, 60);
            this.locations.Add(p10);
            LPoint p11 = new LPoint(100, 90);
            this.locations.Add(p11);
            LPoint p12 = new LPoint(70, 80);
            this.locations.Add(p12);
            LPoint p13 = new LPoint(35, 35);
            this.locations.Add(p13);

            p1.neighbors.Add(p2);
            p2.neighbors.Add(p1);

            p1.neighbors.Add(p3);
            p3.neighbors.Add(p1);

            p1.neighbors.Add(p6);
            p6.neighbors.Add(p1);

            p3.neighbors.Add(p6);
            p6.neighbors.Add(p3);

            p3.neighbors.Add(p9);
            p9.neighbors.Add(p3);

        } */
    }
}
