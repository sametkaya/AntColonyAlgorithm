using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntColonyAlgorithmApp
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
          
                // run as windows app
                Application.EnableVisualStyles();
          
                Application.Run(new MainScreen());
          

            /*
            World newWorld = new World(200,200);
            newWorld.CreateRandomWorld(10);
            newWorld.CreateAColony(30);
            newWorld.RunWord(3);
          */




        }
    }
}
