namespace tabuleiro
{
    abstract class Peca
    {
        internal int qteMovimentos;

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qntMovimentos  { get; protected set; }
        public Tabuleiro tab { get; protected set; }


        public Peca(Tabuleiro tab, Cor cor)
        {
            this.tab = tab;
            this.cor = cor;
            this.qntMovimentos = 0;
            this.posicao = null;
        }

        public void incrementarQtemMovimento()
        {
            qntMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();

    }
}
