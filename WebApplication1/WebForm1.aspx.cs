using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string date1 = DateTime.Now.ToString();
            if (Cache["MyKey"] == null)
            {
                Cache.Insert("MyKey", date1, null, DateTime.Now.AddDays(1), System.Web.Caching.Cache.NoSlidingExpiration);

            }
            else
            {
                string s = Cache["MyKey"].ToString();
            }

        }
    }
}
