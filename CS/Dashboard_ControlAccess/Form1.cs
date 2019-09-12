using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.DashboardWin;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraCharts;
using DevExpress.XtraPivotGrid;

namespace Dashboard_ControlAccess {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            dashboardViewer1.LoadDashboard(@"..\..\Data\Dashboard.xml");
        }

        private void dashboardViewer1_DashboardItemControlCreated(object sender, 
            DashboardItemControlEventArgs e) {
            if (e.DashboardItemName == "pivotDashboardItem1") {
                PivotGridControl pivotGridControl = e.PivotGridControl;
                pivotGridControl.CustomCellValue += pivotGridControl_CustomCellValue;
            }
        }

        void pivotGridControl_CustomCellValue(object sender, PivotCellValueEventArgs e) {
            if (e.Value != null && (decimal)e.Value < 2000)
                e.Value = "Too low to show";
        }

        private void dashboardViewer1_DashboardItemControlUpdated(object sender, 
            DashboardItemControlEventArgs e) {
            if (e.DashboardItemName == "gridDashboardItem1") {
                GridView gridView = e.GridControl.MainView as GridView;
                gridView.Appearance.Row.Font = new Font("Segoe Script", 10);
            }
            if (e.DashboardItemName == "chartDashboardItem1") {
                ChartControl chartControl = e.ChartControl;                
                ((XYDiagram)chartControl.Diagram).Panes[0].BackColor = Color.Orange;
            }
        }

        private void dashboardViewer1_DashboardItemBeforeControlDisposed(object sender, 
            DashboardItemControlEventArgs e) {
            if (e.DashboardItemName == "pivotDashboardItem1") {
                PivotGridControl pivotGridControl = e.PivotGridControl;
                pivotGridControl.CustomCellValue -= pivotGridControl_CustomCellValue;
            }
        }
    }
}
