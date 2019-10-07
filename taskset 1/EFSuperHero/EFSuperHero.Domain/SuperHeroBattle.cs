using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFSuperHero.Domain
{
    public class SuperHeroBattle
    {
        [Key]
        [Column(Order=1)]
        [ForeignKey("SuperHero")]
        public int SuperHeroId { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Battle")]
        public int BattleId { get; set; }
        public SuperHero SuperHero { get; set; }
        public Battle Battle { get; set; }
    }
}
