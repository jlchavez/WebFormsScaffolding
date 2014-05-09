﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Samples.Validation;
using Samples.Models;

namespace Samples._2_Validation.Book
{
    public partial class Default : System.Web.UI.Page
    {
		protected IGenericRepository _repo = new GenericRepository();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Model binding method to get List of Book entries
        // USAGE: <asp:ListView SelectMethod="GetData">
        public IQueryable<Samples.Validation.Book> GetData()
        {
            return _repo.Query<Samples.Validation.Book>();
        }
    }
}
