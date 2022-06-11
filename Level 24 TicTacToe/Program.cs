using Level_24_TicTacToe;


game thisGame = new game();
thisGame.stillPlaying = true;

while (thisGame.stillPlaying == true)
{
    Console.Clear();
    thisGame.gameBoard();
    thisGame.WinCheck();
    thisGame.playerTurns();

    thisGame.WinCheck();

}
