using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace DAO.implements
{

    public class DBDaoImpl :IDAL
    {
        private SqlConnection connection;

        public DBDaoImpl()
        {
            connection = new SqlConnection(ConfigUtil.getConnectionString());
        }
        public Boolean save(Object t)
        {
            connection.Open();
            string sql = createInsertSql(t);
            SqlCommand sqlco = new SqlCommand(sql, connection);
            int count = sqlco.ExecuteNonQuery();
            if(count==0)
                return false;
            return true;
        }
        public Boolean delete(Object t)
        {
            return true;
        }
        public List<Object> query()
        {
            return null;
        }
        public Boolean update(Object t)
        {
            return true;
        }


        public string createInsertSql(Object t)
        {
            StringBuilder insertSql = new StringBuilder();
            //修改
            Type type = t.GetType();
            string tableName = type.Name;
            insertSql.Append("insert into "+tableName+" values(");

            PropertyInfo[] props = type.GetProperties();
            foreach (PropertyInfo prop in props)
            {
                insertSql.Append("\'");
                object o = prop.GetValue(t, null);
                insertSql.Append(o.ToString()+"\',");
            }
            insertSql.Remove(insertSql.Length - 1, 1);
            insertSql.Append(")");
            return insertSql.ToString();
        }
    }
}
