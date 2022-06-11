using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_24_TicTacToe
{
    internal class game
    {
        string[][] matrix = new string[3][];
        public bool stillPlaying = true;
        int count;

        public game()
        {
            matrix[0] = new string[3] { " ", " ", " " };
            matrix[1] = new string[3] { " ", " ", " " };
            matrix[2] = new string[3] { " ", " ", " " };
        }

        public void gameBoard()
        {
            string board =
                $"\n  |       Y     |" +
                $"\n  ----A---B---C--" +
                $"\n ------------------" +
                $"\n  |1| {matrix[0][0]} | {matrix[0][1]} | {matrix[0][2]} |" +
                $"\n  |---------------" +
                $"\n Y|2| {matrix[1][0]} | {matrix[1][1]} | {matrix[1][2]} |" +
                $"\n  | --------------" +
                $"\n  |3| {matrix[2][0]} | {matrix[2][1]} | {matrix[2][2]} |" +
                $"\n -----------------";

            Console.WriteLine(board);
        }

        public int positionSwitch(string selection)
        {
            int thisPosition = 4;
            if (selection == "A")
            {
                thisPosition = 0;
            }
            else if (selection == "B")
            {
                thisPosition = 1;
            }
            else if (selection == "C")
            {
                thisPosition = 2;
            }
            return thisPosition;
        }

        public void WinCheck()
        {

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrix[i][j] == "X" || matrix[i][j] == "O")
                    { count++; }
                    j++;
                }
                i++;

            }

            if (matrix[0][0] == "X" && matrix[0][1] == "X" && matrix[0][2] == "X")
            {
                Console.WriteLine("Player One has WON THE GAME!!!");
                stillPlaying = false;
            }
            else if (matrix[0][0] == "X" && matrix[1][0] == "X" && matrix[2][0] == "X")
            {
                Console.WriteLine("Player One has WON THE GAME!!!");
                stillPlaying = false;
            }
            else if (matrix[0][1] == "X" && matrix[1][1] == "X" && matrix[2][1] == "X")
            {
                Console.WriteLine("Player One has WON THE GAME!!!");
                stillPlaying = false;
            }
            else if (matrix[0][2] == "X" && matrix[1][2] == "X" && matrix[2][2] == "X")
            {
                Console.WriteLine("Player One has WON THE GAME!!!");
                stillPlaying = false;
            }
            else if (matrix[1][0] == "X" && matrix[1][1] == "X" && matrix[1][2] == "X")
            {
                Console.WriteLine("Player One has WON THE GAME!!!");
                stillPlaying = false;
            }
            else if (matrix[2][0] == "X" && matrix[2][1] == "X" && matrix[2][2] == "X")
            {
                Console.WriteLine("Player One has WON THE GAME!!!");
                stillPlaying = false;
            }
            else if (matrix[0][0] == "X" && matrix[1][1] == "X" && matrix[2][2] == "X")
            {
                Console.WriteLine("Player One has WON THE GAME!!!");
                stillPlaying = false;
            }
            else if (matrix[0][2] == "X" && matrix[1][1] == "X" && matrix[2][0] == "X")
            {
                Console.WriteLine("Player One has WON THE GAME!!!");
                stillPlaying = false;
            }


            if (matrix[0][0] == "Y" && matrix[0][1] == "Y" && matrix[0][2] == "Y")
            {
                Console.WriteLine("Player Two has WON THE GAME!!!");
                stillPlaying = false;
            }
            else if (matrix[0][0] == "Y" && matrix[1][0] == "Y" && matrix[2][0] == "Y")
            {
                Console.WriteLine("Player Two has WON THE GAME!!!");
                stillPlaying = false;
            }
            else if (matrix[0][1] == "Y" && matrix[1][1] == "Y" && matrix[2][1] == "Y")
            {
                Console.WriteLine("Player Two has WON THE GAME!!!");
                stillPlaying = false;
            }
            else if (matrix[0][2] == "Y" && matrix[1][2] == "Y" && matrix[2][2] == "Y")
            {
                Console.WriteLine("Player Two has WON THE GAME!!!");
                stillPlaying = false;
            }
            else if (matrix[1][0] == "Y" && matrix[1][1] == "Y" && matrix[1][2] == "Y")
            {
                Console.WriteLine("Player Two has WON THE GAME!!!");
                stillPlaying = false;
            }
            else if (matrix[2][0] == "Y" && matrix[2][1] == "Y" && matrix[2][2] == "Y")
            {
                Console.WriteLine("Player Two has WON THE GAME!!!");
                stillPlaying = false;
            }
            else if (matrix[0][0] == "Y" && matrix[1][1] == "Y" && matrix[2][2] == "Y")
            {
                Console.WriteLine("Player Two has WON THE GAME!!!");
                stillPlaying = false;
            }
            else if (matrix[0][2] == "Y" && matrix[1][1] == "Y" && matrix[2][0] == "Y")
            {
                Console.WriteLine("Player Two has WON THE GAME!!!");
                stillPlaying = false;
            }
            else if (count == 9)
            {
                Console.WriteLine("This game is a draw.");
                stillPlaying = false;
            }


        }






        public void playerTurns()
        {
            string Xs;
            string Os;
            int xXvalue;
            int xYvalue;
            int oYvalue;
            int oXvalue;
            bool validator = false;


            while (validator == false)
            {
                Console.Write("Player 1, you are X's. What is the X axis value of your mark? ");
                Xs = Console.ReadLine();
                Console.Write("What is the Y axis value of your mark? ");

                xYvalue = Convert.ToInt32(Console.ReadLine()) - 1;

                xXvalue = positionSwitch(Xs);

                if (xXvalue <= -1 || xXvalue >= 3)
                {
                    Console.WriteLine("That coordinate was not valid. Please try again: ");
                }
                else if (xYvalue <= -1 || xYvalue >= 3)
                {
                    Console.WriteLine("That coordinate was not valid. Please try again: ");
                }
                else
                {
                    if (matrix[xYvalue][xXvalue] == "O" || matrix[xYvalue][xXvalue] == "X")
                    {

                        Console.WriteLine("That place is already taken.");
                    }
                    else
                    {
                        matrix[xYvalue][xXvalue] = "X";
                        validator = true;
                    }
                }
                WinCheck();
                validator = false;

                while (validator == false)
                {
                    gameBoard();
                    Console.Write("Player 2, you are O's. What is the X axis value of your mark? ");
                    Os = Console.ReadLine();
                    Console.Write("What is the Y axis value of your mark? ");
                    oYvalue = Convert.ToInt32(Console.ReadLine()) - 1;

                    oXvalue = positionSwitch(Os);

                    if (oXvalue <= -1 || oXvalue >= 3)
                    {
                        Console.WriteLine("That coordinate was not valid. Please try again: ");
                    }
                    else if (oYvalue <= -1 || oYvalue >= 3)
                    {
                        Console.WriteLine("That coordinate was not valid. Please try again: ");
                    }
                    else
                    {
                        if (matrix[oYvalue][oXvalue] == "X" || matrix[oYvalue][oXvalue] == "O")
                        {
                            Console.WriteLine("That place is already taken.");
                        }
                        else
                        {
                            matrix[oYvalue][oXvalue] = "O";
                            validator = true;
                        }
                    }
                    WinCheck();
                }




            }
        }
    }
}
