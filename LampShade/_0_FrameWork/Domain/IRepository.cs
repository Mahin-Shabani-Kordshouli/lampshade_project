using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace _0_FrameWork.Domain
{
    public interface IRepository<Tkey,T> where T:class
    {
        T Get(Tkey Id);
        List<T> Get();
        void SaveChange();
        void Create(T entity);
        bool Exist(Expression<Func<T,bool>>  expression);
    }
}
