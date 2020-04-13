using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFutebol_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time("Palmeiras");
            time1.contratarJogador(new Jogador("Alex", 20, 99, 1));
            time1.contratarJogador(new Jogador("Pedro", 22, 96, 2));
            time1.contratarJogador(new Jogador("Leandro", 27, 91, 3));
            time1.contratarJogador(new Jogador("Bruno", 21, 90, 4));
            time1.contratarJogador(new Jogador("Jorge", 23, 92, 5));
            time1.contratarJogador(new Jogador("Eleno", 20, 97, 6));
            time1.contratarJogador(new Jogador("Rodrigo", 20, 80, 7));
            time1.contratarJogador(new Jogador("Antônio", 20, 88, 8));
            time1.contratarJogador(new Jogador("Migel", 20, 79, 9));
            time1.contratarJogador(new Jogador("Luciano", 20, 90, 10));
            time1.contratarJogador(new Jogador("Alencar", 20, 95, 11));

            Time time2 = new Time("Santos");
            time1.contratarJogador(new Jogador("Juliano", 20, 99, 1));
            time1.contratarJogador(new Jogador("Matias", 22, 96, 2));
            time1.contratarJogador(new Jogador("Roberto", 27, 91, 3));
            time1.contratarJogador(new Jogador("Carlos", 21, 90, 4));
            time1.contratarJogador(new Jogador("Renato", 23, 92, 5));
            time1.contratarJogador(new Jogador("Fabiano", 30, 97, 6));
            time1.contratarJogador(new Jogador("Regis", 33, 80, 7));
            time1.contratarJogador(new Jogador("Otávio", 29, 88, 8));
            time1.contratarJogador(new Jogador("Marcio", 25, 79, 9));
            time1.contratarJogador(new Jogador("Wilson", 28, 90, 10));
            time1.contratarJogador(new Jogador("Marcos", 38, 95, 11));

            Partida p1 = new Partida(DateTime.Now, time1, time2);
            p1.jogar();
            Console.WriteLine(p1.getPlacar());

            Console.WriteLine(time1.getStatus());
            time1.getDescricaoJogadores();

            Console.WriteLine(time2.getStatus());
            time1.getDescricaoJogadores();

            Console.ReadKey();
        }
    }
}