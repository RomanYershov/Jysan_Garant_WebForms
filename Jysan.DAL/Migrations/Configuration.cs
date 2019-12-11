using System.Collections.Generic;
using Jysan.DAL.Entities;

namespace Jysan.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Jysan.DAL.EF.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Jysan.DAL.EF.ApplicationDbContext context)
        {
            var indiv1 = new Individual
            {
                Iin = "111122223333",
                FirstName = "Andrey",
                LastName = "Troelson",
                Patronymic = "Korneevich"
            };
            var indiv2 = new Individual
            {
                Iin = "222233334444",
                FirstName = "Makar",
                LastName = "Petrov",
                Patronymic = "Ivanovich"
            };
            var indiv3 = new Individual
            {
                Iin = "333344445555",
                FirstName = "Antuan",
                LastName = "Ivanov",
                Patronymic = "Romanov"
            };
            var indiv4 = new Individual
            {
                Iin = "444455556666",
                FirstName = "Nikola",
                LastName = "Sergeevich",
                Patronymic = "Piterskiy"
            };
            var legal1 = new LegalEntity
            {
                Iin = "555566667777",
                Name = "TO_Name_1",
                Individuals = new List<Individual> { indiv1 }
            };
            var legal2 = new LegalEntity
            {
                Iin = "666677778888",
                Name = "TO_Name_2",
                Individuals = new List<Individual> { indiv2, indiv3 }
            };
            var legal3 = new LegalEntity
            {
                Iin = "777788889999",
                Name = "TO_Name_3",
                Individuals = new List<Individual> {  indiv4 }
            };
            context.Individuals.AddRange(new[] { indiv1, indiv2, indiv3, indiv4 });
            context.LegalEntities.AddRange(new[] { legal1, legal2, legal3 });
            context.SaveChanges();
        }
    }
}
