using System;
using Aprimorando.Interface;

namespace Aprimorando.Lib
{
    public static class JogoFoda
    {
        public static void Acao(IJogador jogador){
            Console.WriteLine(jogador.Corre());
            Console.WriteLine(jogador.Toca());
            Console.WriteLine(jogador.Chuta());
        }
    }
}