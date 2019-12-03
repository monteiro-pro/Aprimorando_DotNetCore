using System;
using Aprimorando.Lib;

namespace Aprimorando_DotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogador1 = new Jogador1("Ronaldo");
            var jogador2 = new Jogador1("Bebeto");

            JogoFoda.Acao(jogador1);
            JogoFoda.Acao(jogador2);
        }
    }
}
