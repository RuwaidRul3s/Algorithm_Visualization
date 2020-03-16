using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Algorithm_Visualizer
{
    abstract class SortingAlgorithm
    {
       
        public abstract void Draw_AlgorithmCode(Graphics g);
         public abstract void SortAlgorithm(List<int>values);
    }
}
