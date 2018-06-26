using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace easyChart
{
    public partial class MainWindows : DockContent
    {
        private readonly ChartView chartView = new ChartView();
        private readonly LineForm lineForm = new LineForm();
        private readonly PropForm propForm = new PropForm();
        private readonly WellForm wellForm = new WellForm();

        public MainWindows()
        {
            InitializeComponent();
        }

        private LoadData loadData { get; set; }

        private void MainWindows_Load(object sender, EventArgs e)
        {
            var theme = new VS2015BlueTheme();
            dockPanel1.Theme = theme;
            propForm.Show(dockPanel1, DockState.DockRight);
            lineForm.Show(dockPanel1, DockState.DockLeft);
            wellForm.Show(dockPanel1, DockState.DockLeft);
            chartView.Show(dockPanel1, DockState.Document);
        }

        private void open_toolStripButton_Click(object sender, EventArgs e)
        {
            openExcelFileDialog.Title = "选择导入的EXCEL文件";
            openExcelFileDialog.FileName = "";
            openExcelFileDialog.Filter = "EXCEL文件|*.xlsx;*.xls";
            openExcelFileDialog.RestoreDirectory = true;
            if (openExcelFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fName = openExcelFileDialog.FileName;
                loadData = new LoadData(fName);
                loadData.read_excel();

                var line_names = loadData.get_lines();
                foreach (var ln in line_names)
                    lineForm.treeView1.Nodes[0].Nodes.Add("数据项", ln, 1);

                var well_names = loadData.get_wells();
                foreach (var ln in well_names)
                    wellForm.well_listBox.Items.Add(ln);
            }
        }
    }
}