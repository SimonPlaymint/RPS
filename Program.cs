using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSCore
{
    class Program
    {
        static void Main (string[] args)
        {
            Random rnd = new Random();
            bool playRPS = true;
            string? playerInput = string.Empty;
            int randomInt;

            while (playRPS == true)
            {
                string? playAgain = string.Empty;
                bool playerWins = false;
                bool aiWins = false;
                int playerScore = 0;
                int aiScore = 0;    

                //Generate random name for opponent
                string[] forenames = new string[] {"BOBBY", "NOBBY", "LEROY", "SIMON", "JEFF"};
                Random fRnd = new Random();
                int forenamesIndex = fRnd.Next(forenames.Length);
                string _forename = forenames[forenamesIndex];

                string[] surnames = new string[] {"BALLBAG", "VAN TEET", "PISS", "NIPPLEPRICK", "ADAMS"};
                Random sRnd = new Random();
                int surnamesIndex = sRnd.Next(surnames.Length);
                string _surname = surnames[surnamesIndex];

                string _aiName = ((forenames[forenamesIndex] + " " + (surnames[surnamesIndex])));  

                //game into
                Console.WriteLine("-----------------------------------------------");   
                Console.WriteLine("You turn the corner and catch the eye of a strange animal.\nStartled and angry the creature bolts in your direction...");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("\n1.RUN\n2.FIGHT");
                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Before you have the chance to react the creature is upon you");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine();

                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine(_aiName + ": Fight me, coward!");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("\n1.Sure, that sounds like fun.\n2.No thanks, i'm busy");
                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();

                while (playerWins == false && aiWins == false)
                {
                    playerInput = "";

                    while (playerInput != "rock" && playerInput != "paper" && playerInput != "scissors")
                    {
                        //Get player input
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine(_aiName + ": Choose your weapon");                       
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("ROCK\nPAPER\nSCISSORS");
                        Console.WriteLine();

                        playerInput = Console.ReadLine();
                        playerInput = playerInput?.ToLower();
                        Console.WriteLine();

                        //Console.WriteLine(playerInput);
                    }

                    //calculate ai turn and rps result
                    randomInt = rnd.Next(1, 4);

                    if (randomInt == 1)
                    {
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine(_aiName + " picks ROCK");
                        Console.WriteLine("-----------------------------------------------");

                            if (playerInput == "rock")
                            {
                                Console.WriteLine();
                                Console.WriteLine("its a TIE!");
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine("Score\n" + "PLAYER: " + playerScore + "\n" + _aiName + ": " + aiScore);
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine("Next round?");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (playerInput == "paper")
                            {
                                playerScore++;
                                if (playerScore < 3)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("YOU WIN THIS ROUND!");
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.WriteLine("Scores\n" + "PLAYER: " + playerScore + "\n" + _aiName + ": " + aiScore);
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.WriteLine("Next round?");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    playerWins = true;
                                    Console.WriteLine();
                                    Console.WriteLine("YOU BEAT " + _aiName);
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.WriteLine("Scores\n" + "PLAYER: " + playerScore + "\n" + _aiName + ": " + aiScore);
                                    Console.WriteLine("-----------------------------------------------");
                                }
                            }
                            else if (playerInput == "scissors")
                            {
                                aiScore++;
                                if (aiScore < 3)
                                {                                 
                                    Console.WriteLine();
                                    Console.WriteLine(_aiName + " WINS THIS ROUND");
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.WriteLine("Scores\n" + "PLAYER: " + playerScore + "\n" + _aiName + ": " + aiScore);
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.WriteLine("Next round?");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    aiWins = true;
                                    Console.WriteLine();
                                    Console.WriteLine(_aiName + " BEAT YOU!");
                                    Console.WriteLine("-----------------------------------------------"); 
                                    Console.WriteLine("Scores\n" + "PLAYER: " + playerScore + "\n" + _aiName + ": " + aiScore);
                                    Console.WriteLine("-----------------------------------------------"); 
                                }
                            }
                    }
                    else if (randomInt == 2)
                    {
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine(_aiName + " picks PAPER");
                        Console.WriteLine("-----------------------------------------------");

                            if (playerInput == "paper")
                            {
                                Console.WriteLine();
                                Console.WriteLine("its a TIE!");
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine("Scores\n" + "PLAYER: " + playerScore + "\n" + _aiName + ": " + aiScore);
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine("Next round?");
                                Console.ReadKey();
                                Console.Clear();  
                            }
                            else if (playerInput == "scissors")
                            {
                                playerScore++;
                                if (playerScore < 3)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("YOU WIN THIS ROUND! ");
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.WriteLine("Scores\n" + "PLAYER:" + playerScore + "\n" + _aiName + ": " + aiScore);
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.WriteLine("Next round?");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    playerWins = true;
                                    Console.WriteLine();
                                    Console.WriteLine("YOU BEAT " + _aiName);
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.WriteLine("Scores\n" + "PLAYER: " + playerScore + "\n" + _aiName + ": " + aiScore);
                                    Console.WriteLine("-----------------------------------------------");
                                }
                            }
                            else if (playerInput == "rock")
                            {
                                aiScore++;
                                if (aiScore < 3)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(_aiName + " WINS THIS ROUND");
                                    Console.WriteLine("-----------------------------------------------"); 
                                    Console.WriteLine("Scores\n" + "PLAYER: " + playerScore + "\n" + _aiName + ": " + aiScore);
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.WriteLine("Next round?");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    aiWins = true;
                                    Console.WriteLine();
                                    Console.WriteLine(_aiName + " BEAT YOU!");
                                    Console.WriteLine("-----------------------------------------------"); 
                                    Console.WriteLine("Scores\n" + "PLAYER: " + playerScore + "\n" + _aiName + ": " + aiScore);
                                    Console.WriteLine("-----------------------------------------------");
                                }
                            }
                    }
                    else if (randomInt == 3)
                    {
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine(_aiName + " picks SCISSORS");
                        Console.WriteLine("-----------------------------------------------");

                        if (playerInput == "scissors")
                        {
                            Console.WriteLine();
                            Console.WriteLine("its a TIE!");
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("Scores\n" + "PLAYER: " + playerScore + "\n" + _aiName + ": " + aiScore);
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("Next round?");
                            Console.ReadKey();
                            Console.Clear();     
                        }
                        else if (playerInput == "rock")
                        {
                            playerScore++;
                            if (playerScore < 3)
                            {
                                Console.WriteLine();
                                Console.WriteLine("YOU WIN THIS ROUND!");
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine("Scores\n" + "PLAYER: " + playerScore + "\n" + _aiName + ": " + aiScore);
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine("Next round?");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                playerWins = true;
                                Console.WriteLine();
                                Console.WriteLine("YOU BEAT " + _aiName);
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine("Scores\n" + "PLAYER: " + playerScore + "\n" + _aiName + ": " + aiScore);
                                Console.WriteLine("-----------------------------------------------");
                            }
                        }
                        else if (playerInput == "paper")
                        {
                            aiScore++;
                            if (aiScore < 3)
                            {
                                Console.WriteLine();
                                Console.WriteLine(_aiName + " WINS THIS ROUND");
                                Console.WriteLine("-----------------------------------------------"); 
                                Console.WriteLine("Scores\n" + "PLAYER: " + playerScore + "\n" + _aiName + ": " + aiScore);
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine("Next round?");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                aiWins = true;
                                Console.WriteLine();
                                Console.WriteLine(_aiName + " BEAT YOU!");
                                Console.WriteLine("-----------------------------------------------"); 
                                Console.WriteLine("Scores\n" + "PLAYER: " + playerScore + "\n" + _aiName + ": " + aiScore);
                                Console.WriteLine("-----------------------------------------------");
                            }
                        }
                    }
                }

                while (playAgain != "yes" && playAgain != "no")
                {
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine ("Congratulations! Play again?");
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("\n1.YES\n2.NO");
                    Console.WriteLine();

                    playAgain = Console.ReadLine();
                    playAgain = playAgain?.ToLower();
                    

                    if (playAgain == "yes")
                    {
                        Console.Clear();
                    } 
                    else if (playAgain == "no")
                    {
                        return;
                    }

                }

            }
        
        }

    }

}