using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkLearning.Models.Repositories
{
    public class AlbumRepository : Repository<Album>
    {
        public List<Album> GetByName(String title)
        {
            return DbSet.Where(a => a.Title.Contains(title)).ToList();
        }
    }
}