using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.src
{
    public enum GameState
    {
        // Player is on main menu screen
        ViewingMainMenu,

        // Player is on in-game menu screen
        ViewingGameMenu,

        // Player is viewing high scores screen
        ViewingHighScores,

        // Player is playing the game
        Playing,

        // Player is viewing the end game screen
        EndingGame,

        // Player has quit the game
        Quitting
    }
}
