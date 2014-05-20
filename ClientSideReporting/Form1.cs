using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSideReporting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateInCode_Click(object sender, EventArgs e)
        {
            using (var rpt = new LocalReport())
            {
                rpt.ReportPath = "Customers.rdlc";
                var data = DataAccess.Customer.Get();
                var rds = new ReportDataSource("CustomerDataSet", data);
                rpt.DataSources.Add(rds);

                string reportType = "WORDOPENXML";
                string mimeType;
                string encoding;
                string fileNameExtension;

                //The DeviceInfo settings should be changed based on the reportType
                //http://msdn2.microsoft.com/en-us/library/ms155397.aspx
                string deviceInfo =
                "<DeviceInfo>" +
                "  <OutputFormat>WORDOPENXML</OutputFormat>" +
                "  <PageWidth>8.5in</PageWidth>" +
                "  <PageHeight>11in</PageHeight>" +
                "  <MarginTop>0.5in</MarginTop>" +
                "  <MarginLeft>1in</MarginLeft>" +
                "  <MarginRight>1in</MarginRight>" +
                "  <MarginBottom>0.5in</MarginBottom>" +
                "</DeviceInfo>";

                Warning[] warnings;
                string[] streams;
                byte[] renderedBytes;

                //Render the report
                renderedBytes = rpt.Render(
                    reportType,
                    deviceInfo,
                    out mimeType,
                    out encoding,
                    out fileNameExtension,
                    out streams,
                    out warnings);

                using (var fd = new SaveFileDialog())
                {
                    fd.Filter = "word files (*.docx)|*.docx|All files (*.*)|*.*";
                    if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        File.WriteAllBytes(fd.FileName, renderedBytes);
                        System.Diagnostics.Process.Start(fd.FileName);
                    }
                }

            }
        }

        private void btnReportViewer_Click(object sender, EventArgs e)
        {
            using (var frm = new ReportForm())
            {
                frm.ShowDialog();
            }
        }
    }
}
