using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFSuperHero.Domain
{
    public class BattleLog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Battle")]
        public int BattleRefId { get; set; }
        public Battle Battle { get; set; }
        public ICollection<BattleEvent> BattleEvents { get; set; }
    }
}
