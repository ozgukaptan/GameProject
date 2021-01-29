using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string Platforms { get; set; }
        public int FirstReleaseDate { get; set; }
        public double UnitPrice { get; set; }
    }
}
