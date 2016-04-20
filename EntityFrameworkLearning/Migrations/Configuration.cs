namespace EntityFrameworkLearning.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkLearning.Models.MusicStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "EntityFrameworkLearning.Models.MusicStoreContext";
        }

        protected override void Seed(EntityFrameworkLearning.Models.MusicStoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Artists.AddOrUpdate(new Models.Artist() { Name = "Band", Albums = new System.Collections.Generic.List<Models.Album>() { new Models.Album() { Title = "Album", Price = 9.99m }, new Models.Album() { Title = "Single", Price = 5.99m } } });

            context.Artists.AddOrUpdate(new Models.Artist() { Name = "Pop Band", Albums = new System.Collections.Generic.List<Models.Album>() { new Models.Album() { Title = "One Hit Wonder", Price = 9.99m } } });

            context.Artists.AddOrUpdate(new Models.SoloArtist() { Name = "Jeff Solo", Instrumnet = "Guitar", Albums = new System.Collections.Generic.List<Models.Album>() { new Models.Album() { Title = "Solo Guitar", Price = 7.99m }, new Models.Album() { Title = "Single Guitar", Price = 7.99m } } });

            context.SaveChanges();
        }
    }
}
