using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jewel_collector.Interface;

namespace jewel_collector.Models
{
    public class Jewel : Cell
    {
        public void Objeto(string tipo)
        {
            switch(tipo)
            {
                case "Red":
                    Console.WriteLine(100);
                    break;
                case "Green":
                    Console.WriteLine(50);
                    break;
                case "Blue":
                    Console.WriteLine(10);
                    break;
            }
        }

        public void Posicao(int x, int y)
        {
            
        }
    }
}