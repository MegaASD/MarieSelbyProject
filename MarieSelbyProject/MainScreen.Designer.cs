namespace MarieSelbyProject
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.mS_GARDENSDataSet = new MarieSelbyProject.MS_GARDENSDataSet();
            this.eXHIBITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXHIBITTableAdapter = new MarieSelbyProject.MS_GARDENSDataSetTableAdapters.EXHIBITTableAdapter();
            this.tableAdapterManager = new MarieSelbyProject.MS_GARDENSDataSetTableAdapters.TableAdapterManager();
            this.exhibit4Pic = new System.Windows.Forms.PictureBox();
            this.exhibit4Label = new System.Windows.Forms.Label();
            this.exhibit1Label = new System.Windows.Forms.Label();
            this.exhibit1Pic = new System.Windows.Forms.PictureBox();
            this.exhibit1Txt = new System.Windows.Forms.TextBox();
            this.eXHIBITBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.exhibit4Txt = new System.Windows.Forms.TextBox();
            this.exhibit3Txt = new System.Windows.Forms.TextBox();
            this.exhibit3Label = new System.Windows.Forms.Label();
            this.exhibit3Pic = new System.Windows.Forms.PictureBox();
            this.exhibit5Txt = new System.Windows.Forms.TextBox();
            this.exhibit2Txt = new System.Windows.Forms.TextBox();
            this.exhibit2Label = new System.Windows.Forms.Label();
            this.exhibit2Pic = new System.Windows.Forms.PictureBox();
            this.exhibit5Label = new System.Windows.Forms.Label();
            this.exhibit5Pic = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.selectExhibitLabel = new System.Windows.Forms.Label();
            this.mainScreenMenu = new System.Windows.Forms.MenuStrip();
            this.mainScreenMenu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mainScreenMenu_File_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.mainScreenMenu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainScreenMenu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.mainScreenMenu_Help_Contents = new System.Windows.Forms.ToolStripMenuItem();
            this.mainScreenMenu_Help_Index = new System.Windows.Forms.ToolStripMenuItem();
            this.mainScreenMenu_Help_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mainScreenMenu_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.mS_GARDENSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXHIBITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibit4Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibit1Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXHIBITBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibit3Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibit2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibit5Pic)).BeginInit();
            this.mainScreenMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mS_GARDENSDataSet
            // 
            this.mS_GARDENSDataSet.DataSetName = "MS_GARDENSDataSet";
            this.mS_GARDENSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eXHIBITBindingSource
            // 
            this.eXHIBITBindingSource.DataMember = "EXHIBIT";
            this.eXHIBITBindingSource.DataSource = this.mS_GARDENSDataSet;
            // 
            // eXHIBITTableAdapter
            // 
            this.eXHIBITTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EXHIBITTableAdapter = this.eXHIBITTableAdapter;
            this.tableAdapterManager.SPECIESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MarieSelbyProject.MS_GARDENSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // exhibit4Pic
            // 
            this.exhibit4Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exhibit4Pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exhibit4Pic.Image = global::MarieSelbyProject.Properties.Resources._1;
            this.exhibit4Pic.Location = new System.Drawing.Point(12, 381);
            this.exhibit4Pic.Name = "exhibit4Pic";
            this.exhibit4Pic.Size = new System.Drawing.Size(199, 132);
            this.exhibit4Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exhibit4Pic.TabIndex = 1;
            this.exhibit4Pic.TabStop = false;
            this.exhibit4Pic.Click += new System.EventHandler(this.exhibit4Pic_Click);
            // 
            // exhibit4Label
            // 
            this.exhibit4Label.AutoSize = true;
            this.exhibit4Label.Location = new System.Drawing.Point(93, 365);
            this.exhibit4Label.Name = "exhibit4Label";
            this.exhibit4Label.Size = new System.Drawing.Size(35, 13);
            this.exhibit4Label.TabIndex = 3;
            this.exhibit4Label.Text = "label2";
            // 
            // exhibit1Label
            // 
            this.exhibit1Label.AutoSize = true;
            this.exhibit1Label.Location = new System.Drawing.Point(93, 175);
            this.exhibit1Label.Name = "exhibit1Label";
            this.exhibit1Label.Size = new System.Drawing.Size(35, 13);
            this.exhibit1Label.TabIndex = 5;
            this.exhibit1Label.Text = "label1";
            // 
            // exhibit1Pic
            // 
            this.exhibit1Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exhibit1Pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exhibit1Pic.Image = global::MarieSelbyProject.Properties.Resources._1;
            this.exhibit1Pic.Location = new System.Drawing.Point(12, 191);
            this.exhibit1Pic.Name = "exhibit1Pic";
            this.exhibit1Pic.Size = new System.Drawing.Size(199, 132);
            this.exhibit1Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exhibit1Pic.TabIndex = 4;
            this.exhibit1Pic.TabStop = false;
            this.exhibit1Pic.Click += new System.EventHandler(this.exhibit1Pic_Click);
            // 
            // exhibit1Txt
            // 
            this.exhibit1Txt.CausesValidation = false;
            this.exhibit1Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eXHIBITBindingSource1, "ExhibitDescription", true));
            this.exhibit1Txt.HideSelection = false;
            this.exhibit1Txt.Location = new System.Drawing.Point(218, 191);
            this.exhibit1Txt.Multiline = true;
            this.exhibit1Txt.Name = "exhibit1Txt";
            this.exhibit1Txt.ReadOnly = true;
            this.exhibit1Txt.Size = new System.Drawing.Size(167, 132);
            this.exhibit1Txt.TabIndex = 6;
            // 
            // eXHIBITBindingSource1
            // 
            this.eXHIBITBindingSource1.DataMember = "EXHIBIT";
            this.eXHIBITBindingSource1.DataSource = this.mS_GARDENSDataSet;
            // 
            // exhibit4Txt
            // 
            this.exhibit4Txt.CausesValidation = false;
            this.exhibit4Txt.HideSelection = false;
            this.exhibit4Txt.Location = new System.Drawing.Point(218, 381);
            this.exhibit4Txt.Multiline = true;
            this.exhibit4Txt.Name = "exhibit4Txt";
            this.exhibit4Txt.ReadOnly = true;
            this.exhibit4Txt.Size = new System.Drawing.Size(167, 132);
            this.exhibit4Txt.TabIndex = 7;
            // 
            // exhibit3Txt
            // 
            this.exhibit3Txt.CausesValidation = false;
            this.exhibit3Txt.HideSelection = false;
            this.exhibit3Txt.Location = new System.Drawing.Point(1016, 191);
            this.exhibit3Txt.Multiline = true;
            this.exhibit3Txt.Name = "exhibit3Txt";
            this.exhibit3Txt.ReadOnly = true;
            this.exhibit3Txt.Size = new System.Drawing.Size(167, 132);
            this.exhibit3Txt.TabIndex = 18;
            // 
            // exhibit3Label
            // 
            this.exhibit3Label.AutoSize = true;
            this.exhibit3Label.Location = new System.Drawing.Point(891, 175);
            this.exhibit3Label.Name = "exhibit3Label";
            this.exhibit3Label.Size = new System.Drawing.Size(35, 13);
            this.exhibit3Label.TabIndex = 17;
            this.exhibit3Label.Text = "label5";
            // 
            // exhibit3Pic
            // 
            this.exhibit3Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exhibit3Pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exhibit3Pic.Image = global::MarieSelbyProject.Properties.Resources._1;
            this.exhibit3Pic.Location = new System.Drawing.Point(810, 191);
            this.exhibit3Pic.Name = "exhibit3Pic";
            this.exhibit3Pic.Size = new System.Drawing.Size(199, 132);
            this.exhibit3Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exhibit3Pic.TabIndex = 16;
            this.exhibit3Pic.TabStop = false;
            this.exhibit3Pic.Click += new System.EventHandler(this.exhibit3Pic_Click);
            // 
            // exhibit5Txt
            // 
            this.exhibit5Txt.CausesValidation = false;
            this.exhibit5Txt.HideSelection = false;
            this.exhibit5Txt.Location = new System.Drawing.Point(616, 381);
            this.exhibit5Txt.Multiline = true;
            this.exhibit5Txt.Name = "exhibit5Txt";
            this.exhibit5Txt.ReadOnly = true;
            this.exhibit5Txt.Size = new System.Drawing.Size(167, 132);
            this.exhibit5Txt.TabIndex = 25;
            // 
            // exhibit2Txt
            // 
            this.exhibit2Txt.CausesValidation = false;
            this.exhibit2Txt.HideSelection = false;
            this.exhibit2Txt.Location = new System.Drawing.Point(616, 191);
            this.exhibit2Txt.Multiline = true;
            this.exhibit2Txt.Name = "exhibit2Txt";
            this.exhibit2Txt.ReadOnly = true;
            this.exhibit2Txt.Size = new System.Drawing.Size(167, 132);
            this.exhibit2Txt.TabIndex = 24;
            // 
            // exhibit2Label
            // 
            this.exhibit2Label.AutoSize = true;
            this.exhibit2Label.Location = new System.Drawing.Point(491, 175);
            this.exhibit2Label.Name = "exhibit2Label";
            this.exhibit2Label.Size = new System.Drawing.Size(35, 13);
            this.exhibit2Label.TabIndex = 23;
            this.exhibit2Label.Text = "label3";
            // 
            // exhibit2Pic
            // 
            this.exhibit2Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exhibit2Pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exhibit2Pic.Image = global::MarieSelbyProject.Properties.Resources._1;
            this.exhibit2Pic.Location = new System.Drawing.Point(410, 191);
            this.exhibit2Pic.Name = "exhibit2Pic";
            this.exhibit2Pic.Size = new System.Drawing.Size(199, 132);
            this.exhibit2Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exhibit2Pic.TabIndex = 22;
            this.exhibit2Pic.TabStop = false;
            this.exhibit2Pic.Click += new System.EventHandler(this.exhibit2Pic_Click);
            // 
            // exhibit5Label
            // 
            this.exhibit5Label.AutoSize = true;
            this.exhibit5Label.Location = new System.Drawing.Point(491, 365);
            this.exhibit5Label.Name = "exhibit5Label";
            this.exhibit5Label.Size = new System.Drawing.Size(35, 13);
            this.exhibit5Label.TabIndex = 21;
            this.exhibit5Label.Text = "label4";
            // 
            // exhibit5Pic
            // 
            this.exhibit5Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exhibit5Pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exhibit5Pic.Image = global::MarieSelbyProject.Properties.Resources._1;
            this.exhibit5Pic.Location = new System.Drawing.Point(410, 381);
            this.exhibit5Pic.Name = "exhibit5Pic";
            this.exhibit5Pic.Size = new System.Drawing.Size(199, 132);
            this.exhibit5Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exhibit5Pic.TabIndex = 20;
            this.exhibit5Pic.TabStop = false;
            this.exhibit5Pic.Click += new System.EventHandler(this.exhibit5Pic_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(144, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(916, 73);
            this.titleLabel.TabIndex = 26;
            this.titleLabel.Text = "Marie Selby Botanical Gardens";
            // 
            // selectExhibitLabel
            // 
            this.selectExhibitLabel.AutoSize = true;
            this.selectExhibitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectExhibitLabel.Location = new System.Drawing.Point(393, 97);
            this.selectExhibitLabel.Name = "selectExhibitLabel";
            this.selectExhibitLabel.Size = new System.Drawing.Size(397, 39);
            this.selectExhibitLabel.TabIndex = 27;
            this.selectExhibitLabel.Text = "Select an Exhibit to View";
            // 
            // mainScreenMenu
            // 
            this.mainScreenMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainScreenMenu_File,
            this.mainScreenMenu_Help});
            this.mainScreenMenu.Location = new System.Drawing.Point(0, 0);
            this.mainScreenMenu.Name = "mainScreenMenu";
            this.mainScreenMenu.Size = new System.Drawing.Size(1203, 24);
            this.mainScreenMenu.TabIndex = 28;
            this.mainScreenMenu.Text = "menuStrip1";
            // 
            // mainScreenMenu_File
            // 
            this.mainScreenMenu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.mainScreenMenu_File_Admin,
            this.mainScreenMenu_File_Exit});
            this.mainScreenMenu_File.Name = "mainScreenMenu_File";
            this.mainScreenMenu_File.Size = new System.Drawing.Size(37, 20);
            this.mainScreenMenu_File.Text = "&File";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // mainScreenMenu_File_Admin
            // 
            this.mainScreenMenu_File_Admin.Name = "mainScreenMenu_File_Admin";
            this.mainScreenMenu_File_Admin.Size = new System.Drawing.Size(143, 22);
            this.mainScreenMenu_File_Admin.Text = "Admin Login";
            // 
            // mainScreenMenu_File_Exit
            // 
            this.mainScreenMenu_File_Exit.Name = "mainScreenMenu_File_Exit";
            this.mainScreenMenu_File_Exit.Size = new System.Drawing.Size(143, 22);
            this.mainScreenMenu_File_Exit.Text = "E&xit";
            // 
            // mainScreenMenu_Help
            // 
            this.mainScreenMenu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainScreenMenu_Help_Contents,
            this.mainScreenMenu_Help_Index,
            this.mainScreenMenu_Help_Search,
            this.toolStripSeparator5,
            this.mainScreenMenu_Help_About});
            this.mainScreenMenu_Help.Name = "mainScreenMenu_Help";
            this.mainScreenMenu_Help.Size = new System.Drawing.Size(44, 20);
            this.mainScreenMenu_Help.Text = "&Help";
            // 
            // mainScreenMenu_Help_Contents
            // 
            this.mainScreenMenu_Help_Contents.Name = "mainScreenMenu_Help_Contents";
            this.mainScreenMenu_Help_Contents.Size = new System.Drawing.Size(122, 22);
            this.mainScreenMenu_Help_Contents.Text = "&Contents";
            // 
            // mainScreenMenu_Help_Index
            // 
            this.mainScreenMenu_Help_Index.Name = "mainScreenMenu_Help_Index";
            this.mainScreenMenu_Help_Index.Size = new System.Drawing.Size(122, 22);
            this.mainScreenMenu_Help_Index.Text = "&Index";
            // 
            // mainScreenMenu_Help_Search
            // 
            this.mainScreenMenu_Help_Search.Name = "mainScreenMenu_Help_Search";
            this.mainScreenMenu_Help_Search.Size = new System.Drawing.Size(122, 22);
            this.mainScreenMenu_Help_Search.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // mainScreenMenu_Help_About
            // 
            this.mainScreenMenu_Help_About.Name = "mainScreenMenu_Help_About";
            this.mainScreenMenu_Help_About.Size = new System.Drawing.Size(122, 22);
            this.mainScreenMenu_Help_About.Text = "&About...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 522);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1203, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 544);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.selectExhibitLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exhibit5Txt);
            this.Controls.Add(this.exhibit2Txt);
            this.Controls.Add(this.exhibit2Label);
            this.Controls.Add(this.exhibit2Pic);
            this.Controls.Add(this.exhibit5Label);
            this.Controls.Add(this.exhibit5Pic);
            this.Controls.Add(this.exhibit3Txt);
            this.Controls.Add(this.exhibit3Label);
            this.Controls.Add(this.exhibit3Pic);
            this.Controls.Add(this.exhibit4Txt);
            this.Controls.Add(this.exhibit1Txt);
            this.Controls.Add(this.exhibit1Label);
            this.Controls.Add(this.exhibit1Pic);
            this.Controls.Add(this.exhibit4Label);
            this.Controls.Add(this.exhibit4Pic);
            this.Controls.Add(this.mainScreenMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainScreenMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1219, 583);
            this.MinimumSize = new System.Drawing.Size(1219, 583);
            this.Name = "MainScreen";
            this.Text = "Marie Selby Botanical Gardens";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mS_GARDENSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXHIBITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibit4Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibit1Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXHIBITBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibit3Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibit2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibit5Pic)).EndInit();
            this.mainScreenMenu.ResumeLayout(false);
            this.mainScreenMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MS_GARDENSDataSet mS_GARDENSDataSet;
        private System.Windows.Forms.BindingSource eXHIBITBindingSource;
        private MS_GARDENSDataSetTableAdapters.EXHIBITTableAdapter eXHIBITTableAdapter;
        private MS_GARDENSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox exhibit4Pic;
        private System.Windows.Forms.Label exhibit4Label;
        private System.Windows.Forms.Label exhibit1Label;
        private System.Windows.Forms.PictureBox exhibit1Pic;
        private System.Windows.Forms.TextBox exhibit1Txt;
        private System.Windows.Forms.TextBox exhibit4Txt;
        private System.Windows.Forms.TextBox exhibit3Txt;
        private System.Windows.Forms.Label exhibit3Label;
        private System.Windows.Forms.PictureBox exhibit3Pic;
        private System.Windows.Forms.TextBox exhibit5Txt;
        private System.Windows.Forms.TextBox exhibit2Txt;
        private System.Windows.Forms.Label exhibit2Label;
        private System.Windows.Forms.PictureBox exhibit2Pic;
        private System.Windows.Forms.Label exhibit5Label;
        private System.Windows.Forms.PictureBox exhibit5Pic;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label selectExhibitLabel;
        private System.Windows.Forms.MenuStrip mainScreenMenu;
        private System.Windows.Forms.ToolStripMenuItem mainScreenMenu_File;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mainScreenMenu_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem mainScreenMenu_Help;
        private System.Windows.Forms.ToolStripMenuItem mainScreenMenu_Help_Contents;
        private System.Windows.Forms.ToolStripMenuItem mainScreenMenu_Help_Index;
        private System.Windows.Forms.ToolStripMenuItem mainScreenMenu_Help_Search;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mainScreenMenu_Help_About;
        private System.Windows.Forms.ToolStripMenuItem mainScreenMenu_File_Admin;
        private System.Windows.Forms.BindingSource eXHIBITBindingSource1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

