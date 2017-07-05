using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //load or call Bussiness object class in memory and get and set the value in variables
        Bussiness_Object bo = new Bussiness_Object();
        bo.Password_value = TextBox2.Text;
        bo.Qualification_value = TextBox3.Text;
        bo.Age_value = TextBox4.Text;
        bo.Mobile_value = TextBox5.Text;

        Bussiness_Layer Bl = new Bussiness_Layer();

        try
        {
            string result = Bl.record_insert(bo);
            if (result != null)
            {
                Label1.Text = "Data successfully inserted";

            }
            else
            {
                Label1.Text = "plz try again";
            }
        }
        catch (Exception ex)
        {
            Response.Write("Error Msg:" + ex.Message);
            
        }
        finally {

            bo = null;
            Bl = null;
        }

    }
}