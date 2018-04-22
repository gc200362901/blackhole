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
            string make, model, vehicleType, vehicle;

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

        private void comboBox_Load()
        {
            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;



            using (SqlConnection conn = new SqlConnection(connString))

            {

                string query = "SELECT * FROM  VehicleTypeId";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();

                DataSet ds = new DataSet();
                da.Fill(ds, "VehicleTypeId");
                vehicleType.DisplayMember = "Name";
                vehicleType.ValueMember = "VehicleTypeId";
                vehicleType.DataSource = ds.Tables["VehicleTypeId"];
            }
        }

        private void saveModelButton_Click(object sender, EventArgs e)

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
