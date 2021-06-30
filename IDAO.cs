using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _TP_5
{
    public interface IDAO<T>
    {
        int Delete(string id);
        int Insert(T M);
        T Select(string id);
        int Update(T M);
    }
}