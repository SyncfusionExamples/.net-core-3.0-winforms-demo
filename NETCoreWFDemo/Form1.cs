using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid;


namespace NETCoreWFDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SfDataGrid sfDataGrid1 = new SfDataGrid();
            sfDataGrid1.Location = new System.Drawing.Point(5, 5);
            sfDataGrid1.Size = new System.Drawing.Size(1240, 1150);
            sfDataGrid1.DataSource = GetDataTable();
            this.Controls.Add(sfDataGrid1);
        }

        public DataTable GetDataTable()
        {
            DataTable employeeCollection = new DataTable();
            var dt = DateTime.Now;

            employeeCollection.Columns.Add("EmployeeID", typeof(int));
            employeeCollection.Columns[0].ColumnName = "Employee ID";
            employeeCollection.Columns.Add("EmployeeName", typeof(string));
            employeeCollection.Columns["EmployeeName"].ColumnName = "Employee Name";
            employeeCollection.Columns.Add("CustomerID", typeof(string));
            employeeCollection.Columns["CustomerID"].ColumnName = "Customer ID";
            employeeCollection.Columns.Add("Country", typeof(string));
            employeeCollection.Columns.Add("Date", typeof(DateTime));

            employeeCollection.Rows.Add(1001, "Belgim", "YHGTR", "US", new DateTime(dt.Year, dt.Month, dt.Day));
            employeeCollection.Rows.Add(1002, "Oliver", "LDON", "UK", new DateTime(dt.Year, dt.Month, dt.AddDays(-1).Day));
            employeeCollection.Rows.Add(1003, "Bernald", "ALFKI", "US", new DateTime(dt.Year, dt.Month, dt.AddDays(-5).Day));
            employeeCollection.Rows.Add(1004, "James", "YHGTR", "US", new DateTime(dt.Year, dt.Month, dt.AddDays(-1).Day));
            employeeCollection.Rows.Add(1005, "Beverton", "BERGS", "Europe", new DateTime(dt.Year, dt.Month, dt.Day));

            return employeeCollection;
        }
    }
}
