using Microsoft.Reporting.WinForms;
using ReportsApplication4.DatabaseSTableAdapters;
using ReportsApplication4.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportsApplication4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

       




        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.dataTable2BindingSource.DataSource = this.dataSet12;
            this.dataTable3BindingSource.DataSource = this.dataSet12;
            this.dataTable1BindingSource.DataSource = this.dataSet12;
            this.dataTable4BindingSource.DataSource = this.dataSet12;
            this.dataTable2TableAdapter.FillChart(this.dataSet12.DataTable2);
            this.dataTable3TableAdapter.FillChart2(this.dataSet12.DataTable3);
            this.dataTable1TableAdapter.FillSort(this.dataSet12.DataTable1);
            this.dataTable4TableAdapter.FillSort2(this.dataSet12.DataTable4);
         

        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            UserControl1 uc = new UserControl1();
            uc.Dock = DockStyle.Bottom;
            this.Controls.Add(uc);
            uc.BringToFront();
             
           
            this.label9.Text = uc.comboBox1.Text;
           
        }


        /*                                            FIRST REPORT                                                                                     */

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            this.Current.DataMember = "Provider";           
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication4.Report1.rdlc";           
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.reportViewer1.LocalReport.ReportEmbeddedResource.Equals("ReportsApplication4.Report2.rdlc"))
            {
                this.Current.DataMember = "Procedures and Payments";
                this.procedures_and_PaymentsTableAdapter1.FillBy(this.dataSet1.Procedures_and_Payments, comboBox2.Text, comboBox3.Text, dateTimePicker1.Value, dateTimePicker2.Value, comboBox1.Text, comboBox4.Text);
                this.reportViewer1.RefreshReport();

            };
            if (this.reportViewer1.LocalReport.ReportEmbeddedResource.Equals("ReportsApplication4.Report1.rdlc"))
            {
                if (checkBox1.Checked)
                {
                    this.providerTableAdapter.Fill(this.dataSet1.Provider);
                }
                else
                { 
                    this.Current.DataMember = "Provider";
                    this.providerTableAdapter.FillBy(this.dataSet1.Provider, comboBox1.Text, comboBox4.Text);
                    this.reportViewer1.RefreshReport();
                }
            };
            
           

        }
    
        

        /*                                            SECOND REPORT                                                                                     */
        private void button3_Click(object sender, EventArgs e)
        {
                     
            this.Current.DataMember = "Procedures and Payments";
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication4.Report2.rdlc";
            this.reportViewer1.RefreshReport();
          
        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
               
               
                this.procedures_and_PaymentsTableAdapter1.FillBy(this.dataSet1.Procedures_and_Payments, comboBox2.Text, comboBox3.Text, dateTimePicker1.Value, dateTimePicker2.Value,comboBox1.Text,comboBox4.Text);
                this.reportViewer1.RefreshReport();
             
               
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (this.reportViewer1.LocalReport.ReportEmbeddedResource.Equals( "ReportsApplication4.Report2.rdlc"))
                {
                    this.Current.DataMember = "Procedures and Payments";
                    this.procedures_and_PaymentsTableAdapter1.Fill(this.dataSet1.Procedures_and_Payments);
                    this.reportViewer1.RefreshReport();

                };
                if (this.reportViewer1.LocalReport.ReportEmbeddedResource.Equals("ReportsApplication4.Report1.rdlc"))
                {
                    this.Current.DataMember = "Provider";
                    this.providerTableAdapter.Fill(this.dataSet1.Provider);
                    this.reportViewer1.RefreshReport();

                };
                
            }
            else
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
    }
