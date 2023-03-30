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

namespace MarieSelbyProject
{
    public partial class ExhibitEdit : Form
    {
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

        }

        private void ExhibitEdit_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = newName.Text;
            string desc = newDesc.Text;
            string id = this.Name;
            using (SqlConnection connection = new SqlConnection(Globals.connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE EXHIBIT SET ExhibitName = @name, ExhibitDescription = @desc WHERE ExhibitID = @id", connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@desc", desc);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
