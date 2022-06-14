
namespace SchedulingSoftware.Updated_Forms
{
    partial class frmNewReports
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
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApptTypes = new MaterialSkin.Controls.MaterialButton();
            this.btnSchedules = new MaterialSkin.Controls.MaterialButton();
            this.btnHours = new MaterialSkin.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgReports = new System.Windows.Forms.DataGridView();
            this.btnExport = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReports)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = false;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExit.Depth = 0;
            this.btnExit.DrawShadows = false;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.HighEmphasis = true;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(606, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExit.Size = new System.Drawing.Size(92, 40);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "Exit";
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHours);
            this.panel1.Controls.Add(this.btnSchedules);
            this.panel1.Controls.Add(this.btnApptTypes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 445);
            this.panel1.TabIndex = 39;
            // 
            // btnApptTypes
            // 
            this.btnApptTypes.AutoSize = false;
            this.btnApptTypes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApptTypes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnApptTypes.Depth = 0;
            this.btnApptTypes.DrawShadows = false;
            this.btnApptTypes.FlatAppearance.BorderSize = 0;
            this.btnApptTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApptTypes.HighEmphasis = true;
            this.btnApptTypes.Icon = null;
            this.btnApptTypes.Location = new System.Drawing.Point(4, 28);
            this.btnApptTypes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnApptTypes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnApptTypes.Name = "btnApptTypes";
            this.btnApptTypes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnApptTypes.Size = new System.Drawing.Size(207, 53);
            this.btnApptTypes.TabIndex = 40;
            this.btnApptTypes.Text = "Appt Types By Month";
            this.btnApptTypes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnApptTypes.UseAccentColor = false;
            this.btnApptTypes.UseVisualStyleBackColor = true;
            this.btnApptTypes.Click += new System.EventHandler(this.btnApptTypes_Click);
            // 
            // btnSchedules
            // 
            this.btnSchedules.AutoSize = false;
            this.btnSchedules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSchedules.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSchedules.Depth = 0;
            this.btnSchedules.DrawShadows = false;
            this.btnSchedules.FlatAppearance.BorderSize = 0;
            this.btnSchedules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedules.HighEmphasis = true;
            this.btnSchedules.Icon = null;
            this.btnSchedules.Location = new System.Drawing.Point(4, 93);
            this.btnSchedules.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSchedules.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSchedules.Name = "btnSchedules";
            this.btnSchedules.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSchedules.Size = new System.Drawing.Size(207, 53);
            this.btnSchedules.TabIndex = 41;
            this.btnSchedules.Text = "Weekly Schedule";
            this.btnSchedules.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSchedules.UseAccentColor = false;
            this.btnSchedules.UseVisualStyleBackColor = true;
            this.btnSchedules.Click += new System.EventHandler(this.btnSchedules_Click);
            // 
            // btnHours
            // 
            this.btnHours.AutoSize = false;
            this.btnHours.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHours.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHours.Depth = 0;
            this.btnHours.DrawShadows = false;
            this.btnHours.FlatAppearance.BorderSize = 0;
            this.btnHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHours.HighEmphasis = true;
            this.btnHours.Icon = null;
            this.btnHours.Location = new System.Drawing.Point(4, 158);
            this.btnHours.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHours.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHours.Name = "btnHours";
            this.btnHours.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHours.Size = new System.Drawing.Size(207, 53);
            this.btnHours.TabIndex = 42;
            this.btnHours.Text = "Weekly Hours";
            this.btnHours.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHours.UseAccentColor = false;
            this.btnHours.UseVisualStyleBackColor = true;
            this.btnHours.Click += new System.EventHandler(this.btnHours_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(218, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 57);
            this.panel2.TabIndex = 40;
            // 
            // dgReports
            // 
            this.dgReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgReports.Location = new System.Drawing.Point(218, 64);
            this.dgReports.Name = "dgReports";
            this.dgReports.Size = new System.Drawing.Size(702, 388);
            this.dgReports.TabIndex = 41;
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = false;
            this.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExport.Depth = 0;
            this.btnExport.DrawShadows = false;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.HighEmphasis = true;
            this.btnExport.Icon = null;
            this.btnExport.Location = new System.Drawing.Point(7, 11);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExport.Name = "btnExport";
            this.btnExport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExport.Size = new System.Drawing.Size(129, 40);
            this.btnExport.TabIndex = 35;
            this.btnExport.Text = "Export to CSV";
            this.btnExport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExport.UseAccentColor = false;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmNewReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 512);
            this.Controls.Add(this.dgReports);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmNewReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewReports";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnExit;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnHours;
        private MaterialSkin.Controls.MaterialButton btnSchedules;
        private MaterialSkin.Controls.MaterialButton btnApptTypes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgReports;
        private MaterialSkin.Controls.MaterialButton btnExport;
    }
}