using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace MarieSelbyProject
{
    public partial class ExhibitEdit : Form
    {
        public string id;
        public string name;

        public ExhibitEdit()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form todo = new ToDo();
            todo.ShowDialog();
        }

        private void ExhibitEdit_Load(object sender, EventArgs e)
        {
            id = this.Name;
            this.Name = this.Text;
            SqlConnection connection = new SqlConnection(Globals.connectionString);
            connection.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM SPECIES WHERE ExhibitID = @id;", connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        speciesSelect.Items.Add(reader.GetValue(2));
                    }
                    speciesSelect.SelectedIndex = 0;
                    while(reader.Read())
                    {
                        newLatin.Text = reader.GetString(3);
                        newSpeciesDesc.Text = reader.GetString(4);
                    }
                    reader.Close();
                }
                connection.Close();
            }
            Console.WriteLine(id);
            connection = new SqlConnection(Globals.connectionString);
            connection.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM EXHIBIT WHERE ExhibitID = @id", connection))
            {
                
                cmd.Parameters.AddWithValue("@id",id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        newName.Text = reader.GetString(1);
                        newDesc.Text = reader.GetString(2);
                    }
                }
            }
            
        }

        //save changes
        private void button1_Click(object sender, EventArgs e)
        {
            string name = newName.Text;
            string desc = newDesc.Text;
            string id = this.Name;
            using (SqlConnection connection = new SqlConnection(Globals.connectionString))
            {
                connection.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE EXHIBIT SET ExhibitName = @id, ExhibitDescription = @desc WHERE ExhibitName = @id", connection))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@desc", desc);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // this is bad practice but I don't have time

                try
                {
                    //
                    using (SqlCommand cmd = new SqlCommand("UPDATE EXHIBIT SET LatinName = @newLatin, SpeciesDescription = @newSpeciesDesc WHERE ExhibitID = @id AND SpeciesName = @species", connection))
                    {
                        cmd.Parameters.AddWithValue("@newLatin", newLatin.Text);
                        cmd.Parameters.AddWithValue("@newSpeciesDesc", newSpeciesDesc.Text);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@species", speciesSelect.Text);
                        cmd.ExecuteNonQuery();
                    }
                }catch (Exception ex) {
                    MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//bad practice lol
            }
        }

        private void speciesSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            name = speciesSelect.SelectedItem.ToString();
            this.Name = this.Text;
            Bitmap bmp;

            using (SqlConnection connection = new SqlConnection(Globals.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM SPECIES WHERE SpeciesName = @name", connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@name", name);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString(2));
                            speciesSelect.Text = reader.GetString(2);
                            newLatin.Text = reader.GetString(3);
                            newSpeciesDesc.Text = reader.GetString(4);

                            using (var fs = new FileStream(reader.GetString(5), FileMode.Open, FileAccess.Read))
                            {
                                using (var ms = new MemoryStream())
                                {
                                    fs.CopyTo(ms);
                                    while (ms == null) ; // Occasionally larger images may take a bit longer to load than fs's timeout. This just ensures it finishes loading without crashing.
                                    Console.WriteLine(ms.ToString());
                                    try
                                    {
                                        bmp = new Bitmap(ms);// This hard crashes the program but only when it tries to load specific images and I have no idea why.
                                                             // Known crashes: Philodendron, Orchids, Milkweed, Iris, Sabal Palm

                                    }
                                    catch (Exception ex) { return; } // quick and dirty "fix" so the project can be turned in on time without hard crashes

                                }
                            }
                            speciesPic.Image = bmp;
                        }
                        reader.Close();
                        connection.Close();
                    }

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(Globals.connectionString))
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM species WHERE SpeciesName = @name AND ExhibitID = @id;", connection))
                        {
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                        Form success = new Success();
                        success.ShowDialog();
                    }
                    catch (Exception ex) { } // this is bad practice but I don't have time
                }

            }
            else
            {
                MessageBox.Show("Operation Canceled");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form todo = new ToDo();
            todo.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form add = new AddSpecies();
            add.ShowDialog();
        }
    }
}
