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
        Dictionary<int, string> vehicleTypesDic;

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
            vehicleTypesDic = new Dictionary<int, string>();
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
            int idCounter = 1;
            foreach(String type in vehicleTypeNames)
            {
                vehicleType.Items.Add(type);
                vehicleTypesDic.Add(idCounter, type);
                idCounter++;
            }
        }

        private void modelSaveButton_Click_1(object sender, EventArgs e)
        {
            int typeId = vehicleTypesDic.FirstOrDefault(x => x.Value == vehicleType.Text).Key;

            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))

            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Model (EngineSize, NumberOfDoors, Color, VehicleTypeId) " +
                                                       "VALUES ('" + engineTextBox.Text + "'," +
                                                               "'" + doorsTextBox.Text + "'," +
                                                               "'" + colorTextBox.Text + "'," +
                                                               "'" + typeId + "')", conn))

                {

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}
