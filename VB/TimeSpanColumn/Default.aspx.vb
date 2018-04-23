Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data
Imports DevExpress.Data.Filtering

Namespace TimeSpanColumn
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
			ASPxGridView1.DataSource = GetDataTable()
		End Sub
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ASPxGridView1.DataBind()
			If (Not IsPostBack) AndAlso (Not IsCallback) Then
				ASPxGridView1.GroupBy(ASPxGridView1.Columns("TimeSpan"))
				Dim filter As CriteriaOperator = New OperandProperty("TimeSpan") = New OperandValue(New TimeSpan(1, 0, 0))
				ASPxGridView1.FilterExpression = filter.ToString()
			End If
		End Sub

		Private Function GetDataTable() As DataTable
			Dim table As New DataTable()
			table.Columns.Add("ID", GetType(Integer))
			table.Columns.Add("TimeSpan", GetType(TimeSpan))
			table.Rows.Add(1, New TimeSpan(1, 0, 0))
			table.Rows.Add(2, New TimeSpan(0, 30, 0))
			table.Rows.Add(3, New TimeSpan(3, 0, 0))
			table.Rows.Add(4, New TimeSpan(0, 30, 0))
			Return table
		End Function
	End Class
End Namespace
