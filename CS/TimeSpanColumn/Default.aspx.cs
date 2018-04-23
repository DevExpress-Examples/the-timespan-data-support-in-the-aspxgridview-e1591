using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DevExpress.Data.Filtering;

namespace TimeSpanColumn {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Init(object sender, EventArgs e) {
            ASPxGridView1.DataSource = GetDataTable();
        }
        protected void Page_Load(object sender, EventArgs e) {
            ASPxGridView1.DataBind();
            if(!IsPostBack && !IsCallback) {
                ASPxGridView1.GroupBy(ASPxGridView1.Columns["TimeSpan"]);
                CriteriaOperator filter = new OperandProperty("TimeSpan") == new OperandValue(new TimeSpan(1, 0, 0));
                ASPxGridView1.FilterExpression = filter.ToString();
            }
        }

        private DataTable GetDataTable() {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("TimeSpan", typeof(TimeSpan));
            table.Rows.Add(1, new TimeSpan(1, 0, 0));
            table.Rows.Add(2, new TimeSpan(0, 30, 0));
            table.Rows.Add(3, new TimeSpan(3, 0, 0));
            table.Rows.Add(4, new TimeSpan(0, 30, 0));
            return table;
        }
    }
}
