

using System.Reflection.PortableExecutable;
using tabuleiro;

 namespace tabuleiro
{
    class Peca
    {
        public  Posicao posicao { get; set; }
        public Cor cor { get; protected set; }

        public int qtdMovimentos { get; set; }
        public Tabuleiro tab   { get; set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qtdMovimentos = 0;
            
        }
    }
}
