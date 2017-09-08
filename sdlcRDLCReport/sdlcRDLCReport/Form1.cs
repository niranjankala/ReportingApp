using ReportExporterUtility;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace sdlcRDLCReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }       

        private void button1_Click(object sender, EventArgs e)
        {

            string dummyFileName = "OutputFile";

            SaveFileDialog sf = new SaveFileDialog();
            // Feed the dummy name to the save dialog
            sf.FileName = dummyFileName;
            string savePath = "";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                // Now here's our save folder
                 savePath = Path.GetFullPath(sf.FileName);
                // Do whatever
            }

            string reportPath = string.Format("{0}\\Reports\\Report1.rdlc", System.Windows.Forms.Application.StartupPath);
            DataTable dt = new DataBaseService().RDLCMemmory();
            dt.TableName = "KMTeams";
            //reportName = invoice.InvoiceType == "BK" ? "BKInvoice.rdlc" : invoice.InvoiceType == "LIT" ? "LITInvoice.rdlc" : invoice.InvoiceType == "LITCOM" ? "LITComInvoice.rdlc" : invoice.InvoiceType == "BKLIT" ? "BKLITInvoice.rdlc" : "StandardInvoice.rdlc";
            ReportExporter exporter = new ReportExporter();
            exporter.ExportToPdf(reportPath, dt, savePath);
        }
    }
}