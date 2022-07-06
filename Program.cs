using tabuleiro;
using xadrez;
using xadrez_Console;

Tabuleiro tab = new Tabuleiro(8, 8);


try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();
    while (!partida.terminada)
    {
        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab);

        Console.WriteLine();

        Console.Write("Origem: ");
        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

        bool[,] posicoesPossives = partida.tab.peca(origem).movimentosPossiveis();
        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab, posicoesPossives);
        Console.WriteLine();
        Console.Write("Destino: ");
        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

        partida.executaMovimento(origem, destino);

    }
}


catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}