using System.Collections.Generic;

namespace dotnetapplication.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
