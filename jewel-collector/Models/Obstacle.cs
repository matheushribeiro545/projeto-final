using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jewel_collector.Interface;

namespace jewel_collector.Models
{
    public class Obstacle : Cell
    {
        public void Objeto(string tipo)
        {
            switch(tipo)
            {
                case "Water":
                    Console.WriteLine("##");
                    break;
                case "Tree":
                    Console.WriteLine("$$");
                    break;
            }
        }

        public void Posicao(int x, int y)
        {
            
        }
    }
}