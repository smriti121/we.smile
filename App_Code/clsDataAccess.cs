using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Collections.Generic;
/// <summary>
/// Summary description for clsDataAccessESUV
/// </summary>
public class clsDataAccess
{

    private DataTable _dt;
    private int _vic;
    private Page _page;
    private string _id;

    SqlConnection con = new SqlConnection();
    SqlTransaction Trans;
	public clsDataAccess()
	{

        con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;


	}

    public DataTable GetDataTable(string query)
    {
        DataTable dt = new DataTable();
        try
        {
            con.Open();
            //con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            SqlDataAdapter adap1 = new SqlDataAdapter();
            cmd.Connection = con;
            adap1.SelectCommand = cmd;
            adap1.Fill(dt);
            return dt;
        }
        catch (Exception ex)
        {
            //return ex.Message.ToString();
            return dt;
        }

        finally
        {
            con.Close();
        }

    }


    public DataTable GetDataTable(string query, SqlParameter[] param)
    {
        DataTable dt = new DataTable();
        try
        {
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            foreach (SqlParameter prm in param)
            {
                cmd.Parameters.Add(prm);
            }
            SqlDataAdapter adap1 = new SqlDataAdapter();
            cmd.Connection = con;
            adap1.SelectCommand = cmd;
            adap1.Fill(dt);
            return dt;
        }
        catch (Exception ex)
        {
            //return ex.Message.ToString();
            return dt;
        }

        finally
        {
            con.Close();
        }

    }

    public int ExecuteSql(string Query)
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();

            string strCommand = Query;
            cmd.CommandText = strCommand;
            cmd.Connection = con;
            return cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            return 0;

        }

        finally
        {
            con.Close();
        }

    }
    

    public int ExecuteSql(string Query, SqlParameter[] param)
    {

        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = Query;
            foreach (SqlParameter prm in param)
            {
                cmd.Parameters.Add(prm);
            }
            cmd.Connection = con;
            return cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            HttpContext.Current.Response.Write(ex.Message);

            return 0;

        }

        finally
        {
            con.Close();
        }



    }

    public int ExecuteSql(string Query, List<SqlParameter> param, Label lblMsg)
    {

        try
        {
            con.Open();
            //string strwhere = string.Empty;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = Query;
            foreach (SqlParameter prm in param)
            {
                cmd.Parameters.Add(prm);
                //strwhere = strwhere + "," + prm.Value;
            }
            cmd.Connection = con;
            return cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            //MessageBox.Show(ex.Message, "Error");
            lblMsg.Text = ex.Message;
            //lblMsg.Text = Query;
            return 0;

        }

        finally
        {
            con.Close();
        }



    }

    public string ExecuteScalar(string strSql)
    {
        SqlCommand cmd = new SqlCommand();
        try
        {

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            cmd.Connection = con;
            cmd.Connection.Open();
            return cmd.ExecuteScalar().ToString();
        }
        catch (Exception ex)
        {
            cmd.Connection.Close();
            return "";
        }
        finally
        {
            cmd.Connection.Close();

        }
    }

    public void OpenConnection()
    {
        SqlCommand cmd = new SqlCommand();
        con.Open();
        cmd.Connection = con;
    }
    public void CloseConnection()
    {
        con.Close();
    }

    public void BeginTransaction()
    {
        SqlCommand cmd = new SqlCommand();
        Trans = con.BeginTransaction(IsolationLevel.Serializable);
        cmd.Transaction = Trans;

    }
    public void BeginTransaction(IsolationLevel level)
    {
        SqlCommand cmd = new SqlCommand();
        Trans = con.BeginTransaction(level);
        cmd.Transaction = Trans;

    }

    public void Commit()
    {
        Trans.Commit();

    }
    public void Rollback()
    {
        Trans.Rollback();

    }

  

    //public void BindGrid(GridView gvShow, string sql,int totRecCount)
    //{




    //    FillGridView(gvShow);
    //}

    //public void FillGridView(GridView gvShow, string sql, int totRecCount)
    //{
    //    _dt = GetDataTable(sql);
    //    _vic = totRecCount;

    //    ObjectDataSource ods = new ObjectDataSource();

    //    ods.ID = "ods" + gvShow.ID;

    //    ods.EnablePaging = gvShow.AllowPaging;
    //    ods.TypeName = "clsPagingProperty";
    //    ods.SelectMethod = "GetData";
    //    ods.SelectCountMethod = "VirtualItemCount";
    //    ods.StartRowIndexParameterName = "startRow";
    //    ods.MaximumRowsParameterName = "maxRows";
    //    ods.EnableViewState = false;

    //    ods.ObjectCreating += new ObjectDataSourceObjectEventHandler(ods_ObjectCreating);

    //    gvShow.DataSource = ods;
    //    gvShow.DataBind();
    //}
    //private void ods_ObjectCreating(object sender, ObjectDataSourceEventArgs e)
    //{

    //    e.ObjectInstance = new clsPagingProperty(_dt, _vic);

    //}
    public object ExecuteScalar(string Query, SqlParameter[] param)
    {
        SqlCommand cmd = new SqlCommand();
        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Query;
            cmd.Connection = con;
            cmd.Connection.Open();
            if (param != null)
            {
                foreach (SqlParameter prm in param)
                {
                    cmd.Parameters.Add(prm);
                }
            }
            cmd.Connection = con;
            if (cmd.Connection.State == ConnectionState.Closed)
                cmd.Connection.Open();

            object objRet = cmd.ExecuteScalar();
            if (cmd.Connection.State == ConnectionState.Open)
                cmd.Connection.Close();

            return objRet;


        }
        catch (Exception ex)
        {
            if (cmd.Connection.State == ConnectionState.Open)
                cmd.Connection.Close();
            return null;
        }
        finally
        {
            if (cmd.Connection.State == ConnectionState.Open)
                cmd.Connection.Close();


        }
    }
}