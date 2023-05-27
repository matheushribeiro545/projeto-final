using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jewel_collector.Interface;

namespace jewel_collector.Models
{
    public class Empty : Cell
    {
        public void Objeto(string tipo)
        {
            Console.WriteLine("--");
        }

        public void Posicao(int x, int y)
        {
        
        }
    }
}