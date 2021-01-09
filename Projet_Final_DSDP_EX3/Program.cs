using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_DSDP_EX3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<string> PlayersNames = new List<string>() { "Tom", "Emma", "Sarah" };
            Board board = new Board(PlayersNames);
            board.PlayerTurn();
            Console.WriteLine(board._Players[0].pos.numPos);
            for (int i = 0; i <= 100; i++)
            {
                board.PlayerTurn();
                Console.WriteLine($" The player {board._Players[board._currentplayerNum].alias} is on position: {board._Players[board._currentplayerNum].pos.numPos}");
            }

            Console.ReadKey();
        }
    }
}