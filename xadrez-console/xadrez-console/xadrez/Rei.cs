using System;
using tabuleiro;
    



namespace xadrez {
    class Rei : Peca {
        public Rei (Tabuleiro tab, Cor cor) : base(tab, cor) {


        }
        public override string ToString() {
            return "R";
        }


        private bool podeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;

        }
         public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);


            /*Definindo movimento do rei para posicao acima*/

            pos.definirValores(posicao.linha - 1, posicao.coluna);
            if(tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha, pos.coluna] = true;
            }
            //Definindo movimento do rei a posição Nordeste
            pos.definirValores(posicao.linha -1, posicao.coluna +1 );
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            // Definindo movimento do rei para a posicao lateral  direita

            pos.definirValores(posicao.linha, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {

                mat[pos.linha, pos.coluna] = true;
            }

            //Definindo movimento do rei para a posicao sudeste
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            if(tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            // Definindo movimento do rei para a posicao abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //Definindo movimento do rei para a posicao sudoeste
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            // Definindo movimento do rei para a posicao esquerda
            pos.definirValores(posicao.linha , posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //Definindo movimento do rei para a posicao noroeste

            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }
    }
}
