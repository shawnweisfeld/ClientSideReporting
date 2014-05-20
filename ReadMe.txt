The goal of this project is to provide some examples of the C# code required to use 
SQL Server Reporting Services without a report server.

The report is NOT fancy as showing the features of SSRS is not the goal of this project. 

Examples use data provided by the "DataAccess" library
(this is made up in this trivial example but could easily come from a database)

Data passed to the report is an IEnumberable<T>

ClientSideReporting - Windows Forms app
Example 1: open a screen with the full report viewer control
Example 2: generate report with custom UI

ClientSideReportingWeb - ASP.NET Webforms app
Example 1: screen with the full report viewer control
Example 2: generate report with custom UI

ClientSideReportingMvc - ASP.NET MVC app
Example 1: (report viewer control doesnt work in MVC)
Example 2: generate report with custom UI

To host in WPF you host the ReportViewer control inside a WindowsFormsHost control. 
http://msdn.microsoft.com/en-us/library/hh273267.aspx

Nested objects:
Nested classes will need to be flattened to a simple POCO that contains only simple types for reporting.

Report Viewer MSDN:
http://msdn.microsoft.com/en-us/library/ms251671.aspx

Report Viewer Samples:
http://msdn.microsoft.com/en-us/library/ms251686.aspx

Got Reportviewer?
http://www.gotreportviewer.com/
(Lots of good examples but for 2010)



