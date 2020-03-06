﻿using Microsoft.EntityFrameworkCore;
using VoetbalTafel.Core.Models;
using System;
using System.Linq;

namespace VoetbalTafel.Core
{
    public class BaseService<T, TKey> where T : BaseModel<TKey>
    {
        private ApplicationDbContext _context;

        public ApplicationDbContext Context
        {
            get { return _context; }
            set { _context = value; }
        }

        public DbSet<T> Entities
        {
            get { return _context.Set<T>(); }
        }


        public BaseService()
        {
            _context = new ApplicationDbContext();
        }

        public ApplicationDbContext GetContext()
        {
            return Context;
        }

        public T GetById(object id)
        {
            return Entities.Find(id);
        }
        public IQueryable<T> GetAll()
        {
            return Entities;
        }

        public void Add(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                Entities.Add(entity);
                _context.SaveChanges();
            }
            catch { }
        }

        public void Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch { }
        }

        public void Remove(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                Remove(entity);
                _context.SaveChanges();
            } catch { }
        }
    }
}
