using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
namespace show_produre.ADO
{
    class sqlConnect
    {
        private SqlConnection sqlcon;


        /// <summary>
        /// 获取连接字符串
        /// </summary>
        /// <param name="datasource">数据源</param>
        /// <param name="userId">用户ID</param>
        /// <param name="pwd">密码</param>
        /// <param name="dbname">数据库名</param>
        /// <returns>连接字符串</returns>
        public string getconstring(string  datasource,string uid ,string pwd,string dbname)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource=datasource;
            builder.UserID = uid;
            builder.Password = pwd;
            builder.InitialCatalog = dbname;
        
            return  builder.ConnectionString;
        }



    

        public void setConstring(string datasource, string uid, string pwd, string dbname)
        {
            string newname = "connStr";
            string providerNewame = "System.Data.SqlClient";
            //string str = "Data Source=127.0.0.1;Integrated Security=True;Userid=sa,pwd=;Initial Catalog=master";
            string newConstr = string.Format("Data Source={0};Integrated Security=True;uid={1},pwd={2};Initial Catalog={3}",datasource,uid,pwd,dbname);
            UpdateConnectionStringsConfig(newname,newConstr,providerNewame);
            
        } 

        ///<summary>
        ///更新连接字符串
        ///</summary>
        ///<param name="newName">连接字符串名称</param>
        ///<param name="newConString">连接字符串内容</param>
        ///<param name="newProviderName">数据提供程序名称</param>
        public static void UpdateConnectionStringsConfig(string newName,string newConString,string newProviderName)
        {
            bool isModified = false;    //记录该连接串是否已经存在
            //如果要更改的连接串已经存在
            if (ConfigurationManager.ConnectionStrings[newName] != null)
            {
                isModified = true;
            }
            //新建一个连接字符串实例
            ConnectionStringSettings mySettings = new ConnectionStringSettings(newName, newConString, newProviderName);
            // 打开可执行的配置文件*.exe.config
            Configuration config =  ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // 如果连接串已存在，首先删除它
            if (isModified)
            {
                config.ConnectionStrings.ConnectionStrings.Remove(newName);
            }
            // 将新的连接串添加到配置文件中.
            config.ConnectionStrings.ConnectionStrings.Add(mySettings);
            // 保存对配置文件所作的更改
            config.Save(ConfigurationSaveMode.Modified);
            // 强制重新载入配置文件的ConnectionStrings配置节
            ConfigurationManager.RefreshSection("ConnectionStrings");
        }

        ///<summary>
        ///读取App.config的配置文件 
        /// </summary>
        /// <returns></returns>
        public string getconstring()
        {
            string sqlconn = System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ToString();

            return sqlconn;
        }


        //警告	1	“System.Configuration.ConfigurationSettings.AppSettings”已过时:“"This method is obsolete, it has been replaced by System.Configuration!System.Configuration.ConfigurationManager.AppSettings"”	D:\show_produre\show_produre\ADO\sqlConnect.cs	43	30	show_produre

        /// <summary>
        /// 打开指定SQL连接
        /// </summary>
        public void open_connect()
        {
            try
            {
                string constr = this.getconstring();
                sqlcon = new SqlConnection(constr);
            
                if (sqlcon.State == ConnectionState.Closed)
                {
                        sqlcon.Open();
                        MessageBox.Show(constr);
                    
                }
            }
            catch (Exception)
            {
                
                //throw;
                close_connect();
            }
            
        }



   
        /// <summary>
        ///  关闭SQL连接,并释放资源
        /// </summary>
        public void close_connect()
        {
            if (sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
                sqlcon.Dispose();
            }
        }


        public SqlCommand GetCmd(string constr)
        {
            SqlCommand cmd = new SqlCommand(constr);
            return cmd;
        }


        
        /// <summary>
        /// 获取查询数据(查询语句)
        /// </summary>
        public DataTable getresult(string sql)
        {
            open_connect();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, sqlcon);
            adapter.Fill(dt);
            close_connect();
            return dt;

         }


       /// <summary>
       /// 执行SQL，无返回值
       /// </summary>
       /// <param name="sql"></param>
       /// <param name="constr"></param>
       /// <param name="cmd"></param>
        public void   getresult(string sql,string constr,SqlCommand cmd)
        {
            
            open_connect();
            
            cmd  = new SqlCommand(sql, sqlcon);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close_connect();
            
        }



        /// <summary>
        /// 带一个参数的并存储过程
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="parm"></param>
        /// <returns>返回Datatable</returns>
         public DataTable GetDataTable(string sql,string type,string Parmvalue)
        {
             //需要尝试下有没有其他的添加变量的方式
            DataTable dt = new DataTable();

            string proc_parm = "@objectName";

            if (type == "P")
            {
                open_connect();
                //定义sqlcommand
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                // 指定cmd类型为 procedure
                cmd.CommandType=CommandType.StoredProcedure;
                //添加参数
                SqlParameter pares = new SqlParameter(proc_parm, SqlDbType.VarChar);
                //将参数绑定到 SqlCommand
                cmd.Parameters.Add(pares);
                //给参数赋值
                cmd.Parameters[proc_parm].Value = Parmvalue;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);
                
            }
            close_connect();
            return dt;
        }



         public DataSet GetDataSet(string sql,  string Parmvalue)
         {
             //需要尝试下有没有其他的添加变量的方式
             DataSet ds = new DataSet();
             
             string proc_parm = "@objectName";


             try
             {
                 open_connect();
                 //定义sqlcommand
                 SqlCommand cmd = new SqlCommand(sql, sqlcon);
                 // 指定cmd类型为 procedure
                 cmd.CommandType = CommandType.StoredProcedure;
                 //添加参数
                 SqlParameter pares = new SqlParameter(proc_parm, SqlDbType.VarChar);
                 //将参数绑定到 SqlCommand
                 cmd.Parameters.Add(pares);
                 //给参数赋值
                 cmd.Parameters[proc_parm].Value = Parmvalue;
                 SqlDataAdapter ada = new SqlDataAdapter(cmd);
                 
                 ada.Fill(ds);

             }
             catch (Exception)
             {

                 // throw ex;
                 close_connect();


             }
             finally
             {
                 close_connect();
             }
                return ds;
         }



        /// <summary>
        /// 获取多个表中的字符串
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="Parmvalue"></param>
        /// <param name="constr"></param>
        /// <returns></returns>
         
         public string GetDataSet1(string sql, string Parmvalue)
         {
            DataSet ds = this.GetDataSet(sql,Parmvalue);
            string getString="";
             
            //因select的长度限制，存储过程了两个结果集
            foreach (DataTable dtable in ds.Tables)
            {
                foreach (DataRow row in dtable.Rows)
                {
                    getString = getString + row[0].ToString();
                }

 
            }
                    
             return getString;
         }
    }

    
}
