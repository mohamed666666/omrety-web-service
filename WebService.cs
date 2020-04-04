using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://omrety.com/webservice")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService 
{
     Auth s = new Auth();
    
   [WebMethod]
    public int Pushdata(string Name,string Jop,int PhonNumber,string Address,int Age)
    {
        string con = s.conn();
        SqlConnection sqlcon = new SqlConnection(con);

            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("Insert into customerdata(name,jop, phoneNumber,Address,Age ) values('" + Name + "','" + Jop + "','" + PhonNumber + "','" + Address + "','" + Age + "')", sqlcon);
            
            int rows= sqlcmd.ExecuteNonQuery();
        sqlcon.Close();
        return rows;
    }

}
