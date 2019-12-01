namespace Aprimorando.Lib
{
    public class Jogador2 : IJogador
    {
        private readonly string nome;

        public Jogador2(string nome)
        {
            this.nome = nome;
        }
        public string Chuta()
        {
            return $"{nome} Chutou";
        }

        public string Corre()
        {
            return $"{nome} Corre!";// Teste Commit
        }

        public string Toca()
        {
            return $"{nome} Tocou!";
        }
    }
}