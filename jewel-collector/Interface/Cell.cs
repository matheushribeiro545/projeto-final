using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jewel_collector.Interface
{
    public interface Cell
    {
        void Posicao(int x, int y);
        void Objeto(string tipo);
    }
}