using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntColonyAlgorithmApp
{
    class Colony
    {
        public static double a_alpha = 2;//feronom önemi
        public static double b_beta =1;//uzaklığın önemi
        public static double evaporativeRate = 0.01;
        public static double r_randomFactor = 0.9;
        public static LPoint home;
        public static int antCount;
        public static List<Ant> ants;
        public static void setColony(LPoint home, int antCount)
        {
            Colony.home = home;
            Colony.home.setHome();
            Colony.antCount = antCount;
            Colony.ants = new List<Ant>();
            Colony.generateAnts();
            
        }
        public static void ResetColony(int antCount)
        {
            Colony.antCount = antCount;
            Colony.ants = new List<Ant>();
            Colony.generateAnts();

        }

        public static void generateAnts()
        {
            for (int i = 0; i < Colony.antCount; i++)
            {
                Ant nAnt = new Ant(Colony.home);
                Colony.ants.Add(nAnt);
                
            }
        }

        public static void allAntsTakeStep()
        {
          
            foreach (Ant ant in Colony.ants)
            {
                ant.takeAStep();
                //MainScreen.container.Panel2.Refresh();
            }
        }





    }
}
