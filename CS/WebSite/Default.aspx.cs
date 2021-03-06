using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxTabControl;
using DevExpress.Xpo;
using System.Drawing;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.ASPxEditors;
using System.Collections.Generic;
using DevExpress.Data;
using DevExpress.Web.ASPxDataView;
using System.Collections;

public partial class Validate_Edit_Form : System.Web.UI.Page 
{
    protected void grid_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e) {
        if(e.Column.FieldName == "max_lvl") {
             ASPxTextBox editor = e.Editor as ASPxTextBox;
             editor.ValidationSettings.RequiredField.IsRequired =  true;
        }
    }
}
