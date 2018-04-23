<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TimeSpanColumn._Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxGridView.v9.1, Version=9.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>The TimeSpan data support in the ASPxGridView</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dxwgv:ASPxGridView ID="ASPxGridView1" runat="server">
            <Settings ShowFilterBar="Visible" ShowGroupPanel="True" 
                ShowHeaderFilterButton="True" />
        </dxwgv:ASPxGridView>
    </div>
    </form>
</body>
</html>
