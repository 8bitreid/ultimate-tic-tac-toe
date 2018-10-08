using System;
using System.Collections.Generic;
using System.Text;

namespace game_logic.models
{
    public abstract class Board
    {
        public abstract MoveResult Move(Player player, int position);
    }
}
