using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CompanyReference.MyCompanyPublicServiceClient client1 = new
                CompanyReference.MyCompanyPublicServiceClient("BasicHttpBinding_IMyCompanyPublicService");
            Label1.Text = client1.GetPublicInformation();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CompanyReference.MyCompanyConfidentialServiceClient client2 = new
        CompanyReference.MyCompanyConfidentialServiceClient("NetTcpBinding_IMyCompanyConfidentialService");
            Label2.Text = client2.GetCofidentialInformation();
        }
    }
}