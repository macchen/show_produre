using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using show_produre.ADO;
using System.Data.SqlClient;
using System.Data.Sql;
namespace show_produre
{
    public partial class f_show_proc : Form
    {
        public f_show_proc()
        {
            InitializeComponent();

            
        }






        private void button1_Click(object sender, EventArgs e)
        {
            //getInstance();

            

            string data="",uid="",pwd="",database="";

            if (this.txtdatasource.Text.ToString().Length <= 0)
            {
                this.txtdatasource.Text = "127.0.0.1";
                data = this.txtdatasource.Text.ToString();

            }
            else
            {
                 data = this.txtdatasource.Text.ToString();
            }

            if (this.txtloginname.Text.Length <= 0)
            {
                this.txtloginname.Text = "sa";
                uid = this.txtloginname.Text.ToString();
            }
            else
            {
                uid = this.txtloginname.Text.ToString();
            }


            if (txtpwd.Text.Length <= 0)
            {
                pwd = "";
              
            }else
            {
                pwd = this.txtpwd.Text.Trim(); 
            }
            if(this.txtdbname.Text.Length<=0)
            {
                this.txtdbname.Text="master";
                database = this.txtdbname.Text.ToString();
            }
            else
            {
                 database = this.txtdbname.Text.ToString();
            }
            
             ADO.sqlConnect conn = new sqlConnect();
             conn.setConstring(data, uid, pwd, database);
             MessageBox.Show("123");
             cbboxGetdata(data, uid, pwd);
             
            //this.txtshow.Text = conn.getconstring();
            this.loadtreeview(conn.getconstring(data,uid,pwd,database),treeviewdata);
            
            
            

           



           


           // testform test = new testform();
           // test.Show();

            //this.Close();
            //this.Hide();
        }



        /// <summary>
        /// 获取数据库集合
        /// </summary>
        /// <param name="data"></param>
        /// <param name="uid"></param>
        /// <param name="pwd"></param>
        public void cbboxGetdata(string data,string uid,string pwd)
        {
            ADO.sqlConnect conn = new sqlConnect();
            cboxdb.DataSource = conn.getresult("select name from master..sysdatabases ");
           // cboxdb.
            cboxdb.DisplayMember = "name";
            
        }

        /// <summary>
        /// treeview数据绑定
        /// </summary>
        /// <param name="constr"></param>
        public void loadtreeview(string constr,TreeView tv)
        {
            //先清空TreeView 中所有的节点
            tv.Nodes.Clear();


            // 获取父节点的数据源
            ADO.sqlConnect conn = new sqlConnect();
            string sql = "select type,(case type when 'P' then '存储过程' when 'TR' then '触发器'when 'FN' then '函数' when 'V' then '视图' else '其它' end)name from sysobjects where type in('P','TR','FN','V')group by type";
            DataTable dt = conn.getresult(sql);

            //增加父节点
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    TreeNode node = new TreeNode();
                    node.Text = row["name"].ToString();
                    node.Tag = row["type"].ToString();
                    tv.Nodes.Add(node);
                    //增加子节点
                    this.AddSubNode(node, constr);

                }

            }
            //展开所有节点
            tv.ExpandAll();

        }


        public void AddSubNode(TreeNode ParentNode,string constr)
        {
            ADO.sqlConnect conn = new sqlConnect();
            string sql="select name,type from sysobjects where type ="+"'"+ParentNode.Tag.ToString()+"'"+"order by name";
            //string sql1 = "select name,type from sysobjects where name =" + "'sp_decrypt"+"'"+"and type= " + "'" + ParentNode.Tag.ToString() + "'" + "order by name";
                

            DataTable dt = conn.getresult(sql);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    TreeNode node = new TreeNode();
                    node.Text = row["name"].ToString();
                    node.Tag = row["type"].ToString();
                    ParentNode.Nodes.Add(node);

                }
            }

        }

        /// <summary>
        ///  获取局域网中的SQL实例（SQLBROWER 服务需要开启，否则返回空）
        /// </summary>
        private void getInstance()
        {
            SqlDataSourceEnumerator DataSourceEnumerator = SqlDataSourceEnumerator.Instance;
            DataTable dt = DataSourceEnumerator.GetDataSources();
            List<string> list = new List<string>();

            foreach (System.Data.DataRow row in dt.Rows)
            {
                list.Add(row["servername"].ToString());
            }


            this.cbox_datasource.DataSource = list;

        }



        private void treeviewdata_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string data = this.txtdatasource.Text.ToString();
            string uid = this.txtloginname.Text.ToString();
            string pwd = "";
            if (txtpwd.Text.Length <= 0)
            {
                pwd = "";
            }
            else 
            {
                 pwd = this.txtpwd.Text.ToString();
            }
            string database = this.txtdbname.Text.Trim();

            TreeNode node = treeviewdata.SelectedNode;
            //txtshow.Text = node.Text.ToString();
            sqlConnect conn = new sqlConnect();
           // 
            try
            {
                //txtshow.Text = "dbo.sp_decrypt" + "" + node.Text.ToString();

                txtshow.Text = conn.GetDataSet1("dbo.sp_decrypt", node.Text.ToString()).ToString();
              

            }
            catch (Exception ex )
            {
                txtshow.Text = ex.ToString();
                
                //throw ;
            }
           
             
        }

       

        private void txtshow_DoubleClick(object sender, EventArgs e)
        {
            if (txtshow.Text.ToString().Length>0)
            {
                Clipboard.SetText(this.txtshow.Text, TextDataFormat.Text);
                MessageBox.Show("内容已复制到剪贴板！", "温馨提示");
            }
            else
            {
                
                MessageBox.Show("内容为空无法双击复制！", "温馨提示");
            }
                
        }

        

        private void cboxdb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.txtdbname.Text = this.cboxdb.Text;
        }

        private void txtshow_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtshow, "双击复制到剪贴板");
        }


      

       

      
       
       
       
    }
}
