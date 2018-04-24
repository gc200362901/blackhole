using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void allCarsButton_Click(object sender, EventArgs e)
        {
            allCarsPanel.Visible = true;
            homePanel.Visible = false;
            availablePanel.Visible = false;
            soldPanel.Visible = false;
            financialPanel.Visible = false;

            allCarsDataGridView.DataSource = GetCars();
        }

        private DataTable GetCars()
        {
            DataTable dtCars = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ma.Name, mo.Name AS 'Model', mo.EngineSize, mo.NumberOfDoors, mo.Color, " +
                    "                                       v.year, v.price FROM Vehicle v JOIN Make ma ON ma.MakeId = v.MakeId" +
                    "                                   JOIN Model mo ON mo.ModelId = v.ModelId", conn))
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtCars.Load(reader);
                }
            }

            return dtCars;
        }

        private void availableButton_Click(object sender, EventArgs e)
        {
            allCarsPanel.Visible = false;
            homePanel.Visible = false;
            availablePanel.Visible = true;
            soldPanel.Visible = false;
            financialPanel.Visible = false;

            availableCarsDataGridView.DataSource = GetCarsAvailable();
        }

        private DataTable GetCarsAvailable()
        {
            DataTable dtCars = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ma.Name, mo.Name AS 'Model', mo.EngineSize, mo.NumberOfDoors, mo.Color, " +
                                                          "v.year, v.price FROM Vehicle v JOIN Make ma ON ma.MakeId = v.MakeId " +
                                                       "JOIN Model mo ON mo.ModelId = v.ModelId " +
                                                       "WHERE v.SoldDate IS NULL", conn))
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtCars.Load(reader);
                }
            }

            return dtCars;
        }

        private DataTable GetCarsSold()
        {
            DataTable dtCars = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ma.Name, mo.Name AS 'Model', mo.EngineSize, mo.NumberOfDoors, mo.Color, " +
                                                          "v.year, v.price FROM Vehicle v JOIN Make ma ON ma.MakeId = v.MakeId " +
                                                       "JOIN Model mo ON mo.ModelId = v.ModelId " +
                                                       "WHERE v.SoldDate IS NOT NULL", conn))
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtCars.Load(reader);
                }
            }

            return dtCars;
        }

        private void soldButton_Click(object sender, EventArgs e)
        {
            allCarsPanel.Visible = false;
            homePanel.Visible = false;
            availablePanel.Visible = false;
            soldPanel.Visible = true;
            financialPanel.Visible = false;

            soldDataGridView.DataSource = GetCarsSold();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            allCarsPanel.Visible = false;
            homePanel.Visible = true;
            availablePanel.Visible = false;
            soldPanel.Visible = false;
            financialPanel.Visible = false;
        }

        private DataTable GetCarsFinancial()
        {
            DataTable dtCars = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) -COUNT(SoldDate) AS 'Sold Vehicles', " +
                                                       "COUNT(SoldDate) AS 'Vehicles for Sale', " +
                                                       "SUM(case when SoldDate  IS NOT NULL then price else 0 end) AS 'Income Gained' " +
                                                       "FROM vehicle", conn))
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtCars.Load(reader);
                }
            }

            return dtCars;
        }

        private void financialButton_Click(object sender, EventArgs e)
        {
            allCarsPanel.Visible = false;
            homePanel.Visible = false;
            availablePanel.Visible = false;
            soldPanel.Visible = false;
            financialPanel.Visible = true;

            financialDataGridView.DataSource = GetCarsFinancial();
        }

        private void addToDbButton_Click(object sender, EventArgs e)
        {
            AddVehicle av = new AddVehicle();
            av.ShowDialog();
        }

        private void AllCarsExportBtn_Click(object sender, EventArgs e)
        {
            TextWriter ac = new StreamWriter(@"..\..\..\AllCars.txt");

            int rowcount = allCarsDataGridView.Rows.Count;
            for (int i = 0; i < rowcount - 1; i++)

            {                   // 7 Columns in the All Cars View

                //allCarsDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                ac.WriteLine(allCarsDataGridView.Rows[i].Cells[0].Value.ToString() + "\t" + "|"

                    + "\t" + allCarsDataGridView.Rows[i].Cells[1].Value.ToString() + "\t" + "|"

                    + "\t" + allCarsDataGridView.Rows[i].Cells[2].Value.ToString() + "\t" + "|"

                    + "\t" + allCarsDataGridView.Rows[i].Cells[3].Value.ToString() + "\t" + "|"

                    + "\t" + allCarsDataGridView.Rows[i].Cells[4].Value.ToString() + "\t" + "|"

                    + "\t" + allCarsDataGridView.Rows[i].Cells[5].Value.ToString() + "\t" + "|"

                    + "\t" + allCarsDataGridView.Rows[i].Cells[6].Value.ToString() + "\t" + "|");
            }

            ac.Close();

            MessageBox.Show("Data Exported to: CarApp\\AllCars.txt", "Export All Cars to Text");

        }
    
        private void AvailableExportBtn_Click(object sender, EventArgs e)
        {
            TextWriter avc = new StreamWriter(@"..\..\..\AvailableCars.txt");

            int rowcount = availableCarsDataGridView.Rows.Count;

            for (int i = 0; i < rowcount - 1; i++)

            {                   // 7 Columns in the All Cars View

                avc.WriteLine("|" + "\t" + availableCarsDataGridView.Rows[i].Cells[0].Value.ToString() + "\t" + "|"

                    + "\t" + availableCarsDataGridView.Rows[i].Cells[1].Value.ToString() + "\t" + "|"

                    + "\t" + availableCarsDataGridView.Rows[i].Cells[2].Value.ToString() + "\t" + "|"

                    + "\t" + availableCarsDataGridView.Rows[i].Cells[3].Value.ToString() + "\t" + "|"

                    + "\t" + availableCarsDataGridView.Rows[i].Cells[4].Value.ToString() + "\t" + "|"

                    + "\t" + availableCarsDataGridView.Rows[i].Cells[5].Value.ToString() + "\t" + "|"

                    + "\t" + availableCarsDataGridView.Rows[i].Cells[6].Value.ToString() + "\t" + "|");

            }

            avc.Close();

            MessageBox.Show("Data Exported to: CarApp\\AvailableCars.txt", "Export Available Cars to Text");
        }
       

        private void SoldExportBtn_Click(object sender, EventArgs e)
        {
            TextWriter sc = new StreamWriter(@"..\..\..\SoldCars.txt");

            int rowcount = soldDataGridView.Rows.Count;

            for (int i = 0; i < rowcount - 1; i++)

            {                   // 7 Columns in the All Cars View

                sc.WriteLine("|" + "\t" + soldDataGridView.Rows[i].Cells[0].Value.ToString() + "\t" + "|"

                    + "\t" + soldDataGridView.Rows[i].Cells[1].Value.ToString() + "\t" + "|"

                    + "\t" + soldDataGridView.Rows[i].Cells[2].Value.ToString() + "\t" + "|"

                    + "\t" + soldDataGridView.Rows[i].Cells[3].Value.ToString() + "\t" + "|"

                    + "\t" + soldDataGridView.Rows[i].Cells[4].Value.ToString() + "\t" + "|"

                    + "\t" + soldDataGridView.Rows[i].Cells[5].Value.ToString() + "\t" + "|"

                    + "\t" + soldDataGridView.Rows[i].Cells[6].Value.ToString() + "\t" + "|");

            }

            sc.Close();

            MessageBox.Show("Data Exported to: CarApp\\SoldCars.txt", "Export Sold Cars to Text");
        }
        private void FinancialExportBtn_Click(object sender, EventArgs e)
        {
            TextWriter fr = new StreamWriter(@"..\..\..\FinancialReport.txt");

            int rowcount = financialDataGridView.Rows.Count;

            for (int i = 0; i < rowcount - 1; i++)

            {                   // 3 Columns in the All Cars View

                fr.WriteLine("|" + "\t" + financialDataGridView.Rows[i].Cells[0].Value.ToString() + "\t" + "|"

                    + "\t" + financialDataGridView.Rows[i].Cells[1].Value.ToString() + "\t" + "|"

                    + "\t" + financialDataGridView.Rows[i].Cells[2].Value.ToString() + "\t" + "|");

            }

            fr.Close();

            MessageBox.Show("Data Exported to: CarApp\\Financial.txt", "Export Financial Report to Text");
        }
    }
}
