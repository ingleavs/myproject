using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for Data_access_layer
/// </summary>
public class Data_access_layer
{
    //insert registration details in stuent table
    public string registration_details(Bussiness_Object user_detail)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into Student values(@b,@c,@d,@e)", con);
        try
        {
            cmd.Parameters.AddWithValue("@b", user_detail.password);
            cmd.Parameters.AddWithValue("@c", user_detail.qualification);
            cmd.Parameters.AddWithValue("@d", user_detail.age);
            cmd.Parameters.AddWithValue("@e", user_detail.mobile);
            return cmd.ExecuteNonQuery().ToString();
        }
        catch (Exception)
        {

            throw;
        }
        finally {
            con.Close();
        }
    
    }

   //update registration details in student table
    public string updatedetail(Bussiness_Object id)
    {
        


    }

}