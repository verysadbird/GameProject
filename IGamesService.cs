using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGamesService
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
    }
}
