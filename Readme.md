<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580597/18.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T197114)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_ControlAccess/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_ControlAccess/Form1.vb))
<!-- default file list end -->
# Dashboard for WinForms - How to Access Underlying Controls in the WinForms Viewer


The following example demonstrates how to customize controls used to visualize data within dashboard items at runtime.

In this example, the following options are changed:

* The row font is changed in the underlying grid control in the [DashboardViewer.DashboardItemControlUpdated](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardItemControlUpdated) event handler.
* The background color of the chart's pane is changed in the [DashboardViewer.DashboardItemControlUpdated](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardItemControlUpdated) event handler.
* Cell values in the underlying pivot grid control are changed in the [PivotGridControl.CustomCellValue](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomCellValue) event handler. Subscription and unsubscription to/from the CustomCellValue event are performed in the [DashboardViewer.DashboardItemControlCreated](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardItemControlCreated) and [DashboardViewer.DashboardItemBeforeControlDisposed](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardItemBeforeControlDisposed) event handlers respectively.

![screenshot](/images/screenshot.png)

## Documentation

* [Access to Underlying Controls](https://docs.devexpress.com/Dashboard/18019/winforms-dashboard/winforms-viewer/access-to-underlying-controls)
* [Underlying and Displayed Data](https://docs.devexpress.com/Dashboard/401193/common-features/underlying-and-displayed-data/underlying-data)
* [Obtaining Underlying and Displayed Data](https://docs.devexpress.com/Dashboard/17269/winforms-dashboard/winforms-viewer/obtaining-underlying-and-displayed-data)

## More Examples

- [Access to Underlying Controls](https://docs.devexpress.com/Dashboard/18019)
