using game_logic.models;
using System;
using Xunit;

namespace board_tests
{
    public class MoveTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void ValidIndexesAreValid(int someGoodIndex)
        {
            var player1 = new Player(1);
            var board = new LocalBoard();

            Assert.True(board.Move(player1, someGoodIndex).IsValid);
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(9)]
        [InlineData(10)]
        public void InvalidIndexesAreInvalid(int someBadIndex)
        {
            var player1 = new Player(1);
            var board = new LocalBoard();

            Assert.False(board.Move(player1, someBadIndex).IsValid);
        }

        [Fact]
        public void PlayerCanNotMoveOnAnOccupiedSpace()
        {
            var player1 = new Player(1);
            var player2 = new Player(2);

            var board = new LocalBoard();

            var move1Result = board.Move(player1, 1);
            var move2Results = board.Move(player2, 1);

            Assert.True(move1Result.IsValid);
            Assert.False(move2Results.IsValid);
        }
    }
}
