using tabuleiro;
namespace xadrez {
    class PartidaDeXadrez {

        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;


        public PartidaDeXadrez() {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino) {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQtdMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }
        private void colocarPecas() {

            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadre('c', 1).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadre('c', 2).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadre('d', 2).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadre('e', 1).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadre('e', 2).toPosicao());

            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadre('d', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadre('c', 7).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadre('c', 8).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadre('d', 7).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadre('e', 7).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadre('e', 8).toPosicao());

            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadre('d', 8).toPosicao());


        }
    }

}
