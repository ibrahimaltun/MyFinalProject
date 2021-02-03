using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    //generic constraint
    //class : referans tip olabilir demektir.
    //IEntity : IEntity olabilir veya Ientity implemente eden bir nesne olabilir.
    //new() : new'lenebilir olmalı. Interface new lenemez.
    public interface IEntityRepository<T> where T:class,IEntity,new()   
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
