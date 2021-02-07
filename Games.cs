using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Games : IGamesService
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string Description { get; set; }
    }
}
