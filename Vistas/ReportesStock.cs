using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using static System.Net.WebRequestMethods;

namespace ExamenParcial2.Vistas
{
    public partial class ReportesStock : UserControl
    {
        public ReportesStock()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataSetProductos dataSet = new DataSetProductos();
            this.productosTableAdapter.Fill(dataSet.Productos);
            this.reportViewer1.LocalReport.ReportPath = "C:\\Users\\Jonathan\\source\\repos\\ExamenParcial2\\Vistas\\ReporteBD.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DataSetDeProductos", dataSet.Tables["Productos"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport(); //tuve que hacerlo manualmente por un bug...
        }
    }
}
