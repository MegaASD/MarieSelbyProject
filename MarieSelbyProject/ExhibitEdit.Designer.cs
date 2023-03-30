namespace MarieSelbyProject
{
    partial class ExhibitEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.newName = new System.Windows.Forms.TextBox();
            this.newDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateRecord = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.updateImage2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.speciesSelect = new System.Windows.Forms.ComboBox();
            this.newSpeciesDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.speciesNameLabel = new System.Windows.Forms.Label();
            this.newLatin = new System.Windows.Forms.TextBox();
            this.speciesPic = new System.Windows.Forms.PictureBox();
            this.updateImage1 = new System.Windows.Forms.Button();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speciesPic)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 303);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(880, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabel1.Text = "Edit Exhibits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exhibit Name";
            // 
            // newName
            // 
            this.newName.Location = new System.Drawing.Point(129, 71);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(179, 20);
            this.newName.TabIndex = 2;
            // 
            // newDesc
            // 
            this.newDesc.Location = new System.Drawing.Point(129, 97);
            this.newDesc.Multiline = true;
            this.newDesc.Name = "newDesc";
            this.newDesc.Size = new System.Drawing.Size(179, 118);
            this.newDesc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Exhibit Description";
            // 
            // updateRecord
            // 
            this.updateRecord.Location = new System.Drawing.Point(331, 163);
            this.updateRecord.Name = "updateRecord";
            this.updateRecord.Size = new System.Drawing.Size(98, 52);
            this.updateRecord.TabIndex = 5;
            this.updateRecord.Text = "Update";
            this.updateRecord.UseVisualStyleBackColor = true;
            this.updateRecord.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // updateImage2
            // 
            this.updateImage2.Location = new System.Drawing.Point(704, 221);
            this.updateImage2.Name = "updateImage2";
            this.updateImage2.Size = new System.Drawing.Size(108, 51);
            this.updateImage2.TabIndex = 6;
            this.updateImage2.Text = "Update Species Image";
            this.updateImage2.UseVisualStyleBackColor = true;
            this.updateImage2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Species";
            // 
            // speciesSelect
            // 
            this.speciesSelect.FormattingEnabled = true;
            this.speciesSelect.Location = new System.Drawing.Point(435, 44);
            this.speciesSelect.Name = "speciesSelect";
            this.speciesSelect.Size = new System.Drawing.Size(121, 21);
            this.speciesSelect.TabIndex = 8;
            this.speciesSelect.SelectedValueChanged += new System.EventHandler(this.speciesSelect_SelectedValueChanged);
            // 
            // newSpeciesDesc
            // 
            this.newSpeciesDesc.Location = new System.Drawing.Point(435, 97);
            this.newSpeciesDesc.Multiline = true;
            this.newSpeciesDesc.Name = "newSpeciesDesc";
            this.newSpeciesDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.newSpeciesDesc.Size = new System.Drawing.Size(179, 118);
            this.newSpeciesDesc.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Species Description";
            // 
            // speciesNameLabel
            // 
            this.speciesNameLabel.AutoSize = true;
            this.speciesNameLabel.Location = new System.Drawing.Point(353, 74);
            this.speciesNameLabel.Name = "speciesNameLabel";
            this.speciesNameLabel.Size = new System.Drawing.Size(76, 13);
            this.speciesNameLabel.TabIndex = 11;
            this.speciesNameLabel.Text = "Species Name";
            // 
            // newLatin
            // 
            this.newLatin.Location = new System.Drawing.Point(435, 71);
            this.newLatin.Name = "newLatin";
            this.newLatin.Size = new System.Drawing.Size(121, 20);
            this.newLatin.TabIndex = 12;
            // 
            // speciesPic
            // 
            this.speciesPic.Location = new System.Drawing.Point(631, 34);
            this.speciesPic.Name = "speciesPic";
            this.speciesPic.Size = new System.Drawing.Size(240, 181);
            this.speciesPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.speciesPic.TabIndex = 13;
            this.speciesPic.TabStop = false;
            // 
            // updateImage1
            // 
            this.updateImage1.Location = new System.Drawing.Point(15, 164);
            this.updateImage1.Name = "updateImage1";
            this.updateImage1.Size = new System.Drawing.Size(108, 51);
            this.updateImage1.TabIndex = 14;
            this.updateImage1.Text = "Update Exhibit Image";
            this.updateImage1.UseVisualStyleBackColor = true;
            this.updateImage1.Click += new System.EventHandler(this.button3_Click);
            // 
            // deleteRecord
            // 
            this.deleteRecord.Location = new System.Drawing.Point(331, 248);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(98, 52);
            this.deleteRecord.TabIndex = 15;
            this.deleteRecord.Text = "Delete Record";
            this.deleteRecord.UseVisualStyleBackColor = true;
            this.deleteRecord.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Warning: Cannot Be Undone";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 52);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ExhibitEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteRecord);
            this.Controls.Add(this.updateImage1);
            this.Controls.Add(this.speciesPic);
            this.Controls.Add(this.newLatin);
            this.Controls.Add(this.speciesNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newSpeciesDesc);
            this.Controls.Add(this.speciesSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateImage2);
            this.Controls.Add(this.updateRecord);
            this.Controls.Add(this.newDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ExhibitEdit";
            this.Text = "ExhibitEdit";
            this.Load += new System.EventHandler(this.ExhibitEdit_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speciesPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.TextBox newDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateRecord;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button updateImage2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox speciesSelect;
        private System.Windows.Forms.TextBox newSpeciesDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label speciesNameLabel;
        private System.Windows.Forms.TextBox newLatin;
        private System.Windows.Forms.PictureBox speciesPic;
        private System.Windows.Forms.Button updateImage1;
        private System.Windows.Forms.Button deleteRecord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}