using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportExporterUtility
{
    public class ReportExporter
    {
        Microsoft.Reporting.WinForms.ReportViewer viewer;
        public ReportExporter()
        {
            viewer = new Microsoft.Reporting.WinForms.ReportViewer();
        }

        private void ConfigureReportViewer(string reportPath, DataTable reportData)
        {
            this.viewer.Reset();
            this.viewer.LocalReport.ReportPath = reportPath;
            this.viewer.LocalReport.DataSources.Clear();

            //this.reportViewer1.


            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(reportData);
            System.Windows.Forms.BindingSource bSource = new System.Windows.Forms.BindingSource();
            bSource.DataMember = reportData.TableName;
            bSource.DataSource = dataSet;

            ReportDataSource reportDSHeader = new ReportDataSource("DataSet1", bSource);
            this.viewer.LocalReport.DataSources.Add(reportDSHeader);
            this.viewer.RefreshReport();
        }

        public void ExportToPdf(string reportPath, DataTable reportData, string outputPath)
        {

            ConfigureReportViewer(reportPath, reportData);
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = viewer.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);

            MemoryStream imageStream = new MemoryStream(bytes, 0, bytes.Length);

            using (FileStream fs = new FileStream(outputPath + ".pdf", FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }


        }
        

        public Stream Export(string reportPath, DataTable reportData, ExportFormat format)
        {
            Stream stream = null;

            ConfigureReportViewer(reportPath, reportData);


            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = viewer.LocalReport.Render(
                format.ToString(), null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);

            stream = new MemoryStream(bytes, 0, bytes.Length);
            return stream;
        }
    }
}
