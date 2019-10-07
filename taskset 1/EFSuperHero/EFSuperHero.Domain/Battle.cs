using System;
using System.Collections.Generic;
using System.Text;

namespace EFSuperHero.Domain
{
    public class Battle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsBrutal { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { set; get; }
        public ICollection<SuperHeroBattle> SuperHeroBattles { get; set; }
        public BattleLog BattleLog { get; set; }
    }
}
