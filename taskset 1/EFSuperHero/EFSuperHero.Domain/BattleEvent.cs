using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFSuperHero.Domain
{
    public class BattleEvent
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        
        [ForeignKey("BattleLog")]
        public int BattleLogRefId { get; set; }
        public BattleLog BattleLog { get; set; }
    }
}
