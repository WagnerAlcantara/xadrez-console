﻿using System;
using tabuleiro;
using xadrez;
namespace xadrez_console {

    //Iniciando programa
    class Program {
        static void Main(string[] args) {
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada) {
                    try {
                        Console.Clear();

                        Tela.imprimirTabuleiro(partida.tab);
                        Console.WriteLine();
                        Console.WriteLine("Partida: " + partida.turno);
                        Console.WriteLine("Aguardando Jogada :" + partida.jogadorAtual);

                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validaPosicaoDeOrigem(origem);
                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                        partida.realizaJogada(origem, destino);



                    } catch
                    (TabuleiroException e) {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();

                    }

                }

            } catch
                (TabuleiroException e) {
                Console.WriteLine(e.Message);



                Console.ReadLine();

            }
        }
    }
}

