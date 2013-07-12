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
      

        public Boolean saveTWO(Object t1,Object t2)
        {

            connection.Open();
            SqlTransaction tran = connection.BeginTransaction();
            
            try
            {

                string sql1 = createInsertOrUpdateSql(t1);
                string sql2 = createInsertOrUpdateSql(t2);
                SqlCommand sqlco = new SqlCommand(sql1, connection);
                sqlco.Transaction = tran;

              
                SqlCommand sqlco2 = new SqlCommand(sql2, connection);
                sqlco2.Transaction = tran;
                sqlco.ExecuteNonQuery();
                sqlco2.ExecuteNonQuery();
                tran.Commit();
                return true;

            }
            catch (Exception e)
            {
                tran.Rollback();
               
                throw e;
            }
            finally
            {
                connection.Close();
            }
        }
        public Boolean save(Object t)
        {
            return true;
        }
/*
        public Boolean saveCompliatObject(Object t)
        {
            openConnection();
            SqlTransaction tran = connection.BeginTransaction();
            try
            {
                save(t, tran);
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                throw e;
            }
            finally
            {
                closeConnection();
            }
        }

        public Boolean save(Object t, SqlTransaction tran)
        {          
            try
            {
                Type type = t.GetType();
                PropertyInfo[] props = type.GetProperties();
                foreach (PropertyInfo prop in props)
                {
                    Type propertyType = prop.PropertyType;
                    Boolean isClass = propertyType.IsClass && !(prop.PropertyType.Name == "String");
                    object propertyValue = prop.GetValue(t, null);
                    if (isClass)
                    {
                        save(propertyValue, tran);
                        Object id = propertyType.GetProperty("id");
                       // insertSql.Append(id.ToString() + "\',");
                    }
                   // insertSql.Append(propertyValue.ToString() + "\',");
                }

                string sql = createInsertOrUpdateSql(t);
                SqlCommand sqlco = new SqlCommand(sql, connection);
                sqlco.Transaction = tran;
                int count = sqlco.ExecuteNonQuery();
                if (count == 0)
                    return false;
                return true;

            }
            catch (Exception e)
            {
                throw e;
            }
           
        }

        public Boolean saveList(List<Object> list)
        {
            connection.Open();
            SqlTransaction ts = connection.BeginTransaction();
            try
            {
                foreach (Object obj in list)
                {
                    string sql = createInsertSql(obj);
                    SqlCommand sqlco = new SqlCommand(sql, connection);
                    sqlco.ExecuteNonQuery();
                }
                ts.Commit();
                return true;
            }
            catch (Exception e)
            {
                ts.Rollback();
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        */
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

        
        public string createInsertOrUpdateSql(Object t)
        {
            Type type = t.GetType();
            PropertyInfo id = type.GetProperty("id");
            String insertSql = createInsertSql(t);
            String updateSql = String.Empty;
            if (id == null)
                return insertSql.ToString();
            updateSql = createUpdateSql(t, id);


            StringBuilder upOrInSql = new StringBuilder();
            upOrInSql.Append(updateSql);
            upOrInSql.Append(" IF @@ROWCOUNT= 0 BEGIN ");
            upOrInSql.Append(insertSql);
            upOrInSql.Append(" END");
            return upOrInSql.ToString();
        }


        public string createUpdateSql(Object t, PropertyInfo id)
        {
            StringBuilder updateSql = new StringBuilder();
            //修改
            Type type = t.GetType();
            string tableName = type.Name;
            updateSql.Append("UPDATE " + tableName + " ");

            PropertyInfo[] props = type.GetProperties();
            foreach (PropertyInfo prop in props)
            {
                if (prop.Name == id.Name)
                    continue;
                Type propertyType = prop.PropertyType;
                Boolean isClass = propertyType.IsClass && !(prop.PropertyType.Name == "String");
                object propertyValue = prop.GetValue(t, null);
                //若是自定义类型属性，则insert语句中设置该对象的主键值
                if (isClass)
                {
                    Object proId = propertyType.GetProperty("id");
                    updateSql.Append("SET " + prop.Name + "=\'" + proId.ToString() + "\',");
                }

                updateSql.Append("SET " + prop.Name + "=\'" + propertyValue.ToString() + "\',");
            }
            updateSql.Remove(updateSql.Length - 1, 1);
            updateSql.Append(" WHERE " + id.Name + "=\'" + id.GetValue(t, null) + "\'");
            return updateSql.ToString();
        }

        public string createInsertSql(Object t)
        {
            StringBuilder insertSql = new StringBuilder();
            //修改
            Type type = t.GetType();

            string tableName = type.Name;
            insertSql.Append("insert into " + tableName + " values(");

            PropertyInfo[] props = type.GetProperties();
            foreach (PropertyInfo prop in props)
            {
                insertSql.Append("\'");
                Type propertyType = prop.PropertyType;
                Boolean isClass = propertyType.IsClass && !(prop.PropertyType.Name == "String");
                object propertyValue = prop.GetValue(t, null);
                if (isClass)
                {
                    PropertyInfo id = propertyType.GetProperty("id");
                    Object value = id.GetValue(propertyValue,null);
                    insertSql.Append(value.ToString() + "\',");
                }
                else
                    insertSql.Append(propertyValue.ToString() + "\',");
            }
            insertSql.Remove(insertSql.Length - 1, 1);
            insertSql.Append(")");
            return insertSql.ToString();
        }

        public SqlConnection getConnection()
        {
            return connection;
        }

        void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }
        /*
        void reopenConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            connection.Open();
        }*/
        void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

    
    }
}
