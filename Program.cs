using tabuleiro;
using xadrez;
using Xadrez_Console;

Tabuleiro tab = new Tabuleiro(8, 8);


PosicaoXadrez pos = new PosicaoXadrez('c', 7);

Console.WriteLine(pos);


Console.WriteLine(pos.toPosicao());