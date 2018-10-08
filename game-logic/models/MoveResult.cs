using System;
using System.Collections.Generic;
using System.Text;

namespace game_logic.models
{
    public class MoveResult
    {
        public bool IsValid { get; }

        public MoveResult(bool isValid) => IsValid = isValid;
    }
}
