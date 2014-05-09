﻿using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using Samples.Models;

namespace Samples {



    public partial class ForeignKey_EditField : System.Web.DynamicData.FieldTemplateUserControl {

		protected IGenericRepository _repo = new GenericRepository();

		public string DataTypeName { get; set; }

		public string DataTextField { get; set; }

		public string DataValueField { get; set; }

		
        public IQueryable GetData()
        {
			return _repo.Query(this.DataTypeName);
        } 


        protected void Page_Load(object sender, EventArgs e) {
			Label1.Text = Column.DisplayName;
        }

		
        protected override void ExtractValues(IOrderedDictionary dictionary)
        {
            // If it's an empty string, change it to null
            string value = DropDownList1.SelectedValue;
            if (String.IsNullOrEmpty(value))
            {
                value = null;
            }

            dictionary[Column.Name] = ConvertEditedValue(value);
        }


        public override Control DataControl {
            get {
                return DropDownList1;
            }
        }
    
    }
}
