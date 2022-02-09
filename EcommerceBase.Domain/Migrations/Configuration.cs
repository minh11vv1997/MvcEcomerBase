using EcommerceBase.Domain.Entities;
using EcommerceBase.Domain.Enums;
using GenFu;

namespace EcommerceBase.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EcommerceBase.Domain.EcommerceDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EcommerceBase.Domain.EcommerceDbContext context)
        {
            SeedDataOfCategory(context);
        }

        private void SeedDataOfCategory(EcommerceDbContext context)
        {
            if (!context.Categories.Any())
            {
                A.Configure<Category>()
                    .Fill(c => c.Status, CommonStatus.Active)
                    .Fill(c => c.ParentId, Guid.NewGuid());

                var categoriesObj = A.ListOf<Category>(50);

                context.Categories.AddRange(categoriesObj);
                context.SaveChanges();

            }
        }
    }

}