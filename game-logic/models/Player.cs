using System;
using System.Collections.Generic;
using System.Text;

namespace game_logic.models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Player(int id) => Id = id;
    }
}
