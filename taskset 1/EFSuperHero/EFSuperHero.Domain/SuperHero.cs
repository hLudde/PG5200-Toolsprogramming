using System.Collections.Generic;

namespace EFSuperHero.Domain
{
    public class SuperHero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RealIdentity RealIdentity { get; set; }
        public HairStyle? HairStyle { get; set; }
        public ICollection<Quote> Quotes { get; set; }
        public ICollection<SuperHeroBattle> SuperHeroBattles { get; set; }
    }
}
