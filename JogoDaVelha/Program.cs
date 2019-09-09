using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro T = new Tabuleiro();
            T.Jogar();

            Console.ReadKey();
        }
    }
}
