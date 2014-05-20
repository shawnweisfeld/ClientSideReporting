using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientSideReportingWeb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GenerateInCode_Click(object sender, EventArgs e)
        {
            using (var rpt = new LocalReport())
            {
                rpt.ReportPath = Server.MapPath("~/Customers.rdlc");
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

                Response.ClearContent();
                Response.ClearHeaders();
                Response.AddHeader("content-disposition", "attachment; filename=Report." + fileNameExtension);
                Response.OutputStream.Write(renderedBytes, 0, renderedBytes.Length);
                Response.End();

            }
        }
    }
}