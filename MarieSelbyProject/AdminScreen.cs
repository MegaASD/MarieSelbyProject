﻿using System;
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
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mS_GARDENSDataSet.EXHIBIT' table. You can move, or remove it, as needed.
            //this.eXHIBITTableAdapter.Fill(this.mS_GARDENSDataSet.EXHIBIT);
            SqlConnection connection = new SqlConnection(Globals.connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM EXHIBIT", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 1;
            while (reader.Read())
            {
                switch (i)
                {
                    case 1:
                        exhibit1Label.Text = reader.GetString(1);
                        exhibit1Txt.Text = reader.GetString(2);
                        exhibit1Pic.Image = Image.FromFile(reader.GetString(3));
                        i++;
                        break;
                    case 2:
                        exhibit2Label.Text = reader.GetString(1);
                        exhibit2Txt.Text = reader.GetString(2);
                        exhibit2Pic.Image = Image.FromFile(reader.GetString(3));
                        i++;
                        break;
                    case 3:
                        exhibit3Label.Text = reader.GetString(1);
                        exhibit3Txt.Text = reader.GetString(2);
                        exhibit3Pic.Image = Image.FromFile(reader.GetString(3));
                        i++;
                        break;
                    case 4:
                        exhibit4Label.Text = reader.GetString(1);
                        exhibit4Txt.Text = reader.GetString(2);
                        exhibit4Pic.Image = Image.FromFile(reader.GetString(3));
                        i++;
                        break;
                    case 5:
                        exhibit5Label.Text = reader.GetString(1);
                        exhibit5Txt.Text = reader.GetString(2);
                        exhibit5Pic.Image = Image.FromFile(reader.GetString(3));
                        i++;
                        break;
                    default:
                        i++;
                        break;
                }
            }
        }
        private void showExhibitEdit(string idIn, string textIn)
        {

            Form exhibitEdit = new ExhibitEdit();
            exhibitEdit.Name = idIn;
            exhibitEdit.Text = textIn;
            exhibitEdit.Show();
        }
        private void exhibit1Pic_Click(object sender, EventArgs e)
        {
            showExhibitEdit("1", exhibit1Label.Text);
        }

        private void exhibit2Pic_Click(object sender, EventArgs e)
        {
            showExhibitEdit("2", exhibit2Label.Text);
        }

        private void exhibit3Pic_Click(object sender, EventArgs e)
        {
            showExhibitEdit("3", exhibit3Label.Text);
        }

        private void exhibit4Pic_Click(object sender, EventArgs e)
        {
            showExhibitEdit("4", exhibit4Label.Text);
        }

        private void exhibit5Pic_Click(object sender, EventArgs e)
        {
            showExhibitEdit("5", exhibit5Label.Text);
        }

        private void mainScreenMenu_File_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
