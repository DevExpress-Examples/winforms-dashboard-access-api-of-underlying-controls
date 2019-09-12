<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_ControlAccess/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_ControlAccess/Form1.vb))
<!-- default file list end -->
# How to Access Underlying Controls in the WinForms Viewer


The following example demonstrates how to customize controls used to visualize data within dashboard items at runtime.

In this example, the following options are changed:

* The row font is changed in the underlying grid control in the [DashboardViewer.DashboardItemControlUpdated](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardItemControlUpdated) event handler.
* The background color of the chart's pane is changed in the [DashboardViewer.DashboardItemControlUpdated](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardItemControlUpdated) event handler.
* Cell values in the underlying pivot grid control are changed in the [PivotGridControl.CustomCellValue](https://docs.devexpress.com/WinForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomCellValue) event handler. Subscription and unsubscription to/from the CustomCellValue event are performed in the [DashboardViewer.DashboardItemControlCreated](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardItemControlCreated) and [DashboardViewer.DashboardItemBeforeControlDisposed](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardItemBeforeControlDisposed) event handlers respectively.

![screenshot](/images/screenshot.png)

## See Also:

- [Access to Underlying Controls](https://docs.devexpress.com/Dashboard/18019)
