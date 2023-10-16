using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Xml.Schema;

namespace Dice_Roller_LAB_2_Blake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please Enter 2 Number that symbolize Dice sides.");
                int result1 = DiceInputVarify();
                int randomisedDice = DiceRandomiser(result1);
                int result2 = DiceInputVarify();
                int randomisedDice1 = DiceRandomiser1(result2);
                int totalDice = randomisedDice + randomisedDice1;
                Console.WriteLine($"{randomisedDice} and {randomisedDice1} And the total of both is {totalDice}");

                if (result2 < 100 && result1 < 100)
                {
                    ValidateDiceValues(totalDice, randomisedDice, randomisedDice1);
                }
                string yesOrNo;
                while (true)
                {
                    Console.WriteLine("Would you like to play again? Y/N");
                     yesOrNo = Console.ReadLine().ToUpper();

                    if (yesOrNo == "N" || yesOrNo == "Y")
                    {
                        break;
                    }             
                }
                if (yesOrNo == "N")
                {
                    break;
                }
            }
        }
        static int DiceInputVarify()
        {
            while (true)
            {
                string input1 = Console.ReadLine();
                if (int.TryParse(input1, out int dice1) && (dice1 >= 1))
                {             
                        return dice1;                  
                }
                else
                    Console.WriteLine("Try again. Please Enter A valid Number that symbolize Dice sides.");
                continue;
            }
        }
        
        static int DiceRandomiser(int result1)
        {
            Random randomDiceGenerator = new Random();
            int randomDice = randomDiceGenerator.Next(1, result1);
            return randomDice;
        }
       
        static int DiceRandomiser1(int result2)
        {
            Random randomDiceGenerator = new Random();
            int randomDice1 = randomDiceGenerator.Next(1, result2);
            return randomDice1;
        }
       
        static void ValidateDiceValues(int totalDice, int randomisedDice, int randomisedDice1) 
        {
            if (totalDice == 2)
            {
                Console.WriteLine("Snake Eyesssss");
            }            
            else if (totalDice == 3) 
            {
                Console.WriteLine("Ace's Deuce");
            }            
            else if (randomisedDice == 6 && randomisedDice1 == 6)
            {
                Console.WriteLine("Box Cars");
            }           
            else if (totalDice == 7 || totalDice == 11)
            {
                Console.WriteLine("Win");
            }
            else if (totalDice == 2 || totalDice == 3 || totalDice == 12)
            {
                Console.WriteLine("Craps!!!");
            }
            else if (totalDice == 13)
            {
                Console.WriteLine("One above the others!");
            }
            else if (randomisedDice == 6 && randomisedDice1 == 9 || randomisedDice1 == 6 && randomisedDice == 9)
            {
                Console.WriteLine("Nice");
            }
            else if (randomisedDice == 9  && randomisedDice1 == 11 || randomisedDice1 == 9 && randomisedDice ==11)
            {
                Console.WriteLine("In memorial of fallen heros, win");
            }
            else if (totalDice == 24)
            {
                Console.WriteLine("Box cars x 2");
            }
            else if (randomisedDice == 7 && randomisedDice1 == 7)
            {
                Console.WriteLine("Cut above the snakes eyes");
            }           
                Console.WriteLine("You aint the winner today");
        }   
    }
}