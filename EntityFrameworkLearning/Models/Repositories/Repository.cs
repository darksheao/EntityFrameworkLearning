﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace EntityFrameworkLearning.Models.Repositories
{
    public class Repository<T> where T : class
    {
        private MusicStoreContext context = null;
        protected DbSet<T> DbSet { get; set; }

        public Repository()
        {
            context = new MusicStoreContext();
            DbSet = context.Set<T>();
        }

        public List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public DbEntityEntry Entry(T entry)
        {
            return context.Entry<T>(entry);
        }

        public void Remove(T entry)
        {
            DbSet.Remove(entry);
        }
    }
}