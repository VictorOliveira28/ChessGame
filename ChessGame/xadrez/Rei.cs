using ChessGame.tabuleiro;
namespace ChessGame.xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }
        public override string ToString()
        {
            return "R";
        }
    }
}
