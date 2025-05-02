using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayerManager1
{
    class Program
    {
        static List<Player> players = new List<Player>
        {
            new Player("Alice", 85),
            new Player("Bob", 120)
        };

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n1. Inserir jogador");
                Console.WriteLine("2. Listar todos os jogadores");
                Console.WriteLine("3. Listar jogadores com Score maior que...");
                Console.WriteLine("0. Sair");
                Console.Write("Opção: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        InsertPlayer();
                        break;
                    case "2":
                        ListAllPlayers();
                        break;
                    case "3":
                        ListPlayersWithScoreGreaterThan();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void InsertPlayer()
        {
            Console.Write("Nome do jogador: ");
            string name = Console.ReadLine();
            Console.Write("Score do jogador: ");
            if (int.TryParse(Console.ReadLine(), out int score))
            {
                players.Add(new Player(name, score));
                Console.WriteLine("Jogador adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Score inválido.");
            }
        }

        static void ListAllPlayers()
        {
            Console.WriteLine("\n--- Lista de Jogadores ---");
            foreach (var p in players)
                Console.WriteLine(p);
        }

        static void ListPlayersWithScoreGreaterThan()
        {
            Console.Write("Score mínimo: ");
            if (int.TryParse(Console.ReadLine(), out int minScore))
            {
                var filtered = GetPlayersWithScoreGreaterThan(minScore);
                Console.WriteLine($"\n--- Jogadores com Score > {minScore} ---");
                foreach (var p in filtered)
                    Console.WriteLine(p);
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }

        static IEnumerable<Player> GetPlayersWithScoreGreaterThan(int value)
        {
            return players.Where(p => p.Score > value);
        }
    }
}
