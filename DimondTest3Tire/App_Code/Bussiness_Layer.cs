using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Bussiness_Layer
/// </summary>
public class Bussiness_Layer
{
    public string record_insert(Bussiness_Object abc)
    {
        Data_access_layer dal = new Data_access_layer();
        try
        {
            return dal.registration_details(abc);
        }
        catch (Exception)
        {

            throw;
        }
        finally {
            dal = null;
        }
    }
}