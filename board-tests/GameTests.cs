using game_logic.models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace board_tests
{
    public class GameTests
    {
        [Fact]
        public void PlayerOneHasFirstTurn()
        {
            var player1 = new Player(1);
            var player2 = new Player(2);

            var game = new Game(player1, player2);
          
            Assert.Equal(player1, game.CurrentPlayer);
        }

        [Fact]
        public void PlayersAlternateTurns()
        {
            var player1 = new Player(1);
            var player2 = new Player(2);

            var game = new Game(player1, player2);

            game.Move(player: player1, boardIndex: 1, boardPosition: 1);

            Assert.Equal(player2, game.CurrentPlayer);

            game.Move(player: player2, boardIndex: 1, boardPosition: 2);

            Assert.Equal(player1, game.CurrentPlayer);
        }
    }
}
