using Microsoft.ReportingServices.Diagnostics.Internal;
using ReportsApplication4.DatabaseSTableAdapters;
using ReportsApplication4.Properties;
using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ReportsApplication4
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                label1.Text = ofd.SelectedPath;
                Settings.Default.ConnectionString1 = "Provider=Advantage.OLEDB.1;Data Source="+ ofd.SelectedPath;
                
                

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.mWDBListTableAdapter.Fill(this.databaseS.MWDBList);
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
