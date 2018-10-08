using System;
using System.Linq;

namespace game_logic.models
{
    public class Game
    {
        private readonly Player _initialPlayer;

        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }

        public Player CurrentPlayer => GetCurrentPlayer();

        const int NUMBER_OF_BOARDS = 9;

        public LocalBoard[] _localBoards;

        public Game()
        {
            _localBoards = Enumerable.Range(0, NUMBER_OF_BOARDS).Select(_ => new LocalBoard()).ToArray();
        }


        public Game(Player player1, Player player2) : this()
        {
            Player1 = player1;
            Player2 = player2;

            _initialPlayer = Player1;
        }

        public MoveResult Move(Player player, int boardIndex, int boardPosition)
        {
            return _localBoards[boardIndex].Move(player, boardPosition);
        }

        private Player GetCurrentPlayer()
        {
            Func<Player, int> getOccupiedPositionCount = (forPlayer)
                => _localBoards.Sum(board => board.GetOccupiedPositions(forPlayer).Count());

            var player1PositionCount = getOccupiedPositionCount(Player1);
            var player2PositionCount = getOccupiedPositionCount(Player2);

            Player currentPlayer = null;
            // If the counts are the same, it's the inital players turn
            if (player1PositionCount == player2PositionCount)
                currentPlayer = _initialPlayer;
            else if (player1PositionCount > player2PositionCount)
                currentPlayer = Player2;
            else
                currentPlayer = Player1;

            return currentPlayer;
        }
    }
}
