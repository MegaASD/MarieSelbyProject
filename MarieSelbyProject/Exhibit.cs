using MarieSelbyProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MarieSelbyProject
{
    public partial class Exhibit : Form
    {
        public Exhibit()
        {
            InitializeComponent();
        }

        private void Exhibit_Load(object sender, EventArgs e)
        {
            string name = this.Name;
            this.Name = this.Text;
            SqlConnection connection = new SqlConnection(Globals.connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SPECIES WHERE ExhibitID = '" + name + "';", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                speciesSelect.Items.Add(reader.GetValue(2));
            }
           speciesSelect.SelectedIndex = 0;

            while (reader.Read())
            {
                //  speciesSelect.Text = reader.GetString(2);
                speciesName.Text = reader.GetString(3);
                speciesDescription.Text = reader.GetString(4);
                speciesPic.Image = Image.FromFile(reader.GetString(5));
            }
            reader.Close();
            
           // cmd = new SqlCommand("SELECT TOP 1 * FROM SPECIES", connection);
           // reader = cmd.ExecuteReader();
            
           

            reader.Close();
            connection.Close();
        }

        private void speciesSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            
           
        }

        private void speciesSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            string name = speciesSelect.SelectedItem.ToString();
            this.Name = this.Text;
            Bitmap bmp;
            

            SqlConnection connection = new SqlConnection(Globals.connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SPECIES WHERE SpeciesName = '" + name + "';", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(2));
                speciesSelect.Text = reader.GetString(2);
                speciesName.Text = reader.GetString(3);
                speciesDescription.Text = reader.GetString(4);
                
                using (var fs = new FileStream(reader.GetString(5), FileMode.Open, FileAccess.Read))
                {
                    using (var ms = new MemoryStream())
                    {
                        fs.CopyTo(ms);
                        while (ms == null); // Occasionally larger images may take a bit longer to load than fs's timeout. This just ensures it finishes loading without crashing.
                        Console.WriteLine(ms.ToString());
                        try
                        {
                            bmp = new Bitmap(ms); // This hard crashes the program but only when it tries to load specific images and I have no idea why.
                            // Known crashes: Philodendron, Orchids, Milkweed, Iris, Sabal Palm
                        }
                        catch (Exception ex) { return; }    // quick and dirty "fix" so the project can be turned in on time without hard crashes
                    }
                }
                speciesPic.Image = bmp;
            }
            reader.Close();
            connection.Close();
        }
    }
    
}