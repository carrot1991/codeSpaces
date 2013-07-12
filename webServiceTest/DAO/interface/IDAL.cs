using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAO
{
    public interface IDAL
    {
        Boolean save(Object t);
        Boolean saveTWO(Object t1, Object t2);
        Boolean delete(Object t);
        List<Object> query();
        Boolean update(Object t);
        SqlConnection getConnection();
    }
}
