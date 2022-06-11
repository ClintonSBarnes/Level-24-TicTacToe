using Level_24_TicTacToe;


game thisGame = new game();
thisGame.stillPlaying = true;

while (thisGame.stillPlaying == true)
{
    thisGame.gameBoard();

    thisGame.playerTurns();
    


}
