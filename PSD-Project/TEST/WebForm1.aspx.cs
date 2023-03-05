using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_Project.TEST
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private readonly Raamen _db = new Raamen();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            TestLabel.Text = _db.Roles.FirstOrDefault()?.name ?? "No Role found";
        }
    }
}