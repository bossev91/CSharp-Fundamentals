using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOneDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTwoDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            while(playerOneDeck.Count > 0 && playerTwoDeck.Count > 0)
            {
                int cardFirstPlayer = playerOneDeck[0];
                int cardSecondPlayer = playerTwoDeck[0];
                int index = 0;

                if(cardFirstPlayer > cardSecondPlayer)
                {
                    playerOneDeck.Add(cardFirstPlayer);
                    playerOneDeck.Add(cardSecondPlayer);
                    playerOneDeck.RemoveAt(index);
                    playerTwoDeck.RemoveAt(index);
                }
                else if(cardSecondPlayer > cardFirstPlayer)
                {
                    playerTwoDeck.Add(cardSecondPlayer);
                    playerTwoDeck.Add(cardFirstPlayer);
                    playerOneDeck.RemoveAt(index);
                    playerTwoDeck.RemoveAt(index);
                }
                else
                {
                    playerOneDeck.RemoveAt(index);
                    playerTwoDeck.RemoveAt(index);
                }

            }
                int finalScoreFirst = playerOneDeck.Sum();
                int finalScoreSecond = playerTwoDeck.Sum();

                if(finalScoreFirst > finalScoreSecond)
                {
                    Console.WriteLine($"First player wins! Sum: {finalScoreFirst}");
                }
                else
                {
                    Console.WriteLine($"Second player wins! Sum: {finalScoreSecond}");
                }
        }
    }
}
