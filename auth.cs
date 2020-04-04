using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for auth
/// </summary>
public class Auth :System.Web.Services.Protocols.SoapHeader
{
   
   
        string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
      
   public string conn()
    {
        return con;
    }
}