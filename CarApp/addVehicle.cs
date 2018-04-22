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
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        private void tablesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tableSelected = tablesComboBox.Text;

            if(tableSelected.Equals("Make"))
            {
                addVehicleMainPanel.Visible = false;
                makePanel.Visible = true;
                modelPanel.Visible = false;
                vehicleTypePanel.Visible = false;
                vehiclePanel.Visible = false;
            }
            else if(tableSelected.Equals("Model"))
            {
                addVehicleMainPanel.Visible = false;
                makePanel.Visible = false;
                modelPanel.Visible = true;
                vehicleTypePanel.Visible = false;
                vehiclePanel.Visible = false;

                PopulateVehicleTypeComboBox();
            }
            else if(tableSelected.Equals("Vehicle Type"))
            {
                addVehicleMainPanel.Visible = false;
                makePanel.Visible = false;
                modelPanel.Visible = false;
                vehicleTypePanel.Visible = true;
                vehiclePanel.Visible = false;
            }
            else
            {
                addVehicleMainPanel.Visible = false;
                makePanel.Visible = false;
                modelPanel.Visible = false;
                vehicleTypePanel.Visible = false;
                vehiclePanel.Visible = true;
            }
        }

        private void PopulateVehicleTypeComboBox()
        {
            List<String> vehicleTypeNames = new List<String>();

            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("Select Name FROM VehicleType", conn))
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        vehicleTypeNames.Add(reader.GetString(0));
                    }
                }
            }
            foreach(String type in vehicleTypeNames)
            {
                vehicleType.Items.Add(type);
            }
        }

        private void SaveModelButton_Click(object sender, EventArgs e)
        {
            SaveModel();

            MessageBox.Show("Model Saved");
        }

        private void SaveModel()
        {
            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))

            {
                using (SqlCommand cmd = new SqlCommand("INSERT model (EngineSize, NumberOfDoors, Color, VehicleTypeId ) " +

                                                       "VALUES ('" + engineTextBox.Text + "'," +

                                                       "'" + doorsTextBox.Text + "'," +

                                                       "'" + colorTextBox.Text + "'," +

                                                       "'" + vehicleType.SelectedItem.ToString() + "')" +
                                                       conn))

                {

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }

            }

        }


    }
}
