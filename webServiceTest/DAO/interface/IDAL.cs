using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public interface IDAL
    {
        Boolean save(Object t);
        Boolean delete(Object t);
        List<Object> query();
        Boolean update(Object t);
    }
}
