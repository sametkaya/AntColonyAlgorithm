using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntColonyAlgorithmApp
{
    class Data
    {
        public Ant ant;
        public double pathLenght;
        public int turnNo;
        public String randomName;

        public Data(Ant ant=null, double pathLenght=0, int turnNo=-1, String randomName=null)
        {
            this.ant = ant;
            this.pathLenght = pathLenght;
            this.turnNo = turnNo;
            this.randomName = randomName;
        }


    }
}
