using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPG_Manager.Tools.Datamanagement
{
    public interface IRepository<T>
    {
        void SaveItem(T item);
        T? FindItem(Predicate<T> pred);
        void DeleteItem(T item);
    }
}
