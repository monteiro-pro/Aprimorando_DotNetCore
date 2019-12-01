namespace Aprimorando.Lib
{
    public class Jogador1 : IJogador
    {
        public string nome{get; set;}

        public Jogador1(string nome)
        {
            this.nome = nome;
        }

        //Chuta
        public string Chuta()
        {
            return $"{nome} Chutou!";
        }

        //Corre
        public string Corre()
        {
            return $"{nome} Correu!";
        }

        //Toca
        public string Toca()
        {
            return $"{nome} Tocou!";
        }
    }
}