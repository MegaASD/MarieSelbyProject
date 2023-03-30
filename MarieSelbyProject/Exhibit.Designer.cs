namespace MarieSelbyProject
{
    partial class Exhibit
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
            this.speciesSelect = new System.Windows.Forms.ComboBox();
            this.speciesSelectLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.speciesDescription = new System.Windows.Forms.TextBox();
            this.speciesName = new System.Windows.Forms.Label();
            this.speciesPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.speciesPic)).BeginInit();
            this.SuspendLayout();
            // 
            // speciesSelect
            // 
            this.speciesSelect.FormattingEnabled = true;
            this.speciesSelect.Location = new System.Drawing.Point(262, 37);
            this.speciesSelect.Name = "speciesSelect";
            this.speciesSelect.Size = new System.Drawing.Size(244, 21);
            this.speciesSelect.TabIndex = 1;
            this.speciesSelect.SelectionChangeCommitted += new System.EventHandler(this.speciesSelect_SelectionChangeCommitted);
            this.speciesSelect.SelectedValueChanged += new System.EventHandler(this.speciesSelect_SelectedValueChanged);
            // 
            // speciesSelectLabel
            // 
            this.speciesSelectLabel.AutoSize = true;
            this.speciesSelectLabel.Location = new System.Drawing.Point(512, 40);
            this.speciesSelectLabel.Name = "speciesSelectLabel";
            this.speciesSelectLabel.Size = new System.Drawing.Size(35, 13);
            this.speciesSelectLabel.TabIndex = 2;
            this.speciesSelectLabel.Text = "label1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // speciesDescription
            // 
            this.speciesDescription.Location = new System.Drawing.Point(347, 64);
            this.speciesDescription.Multiline = true;
            this.speciesDescription.Name = "speciesDescription";
            this.speciesDescription.Size = new System.Drawing.Size(441, 361);
            this.speciesDescription.TabIndex = 4;
            // 
            // speciesName
            // 
            this.speciesName.AutoSize = true;
            this.speciesName.Location = new System.Drawing.Point(107, 40);
            this.speciesName.Name = "speciesName";
            this.speciesName.Size = new System.Drawing.Size(58, 13);
            this.speciesName.TabIndex = 5;
            this.speciesName.Text = "LatinName";
            // 
            // speciesPic
            // 
            this.speciesPic.Location = new System.Drawing.Point(12, 64);
            this.speciesPic.Name = "speciesPic";
            this.speciesPic.Size = new System.Drawing.Size(329, 361);
            this.speciesPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.speciesPic.TabIndex = 0;
            this.speciesPic.TabStop = false;
            // 
            // Exhibit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.speciesName);
            this.Controls.Add(this.speciesDescription);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.speciesSelectLabel);
            this.Controls.Add(this.speciesSelect);
            this.Controls.Add(this.speciesPic);
            this.Name = "Exhibit";
            this.Text = "Exhibit";
            this.Load += new System.EventHandler(this.Exhibit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.speciesPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox speciesPic;
        private System.Windows.Forms.ComboBox speciesSelect;
        private System.Windows.Forms.Label speciesSelectLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox speciesDescription;
        private System.Windows.Forms.Label speciesName;
    }
}