using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace game_logic.models
{
    public class LocalBoard : Board
    {
        const int LOWER_BOUND = 0;
        const int HIGH_BOUND = 8;
        readonly int?[] _board = new int?[HIGH_BOUND + 1];
                
        public override MoveResult Move(Player player, int atPosition)
        {
            if (IsInvalidIndex(atPosition) || IsIndexOccupied(atPosition))
                return new MoveResult(false);

            _board[atPosition] = player.Id;

            return new MoveResult(true);
        }

        private bool IsIndexOccupied(int atPosition) => _board[atPosition].HasValue;
        private bool IsValidIndex(int atPosition) => atPosition >= LOWER_BOUND && atPosition <= HIGH_BOUND;
        private bool IsInvalidIndex(int atPosition) => !IsValidIndex(atPosition);

        public int[] GetUnoccupiedPositions()
        {
            return GetPositions(null);
        }

        public int[] GetOccupiedPositions(Player player)
        {
            return GetPositions(player.Id);
        }

        private int[] GetPositions(int? someId)
        {
            var positionsById = _board.Select((value, index) => new { value, index })
                .GroupBy(obj => obj.value ?? null, obj => obj.index)
                .Select(grp => new { id = grp.Key, positions = grp.ToArray() });

            return positionsById.SingleOrDefault(g => g.id == someId)?.positions ?? new int[0];
        }
    }

}
