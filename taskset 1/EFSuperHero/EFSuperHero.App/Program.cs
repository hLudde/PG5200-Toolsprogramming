using System;
using EFSuperHero.Data;
using EFSuperHero.Domain;

namespace EFSuperHero.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        private static void AddOneSuperHero()
        {
            var SuperHero = new SuperHero()
            {
                Name = "FoxBear"
            };
            using (var context = new SuperHeroContext())
            {
                context.SuperHeroes.Add(SuperHero);
                context.SaveChanges();
            }
        }

        private static void AddSomeSuperHeros()
        {
            SuperHero[] superHeroes =
            {
                new SuperHero(){Name = "Superman"},
                new SuperHero(){Name = "Batman"},
                new SuperHero(){Name = "Wonderwoman"}
            };
            using (var context = new SuperHeroContext())
            {
                context.SuperHeroes.AddRange(superHeroes);
                context.SaveChanges();
            }
        }
    }
}
