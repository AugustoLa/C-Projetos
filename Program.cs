﻿using tabuleiro;
using xadrez;
using Xadrez_Console;

Tabuleiro tab = new Tabuleiro(8, 8);


try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();
    Tela.imprimirTabuleiro(partida.tab);
    
    while (!partida.terminada)
    {
        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab);
        Console.WriteLine();
        Console.Write("Origem: ");
        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
        Console.Write("Destino: ");
        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
        partida.executaMovimento(origem, destino);

    }
}


catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}