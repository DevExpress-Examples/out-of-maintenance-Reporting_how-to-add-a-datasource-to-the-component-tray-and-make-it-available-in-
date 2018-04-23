using System;
using System.Windows.Forms;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UserDesigner;
using EUD_AddDataSource.nwindDataSetTableAdapters;
// ...

namespace EUD_AddDataSource {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        nwindDataSet ds = new nwindDataSet();
        ProductsTableAdapter adapter = new ProductsTableAdapter();

        private void button1_Click(object sender, EventArgs e) {
            // Create an End-User Designer form.
            XRDesignFormEx form = new XRDesignFormEx();

            // Create a report instance.
            XtraReport1 report = new XtraReport1();

            // Add data components to the Designer Host.
            form.DesignPanel.DesignerHostLoaded += 
                new DesignerLoadedEventHandler(OnDesignerLoaded);

            // Load the report into the End-User Designer.
            form.OpenReport(report);

            // Bind the report to data.
            report.DataSource = ds;
            report.DataAdapter = adapter;
            report.DataMember = "Products";            
            
            // Show the End-User Designer form.
            form.ShowDialog();
        }

        private void OnDesignerLoaded(object sender, DesignerLoadedEventArgs e) {
            DesignToolHelper.AddToContainer(e.DesignerHost, ds);
            DesignToolHelper.AddToContainer(e.DesignerHost, adapter);
        }

    }

}