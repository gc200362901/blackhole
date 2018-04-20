using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
                using (SqlCommand cmd = new SqlCommand("SELECT ma.Name, mo.EngineSize, mo.NumberOfDoors, mo.Color, " +
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
                using (SqlCommand cmd = new SqlCommand("SELECT ma.Name, mo.EngineSize, mo.NumberOfDoors, mo.Color, " +
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
                using (SqlCommand cmd = new SqlCommand("SELECT ma.Name, mo.EngineSize, mo.NumberOfDoors, mo.Color, " +
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
    }
}
