﻿using System;
using tabuleiro;
using xadrez;
namespace xadrez_console {
    class Program {
        static void Main(string[] args) {
            PosicaoXadre pos = new PosicaoXadre('c',7);
            Console.WriteLine(pos);
                Console.WriteLine(pos.toPosicao())  ;


            Console.ReadLine();

        }
    }
}