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
    public partial class AddVehicle : Form
    {
        Dictionary<int, string> vehicleTypesDic;
        Dictionary<int, string> makeTypesDic;
        Dictionary<int, string> modelTypesDic;

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
               
                PopulateMakeComboBox();              
                PopulateModelComboBox();
            }
        }

        private void PopulateModelComboBox()
        {
            
            modelTypesDic = new Dictionary<int, string>();

            modelTypesDic.Clear();

            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("Select ModelId, Name FROM Model", conn))
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        modelTypesDic.Add(reader.GetInt32(0), reader.GetString(1));
                    }
                }
            }
            modelComboBox.Items.Clear();
            foreach (KeyValuePair<int, string> kvp in modelTypesDic)
            {
                modelComboBox.Items.Add(kvp.Value);
            }
        }


        private void PopulateMakeComboBox()
        {
            

            makeTypesDic = new Dictionary<int, string>();

            makeTypesDic.Clear();

            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("Select MakeId, Name FROM Make", conn))
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        makeTypesDic.Add(reader.GetInt32(0), reader.GetString(1));
                    }
                }
            }
            makeComboBox.Items.Clear();
            foreach(KeyValuePair<int, string> kvp in makeTypesDic)
            {
                makeComboBox.Items.Add(kvp.Value);
            }
 
        }

        private void PopulateVehicleTypeComboBox()
        {
           

            vehicleTypesDic = new Dictionary<int, string>();

            vehicleTypesDic.Clear();

            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("Select VehicleTypeId, Name FROM VehicleType", conn))
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        vehicleTypesDic.Add(reader.GetInt32(0), reader.GetString(1));
                    }
                }
            }
            vehicleType.Items.Clear();
            foreach (KeyValuePair<int, string> kvp in vehicleTypesDic)
            {
                vehicleType.Items.Add(kvp.Value);
            }
        }

        private void modelSaveButton_Click_1(object sender, EventArgs e)
        {
            int typeId = vehicleTypesDic.FirstOrDefault(x => x.Value == vehicleType.Text).Key;

            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))

            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Model (Name, EngineSize, NumberOfDoors, Color, VehicleTypeId) " +
                                                       "VALUES ('" + modelNameText.Text + "'," +
                                                               "'" + engineTextBox.Text + "'," +
                                                               "'" + doorsTextBox.Text + "'," +
                                                               "'" + colorTextBox.Text + "'," +
                                                               "'" + typeId + "')", conn))

                {

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Model Saved");
        }

        private void makeSaveButton_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))

            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Make (Name) " +
                                                       "VALUES ('" + makeTextBox.Text + "')", conn))

                {

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Make Saved");
        }

        private void vehicleTypeSaveButton_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))

            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO VehicleType (Name) " +
                                                       "VALUES ('" + vehicleTypeText.Text + "')", conn))

                {

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Vehicle Type Saved");
        }

        private void vehicleSaveButton_Click(object sender, EventArgs e)
        {
            int makeId = makeTypesDic.FirstOrDefault(x => x.Value == makeComboBox.Text).Key;
            int modelId = modelTypesDic.FirstOrDefault(x => x.Value == modelComboBox.Text).Key;

            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))

            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Vehicle (MakeId, ModelId, Year, Price, SoldDate) " +
                                                       "VALUES ('" + makeId + "'," +
                                                               "'" + modelId + "'," +
                                                               "'" + yearTextBox.Text + "'," +
                                                               "'" + priceTextBox.Text + "'," +
                                                               "'" + soldDateTextBox.Text + "')", conn))

                {

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Model Saved");
        }

        private void importVehicleBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Title = "Choose a file to open";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);

                foreach (var line in lines)
                {
                    var data = line.Split(new[] { ',' }, 5);
                    int makeId = int.Parse(data[0].Trim());
                    int modelId = int.Parse(data[1].Trim());
                    int year = int.Parse(data[2].Trim());
                    int price = int.Parse(data[3].Trim());
                    string soldDate = (data[4].Trim());
                    ImportVehicleToDb(makeId, modelId, year, price, soldDate);

                }
            }
        }

        private void ImportVehicleToDb(int makeId, int modelId, int year, int price, string soldDate)
        {
            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Vehicle (MakeId, ModelId, Year, Price, SoldDate) " +
                                                       "VALUES ('" + makeId + "'," +
                                                               "'" + modelId + "'," +
                                                               "'" + year + "'," +
                                                               "'" + price + "'," +
                                                               "'" + soldDate + "')", conn))
                {
                    conn.Open();
                    
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Vehicle Saved");
        }

        private void importModelBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Title = "Choose a file to open";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);

                foreach (var line in lines)
                {
                    var data = line.Split(new[] { ',' }, 5);
                    string name = (data[0].Trim());
                    string engineSize = (data[1].Trim());
                    int doors = int.Parse(data[2].Trim());
                    string color = (data[3].Trim());
                    int vehicleTypeId = int.Parse(data[4].Trim());
                    ImportModelToDb(name, engineSize, doors, color, vehicleTypeId);
                }
            }
        }

        private void ImportModelToDb(string name, string engineSize, int doors, string color, int vehicleTypeId)
        {
            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Model (Name, EngineSize, NumberOfDoors, Color, VehicleTypeId) " +
                                                       "VALUES ('" + name + "'," +
                                                               "'" + engineSize + "'," +
                                                               "'" + doors + "'," +
                                                               "'" + color + "'," +
                                                               "'" + vehicleTypeId + "')", conn))
                {
                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Model Saved");
        }

        private void importVehicleTypeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Title = "Choose a file to open";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);

                foreach (var line in lines)
                {
                    string name = line;

                    ImportVehicleTypeToDb(name);
                }
            }
        }

        private void ImportVehicleTypeToDb(string name)
        {
            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO VehicleType (Name) " +
                                                       "VALUES ('" + name + "')", conn))
                {
                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Vehicle Type Saved");
        }

        private void importMakeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Title = "Choose a file to open";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);

                foreach (var line in lines)
                {
                    string name = line;

                    ImportMakeToDb(name);
                }
            }
        }

        private void ImportMakeToDb(string name)
        {
            string connString = ConfigurationManager.ConnectionStrings["carDirectory"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Make (Name) " +
                                                       "VALUES ('" + name + "')", conn))
                {
                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Make Saved");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
