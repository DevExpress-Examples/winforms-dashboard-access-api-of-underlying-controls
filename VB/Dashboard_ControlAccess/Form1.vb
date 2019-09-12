Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.DashboardWin
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPivotGrid

Namespace Dashboard_ControlAccess
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			dashboardViewer1.LoadDashboard("..\..\Data\Dashboard.xml")
		End Sub

		Private Sub dashboardViewer1_DashboardItemControlCreated(ByVal sender As Object, ByVal e As DashboardItemControlEventArgs) Handles dashboardViewer1.DashboardItemControlCreated
			If e.DashboardItemName = "pivotDashboardItem1" Then
				Dim pivotGridControl As PivotGridControl = e.PivotGridControl
				AddHandler pivotGridControl.CustomCellValue, AddressOf pivotGridControl_CustomCellValue
			End If
		End Sub

		Private Sub pivotGridControl_CustomCellValue(ByVal sender As Object, ByVal e As PivotCellValueEventArgs)
			If e.Value IsNot Nothing AndAlso DirectCast(e.Value, Decimal) < 2000 Then
				e.Value = "Too low to show"
			End If
		End Sub

		Private Sub dashboardViewer1_DashboardItemControlUpdated(ByVal sender As Object, ByVal e As DashboardItemControlEventArgs) Handles dashboardViewer1.DashboardItemControlUpdated
			If e.DashboardItemName = "gridDashboardItem1" Then
				Dim gridView As GridView = TryCast(e.GridControl.MainView, GridView)
				gridView.Appearance.Row.Font = New Font("Segoe Script", 10)
			End If
			If e.DashboardItemName = "chartDashboardItem1" Then
				Dim chartControl As ChartControl = e.ChartControl
				CType(chartControl.Diagram, XYDiagram).Panes(0).BackColor = Color.Orange
			End If
		End Sub

		Private Sub dashboardViewer1_DashboardItemBeforeControlDisposed(ByVal sender As Object, ByVal e As DashboardItemControlEventArgs) Handles dashboardViewer1.DashboardItemBeforeControlDisposed
			If e.DashboardItemName = "pivotDashboardItem1" Then
				Dim pivotGridControl As PivotGridControl = e.PivotGridControl
				RemoveHandler pivotGridControl.CustomCellValue, AddressOf pivotGridControl_CustomCellValue
			End If
		End Sub
	End Class
End Namespace
