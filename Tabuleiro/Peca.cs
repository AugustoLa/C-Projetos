﻿namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QntMovimentos  { get; protected set; }
        public Tabuleiro Tab { get; protected set; }


        public Peca(Tabuleiro tab, Cor cor)
        {
            Tab = tab;
            Cor = cor;
            QntMovimentos = 0;
            Posicao = null;
        }

        public void incrementarQtemMovimento()
        {
            QntMovimentos++;
        }
    }
}
