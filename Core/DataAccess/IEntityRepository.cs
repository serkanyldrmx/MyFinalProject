﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Generic constraint
    //class: referans Tip olabilir yani entitilerimizden başka class alamaz
   //IEntity olabilir veya IEntity implemente eden bir nesne olabilir
   //new() :new'lenebilir olmalı
   //şuanda sadece veritabanı nesnleriyele çalışabilen bir repostory oldu
    
    public interface IEntityRepository<T> where T : class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
