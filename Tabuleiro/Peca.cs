﻿namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QntMovimentos  { get; protected set; }
        public Tabuleiro Tab { get; protected set; }


        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            Posicao = posicao;
            Tab = tab;
            Cor = cor;
            QntMovimentos = 0;
        }


    }
}
