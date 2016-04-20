using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Diagnostics;

namespace EntityFrameworkLearning.Models
{
    public class MusicStoreContext : DbContext
    {
        public MusicStoreContext()
        {
            Database.Log = s => Debug.WriteLine(s);
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistDetails> ArtistDetails { get; set; }
    }
}