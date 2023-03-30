using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarieSelbyProject
{
    public partial class AddSpecies : Form
    {
        public AddSpecies()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO SPECIES (column1, column2) OUTPUT INSERTED.ID VALUES (@column1, @column2)";
            using (SqlConnection connection = new SqlConnection(Globals.connectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO SPECIES (exhibitID, SpeciesName, LatinName, SpeciesDescription, SpeciesImage) VALUES (@exhibitID, @speciesName, @latinName, @speciesDescription, @speciesImage)", connection))
                    {
                        

                        connection.Open();
                        cmd.Parameters.AddWithValue("@speciesName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@latinName", textBox2.Text);
                        cmd.Parameters.AddWithValue("@speciesDescription", textBox3.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
                
        }
    }
}
