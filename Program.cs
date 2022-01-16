using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 1, 1, 1, 1, 1 };

            Console.WriteLine(scoreDice(testArray));
            Console.WriteLine(scoreDice(rollDice()));
            Console.WriteLine(listDiceRollsValues(rollDice()));
            Console.ReadLine();
        }
        //Rolls the dice
        static int[] rollDice()
        {
            Random randNo = new Random();
            int[] dice = new int[] {0, 0, 0, 0, 0};

            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = randNo.Next(1, 6);
            }
            return dice;
        }
        //Scores the rolled dice
        static int scoreDice(int[] dice)
        {
            int finalScore = checkOnes(dice) + checkSixes(dice) + checkFives(dice) + checkFours(dice)
                + checkThrees(dice) + checkTwos(dice);

            return finalScore;
        }

        //Writes out the array as a string to see what dice are rolled during testing
        static string listDiceRollsValues(int[] diceRoll)
        {
            string rollString = "";

            foreach (int roll in diceRoll)
            {
                rollString += roll.ToString();
            }
            return rollString;
        }

        static int checkOnes(int[] diceRoll)
        {
            int score = 0;
            int ones = 0;
            int triplets = 0;
            int remainingOnes = 0;

            foreach (var number in diceRoll)
            {
                if (number == 1)
                {
                    ones++;
                }
            }

            triplets = ones / 3;
            remainingOnes = ones % 3;
            score = (triplets * 1000) + (remainingOnes * 100);

            return score;
        }

        static int checkSixes(int[] diceRoll)
        {
            int score = 0;
            int sixes = 0;

            foreach (var number in diceRoll)
            {
                if (number == 6)
                {
                    sixes++;
                }
            }

            if (sixes >= 3)
            {
                score = 600;
            }
            return score;
        }

        static int checkFives(int[] diceRoll)
        {
            int score = 0;
            int fives = 0;
            int triplets = 0;
            int remainingFives = 0;

            foreach (var number in diceRoll)
            {
                if (number == 5)
                {
                    fives++;
                }
            }

            triplets = fives / 3;
            remainingFives = fives % 3;
            score = (triplets * 500) + (remainingFives * 50);

            return score;
        }

        static int checkFours(int[] diceRoll)
        {
            int score = 0;
            int fours = 0;

            foreach (var number in diceRoll)
            {
                if (number == 4)
                {
                    fours++;
                }
            }

            if (fours >= 3)
            {
                score = 400;
            }
            return score;
        }

        static int checkThrees(int[] diceRoll)
        {
            int score = 0;
            int threes = 0;

            foreach (var number in diceRoll)
            {
                if (number == 3)
                {
                    threes++;
                }
            }

            if (threes >= 3)
            {
                score = 300;
            }
            return score;
        }

        static int checkTwos(int[] diceRoll)
        {
            int score = 0;
            int twos = 0;

            foreach (var number in diceRoll)
            {
                if (number == 2)
                {
                    twos++;
                }
            }

            if (twos >= 3)
            {
                score = 200;
            }
            return score;
        }
    }
}
