using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Bussiness_Object
/// </summary>
public class Bussiness_Object
{
    
    //Declare Registration Detail
    
    public string password;
    public string qualification;
    public string age;
    public string mobile;

    //use properties concept in C#, to get and set the values in variables
    public string Password_value
    {
        get
        {
            return password;
        }
        set
        {
            password = value;

        }
    }
    public string Qualification_value
    {
        get
        {
            return qualification;
        }
        set
        {
            qualification = value;

        }
    }
    public string Age_value
    {
        get
        {
            return age;
        }
        set
        {
            age = value;
        }
    }
    public string Mobile_value
    {
        get
        {
            return mobile;
        }
        set 
        {
            mobile = value;
            
        }
    }
}