using CenterSpace.NMath.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntColonyAlgorithmApp
{
    class Ant
    {
        public static int idCount=0;
        public List<LPoint> visitedPoints { get; }
        private List<Neighbor> visitedNeigbours;
        public  double Q_antPhrenomeAmount = 100;
        public double pathLenght;
        private int id;

      

        public Ant(LPoint home)
        {
            this.visitedPoints = new List<LPoint>();
            this.visitedNeigbours = new List<Neighbor>();
            this.visitedPoints.Add(home);

            this.id = Ant.idCount;
            Ant.idCount++;
            this.pathLenght = 0;
        }

        public void takeAStep()
        {
           

            LPoint curentLocation = this.visitedPoints[this.visitedPoints.Count-1];
            List<Neighbor> notVisitedNeigbours = new List<Neighbor>();
            double totalJValue = 0;
            foreach (Neighbor neigbour in curentLocation.neighbors)
            {
                if (neigbour.isEliminated)
                {
                    continue;
                }
                neigbour.probability = 0;
                LPoint candidate= neigbour.GetDestination(curentLocation);
                if (!this.visitedPoints.Contains(candidate))
                {

                    neigbour.jValue =Math.Round(Math.Pow(neigbour.pheromoneValue, Colony.a_alpha),10) *Math.Round(Math.Pow((1 / neigbour.distance), Colony.b_beta),10);
                   
                    // totalJValue += Math.Round(neigbour.jValue, 6, MidpointRounding.AwayFromZero);
                    totalJValue += neigbour.jValue;
                    notVisitedNeigbours.Add(neigbour);

                }
            }


            if (notVisitedNeigbours.Count==0)// eğer gezilmemiş komşu yoksa tur bitmiştir.
            {
                //başlangıca dönüş
                foreach (Neighbor neigbour in curentLocation.neighbors)
                {
                    LPoint candidate = neigbour.GetDestination(curentLocation);
                    if(candidate==Colony.home)
                    {
                        this.visitedNeigbours.Add(neigbour);
                        break;
                    }
                }
                this.EveluateFinishedPath();
              
                return;
            }
            /*
            RandomNumberGenerator rnd = null;
            switch (World.generatorChoice)   
            {
                case World.RandomNumberGenerators.Uniform:
                     rnd = new RandGenUniform();
                    break;
                case World.RandomNumberGenerators.Exponential:
                     rnd = new RandGenExponential();
                    break;
                case World.RandomNumberGenerators.Gamma:
                     rnd = new RandGenGamma();
                    break;
                default:
                    rnd = new RandGenBeta();
                    break;

            }*/

        
            double pickedRandom = World.rnd.NextDouble();
            double rouletteWheel = 0;
            //notVisitedNeigbours=notVisitedNeigbours.OrderByDescending(p=>p.pheromoneValue).ToList();
            Neighbor nextNeighbor=null;

      
            int rindex = 0;
            while (nextNeighbor == null)
            {
                rindex = (int)((World.rnd.NextDouble()*100)% notVisitedNeigbours.Count);
                Neighbor neigbour = notVisitedNeigbours[rindex];
                neigbour.probability = neigbour.jValue / totalJValue;
                rouletteWheel += neigbour.probability;
                if (pickedRandom < rouletteWheel)
                {
                    nextNeighbor = neigbour;
                    //this.Q_antPhrenomeAmount += nextNeighbor.pheromoneValue;
                    break;
                }
            }
          /*  foreach (Neighbor neigbour in notVisitedNeigbours)
            {
            
                neigbour.probability = neigbour.jValue / totalJValue;
                rouletteWheel += neigbour.probability;
                if (pickedRandom < rouletteWheel)
                {
                    nextNeighbor = neigbour;
                    this.Q_antPhrenomeAmount += nextNeighbor.pheromoneValue;
                    break;
                }
            }*/

            
            this.visitedNeigbours.Add(nextNeighbor );
            this.pathLenght += nextNeighbor.distance;
            LPoint nextLocation = nextNeighbor.GetDestination(curentLocation);
            this.visitedPoints.Add(nextLocation);
        }
        public void EveluateFinishedPath()
        {

            while (this.visitedNeigbours.Count != 0)
            {
                //if(this.visitedNeigbours[this.visitedNeigbours.Count - 1].pheromoneValue+this.Q_antPhrenomeAmount / this.pathLenght <255)
                //{  
                    this.visitedNeigbours[this.visitedNeigbours.Count - 1].pheromoneValue += Math.Round(this.Q_antPhrenomeAmount/(this.pathLenght),10);
              //  }
                this.visitedNeigbours.RemoveAt(this.visitedNeigbours.Count - 1);
                
            }
            while (this.visitedPoints.Count != 1)
            {
                this.visitedPoints.RemoveAt(this.visitedPoints.Count - 1);

            }

            if (World.theBest.pathLenght < this.pathLenght)
            {
                World.theBest = new Data(this,this.pathLenght,World.runTimes, Enum.GetName(typeof(World.RandomNumberGenerators), World.generatorChoice));
            }

            this.pathLenght = 0;
            

        }

    }
}
