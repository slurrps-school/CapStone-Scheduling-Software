
namespace SchedulingSoftware.Updated_Forms
{
    partial class frmNewMain
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
            this.mainDataContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCustomerName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCustomerAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnCustomerModify = new MaterialSkin.Controls.MaterialButton();
            this.btnCustomerDelete = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgAppointments = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAppTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAppAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAppModify = new MaterialSkin.Controls.MaterialButton();
            this.btnAppDelete = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgWeekView = new System.Windows.Forms.DataGridView();
            this.monthView = new System.Windows.Forms.MonthCalendar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radMonth = new MaterialSkin.Controls.MaterialRadioButton();
            this.radWeek = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblWeek = new MaterialSkin.Controls.MaterialLabel();
            this.btnPrev = new MaterialSkin.Controls.MaterialButton();
            this.btnNext = new MaterialSkin.Controls.MaterialButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.btnReports = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataContainer)).BeginInit();
            this.mainDataContainer.Panel1.SuspendLayout();
            this.mainDataContainer.Panel2.SuspendLayout();
            this.mainDataContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointments)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWeekView)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDataContainer
            // 
            this.mainDataContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDataContainer.Location = new System.Drawing.Point(3, 263);
            this.mainDataContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainDataContainer.Name = "mainDataContainer";
            this.mainDataContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainDataContainer.Panel1
            // 
            this.mainDataContainer.Panel1.Controls.Add(this.groupBox1);
            // 
            // mainDataContainer.Panel2
            // 
            this.mainDataContainer.Panel2.Controls.Add(this.groupBox2);
            this.mainDataContainer.Size = new System.Drawing.Size(819, 409);
            this.mainDataContainer.SplitterDistance = 197;
            this.mainDataContainer.SplitterWidth = 5;
            this.mainDataContainer.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgCustomers);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            // 
            // dgCustomers
            // 
            this.dgCustomers.AllowUserToAddRows = false;
            this.dgCustomers.AllowUserToDeleteRows = false;
            this.dgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCustomers.Location = new System.Drawing.Point(3, 16);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.ReadOnly = true;
            this.dgCustomers.RowHeadersVisible = false;
            this.dgCustomers.RowHeadersWidth = 62;
            this.dgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomers.Size = new System.Drawing.Size(813, 138);
            this.dgCustomers.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCustomerName);
            this.panel3.Controls.Add(this.materialLabel1);
            this.panel3.Controls.Add(this.btnCustomerAdd);
            this.panel3.Controls.Add(this.btnCustomerModify);
            this.panel3.Controls.Add(this.btnCustomerDelete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(813, 40);
            this.panel3.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCustomerName.AnimateReadOnly = false;
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerName.Depth = 0;
            this.txtCustomerName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomerName.LeadingIcon = null;
            this.txtCustomerName.Location = new System.Drawing.Point(162, 1);
            this.txtCustomerName.MaxLength = 50;
            this.txtCustomerName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustomerName.Multiline = false;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(349, 36);
            this.txtCustomerName.TabIndex = 21;
            this.txtCustomerName.Text = "";
            this.txtCustomerName.TrailingIcon = null;
            this.txtCustomerName.UseTallSize = false;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(37, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(119, 19);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "Customer Name:";
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCustomerAdd.AutoSize = false;
            this.btnCustomerAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCustomerAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCustomerAdd.Depth = 0;
            this.btnCustomerAdd.DrawShadows = false;
            this.btnCustomerAdd.FlatAppearance.BorderSize = 0;
            this.btnCustomerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerAdd.HighEmphasis = true;
            this.btnCustomerAdd.Icon = null;
            this.btnCustomerAdd.Location = new System.Drawing.Point(518, 3);
            this.btnCustomerAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCustomerAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCustomerAdd.Size = new System.Drawing.Size(92, 34);
            this.btnCustomerAdd.TabIndex = 15;
            this.btnCustomerAdd.Text = "Add Cust";
            this.btnCustomerAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCustomerAdd.UseAccentColor = false;
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // btnCustomerModify
            // 
            this.btnCustomerModify.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCustomerModify.AutoSize = false;
            this.btnCustomerModify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCustomerModify.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCustomerModify.Depth = 0;
            this.btnCustomerModify.DrawShadows = false;
            this.btnCustomerModify.FlatAppearance.BorderSize = 0;
            this.btnCustomerModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerModify.HighEmphasis = true;
            this.btnCustomerModify.Icon = null;
            this.btnCustomerModify.Location = new System.Drawing.Point(618, 3);
            this.btnCustomerModify.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCustomerModify.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCustomerModify.Name = "btnCustomerModify";
            this.btnCustomerModify.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCustomerModify.Size = new System.Drawing.Size(92, 34);
            this.btnCustomerModify.TabIndex = 14;
            this.btnCustomerModify.Text = "Modify";
            this.btnCustomerModify.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCustomerModify.UseAccentColor = false;
            this.btnCustomerModify.UseVisualStyleBackColor = true;
            this.btnCustomerModify.Click += new System.EventHandler(this.btnCustomerModify_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCustomerDelete.AutoSize = false;
            this.btnCustomerDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCustomerDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCustomerDelete.Depth = 0;
            this.btnCustomerDelete.DrawShadows = false;
            this.btnCustomerDelete.FlatAppearance.BorderSize = 0;
            this.btnCustomerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerDelete.HighEmphasis = true;
            this.btnCustomerDelete.Icon = null;
            this.btnCustomerDelete.Location = new System.Drawing.Point(718, 3);
            this.btnCustomerDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCustomerDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCustomerDelete.Size = new System.Drawing.Size(92, 34);
            this.btnCustomerDelete.TabIndex = 13;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCustomerDelete.UseAccentColor = false;
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgAppointments);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(819, 207);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointments";
            // 
            // dgAppointments
            // 
            this.dgAppointments.AllowUserToAddRows = false;
            this.dgAppointments.AllowUserToDeleteRows = false;
            this.dgAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAppointments.Location = new System.Drawing.Point(3, 16);
            this.dgAppointments.Name = "dgAppointments";
            this.dgAppointments.ReadOnly = true;
            this.dgAppointments.RowHeadersVisible = false;
            this.dgAppointments.RowHeadersWidth = 62;
            this.dgAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAppointments.Size = new System.Drawing.Size(813, 148);
            this.dgAppointments.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAppTitle);
            this.panel2.Controls.Add(this.btnAppAdd);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.btnAppModify);
            this.panel2.Controls.Add(this.btnAppDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 40);
            this.panel2.TabIndex = 0;
            // 
            // txtAppTitle
            // 
            this.txtAppTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppTitle.AnimateReadOnly = false;
            this.txtAppTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAppTitle.Depth = 0;
            this.txtAppTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAppTitle.LeadingIcon = null;
            this.txtAppTitle.Location = new System.Drawing.Point(162, 1);
            this.txtAppTitle.MaxLength = 50;
            this.txtAppTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAppTitle.Multiline = false;
            this.txtAppTitle.Name = "txtAppTitle";
            this.txtAppTitle.Size = new System.Drawing.Size(349, 36);
            this.txtAppTitle.TabIndex = 23;
            this.txtAppTitle.Text = "";
            this.txtAppTitle.TrailingIcon = null;
            this.txtAppTitle.UseTallSize = false;
            this.txtAppTitle.TextChanged += new System.EventHandler(this.txtAppTitle_TextChanged);
            // 
            // btnAppAdd
            // 
            this.btnAppAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAppAdd.AutoSize = false;
            this.btnAppAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAppAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAppAdd.Depth = 0;
            this.btnAppAdd.DrawShadows = false;
            this.btnAppAdd.FlatAppearance.BorderSize = 0;
            this.btnAppAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppAdd.HighEmphasis = true;
            this.btnAppAdd.Icon = null;
            this.btnAppAdd.Location = new System.Drawing.Point(518, 3);
            this.btnAppAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAppAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAppAdd.Name = "btnAppAdd";
            this.btnAppAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAppAdd.Size = new System.Drawing.Size(92, 34);
            this.btnAppAdd.TabIndex = 12;
            this.btnAppAdd.Text = "Add Appt";
            this.btnAppAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAppAdd.UseAccentColor = false;
            this.btnAppAdd.UseVisualStyleBackColor = true;
            this.btnAppAdd.Click += new System.EventHandler(this.btnAppAdd_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(25, 12);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(131, 19);
            this.materialLabel2.TabIndex = 22;
            this.materialLabel2.Text = "Appointment Title:";
            // 
            // btnAppModify
            // 
            this.btnAppModify.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAppModify.AutoSize = false;
            this.btnAppModify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAppModify.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAppModify.Depth = 0;
            this.btnAppModify.DrawShadows = false;
            this.btnAppModify.FlatAppearance.BorderSize = 0;
            this.btnAppModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppModify.HighEmphasis = true;
            this.btnAppModify.Icon = null;
            this.btnAppModify.Location = new System.Drawing.Point(618, 3);
            this.btnAppModify.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAppModify.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAppModify.Name = "btnAppModify";
            this.btnAppModify.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAppModify.Size = new System.Drawing.Size(92, 34);
            this.btnAppModify.TabIndex = 11;
            this.btnAppModify.Text = "Modify";
            this.btnAppModify.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAppModify.UseAccentColor = false;
            this.btnAppModify.UseVisualStyleBackColor = true;
            this.btnAppModify.Click += new System.EventHandler(this.btnAppModify_Click);
            // 
            // btnAppDelete
            // 
            this.btnAppDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAppDelete.AutoSize = false;
            this.btnAppDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAppDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAppDelete.Depth = 0;
            this.btnAppDelete.DrawShadows = false;
            this.btnAppDelete.FlatAppearance.BorderSize = 0;
            this.btnAppDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppDelete.HighEmphasis = true;
            this.btnAppDelete.Icon = null;
            this.btnAppDelete.Location = new System.Drawing.Point(718, 3);
            this.btnAppDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAppDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAppDelete.Name = "btnAppDelete";
            this.btnAppDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAppDelete.Size = new System.Drawing.Size(92, 34);
            this.btnAppDelete.TabIndex = 10;
            this.btnAppDelete.Text = "Delete";
            this.btnAppDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAppDelete.UseAccentColor = false;
            this.btnAppDelete.UseVisualStyleBackColor = true;
            this.btnAppDelete.Click += new System.EventHandler(this.btnAppDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgWeekView);
            this.panel1.Controls.Add(this.monthView);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 199);
            this.panel1.TabIndex = 4;
            // 
            // dgWeekView
            // 
            this.dgWeekView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgWeekView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWeekView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgWeekView.Location = new System.Drawing.Point(0, 30);
            this.dgWeekView.Name = "dgWeekView";
            this.dgWeekView.RowHeadersWidth = 62;
            this.dgWeekView.Size = new System.Drawing.Size(819, 169);
            this.dgWeekView.TabIndex = 1;
            this.dgWeekView.Visible = false;
            // 
            // monthView
            // 
            this.monthView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthView.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthView.Location = new System.Drawing.Point(65, 28);
            this.monthView.Name = "monthView";
            this.monthView.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radMonth);
            this.panel5.Controls.Add(this.radWeek);
            this.panel5.Controls.Add(this.lblWeek);
            this.panel5.Controls.Add(this.btnPrev);
            this.panel5.Controls.Add(this.btnNext);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(819, 30);
            this.panel5.TabIndex = 0;
            // 
            // radMonth
            // 
            this.radMonth.BackColor = System.Drawing.Color.Transparent;
            this.radMonth.Depth = 0;
            this.radMonth.FlatAppearance.BorderSize = 0;
            this.radMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radMonth.Location = new System.Drawing.Point(4, 1);
            this.radMonth.Margin = new System.Windows.Forms.Padding(0);
            this.radMonth.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radMonth.MouseState = MaterialSkin.MouseState.HOVER;
            this.radMonth.Name = "radMonth";
            this.radMonth.Ripple = true;
            this.radMonth.Size = new System.Drawing.Size(124, 27);
            this.radMonth.TabIndex = 19;
            this.radMonth.TabStop = true;
            this.radMonth.Text = "Month View";
            this.radMonth.UseVisualStyleBackColor = false;
            this.radMonth.Click += new System.EventHandler(this.radMonth_CheckedChanged);
            // 
            // radWeek
            // 
            this.radWeek.BackColor = System.Drawing.Color.Transparent;
            this.radWeek.Depth = 0;
            this.radWeek.FlatAppearance.BorderSize = 0;
            this.radWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radWeek.Location = new System.Drawing.Point(128, 0);
            this.radWeek.Margin = new System.Windows.Forms.Padding(0);
            this.radWeek.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radWeek.MouseState = MaterialSkin.MouseState.HOVER;
            this.radWeek.Name = "radWeek";
            this.radWeek.Ripple = true;
            this.radWeek.Size = new System.Drawing.Size(112, 27);
            this.radWeek.TabIndex = 2;
            this.radWeek.TabStop = true;
            this.radWeek.Text = "Week View";
            this.radWeek.UseVisualStyleBackColor = false;
            this.radWeek.Click += new System.EventHandler(this.radWeek_CheckedChanged);
            // 
            // lblWeek
            // 
            this.lblWeek.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblWeek.AutoSize = true;
            this.lblWeek.Depth = 0;
            this.lblWeek.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWeek.Location = new System.Drawing.Point(710, 6);
            this.lblWeek.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(107, 19);
            this.lblWeek.TabIndex = 18;
            this.lblWeek.Text = "materialLabel1";
            this.lblWeek.Visible = false;
            // 
            // btnPrev
            // 
            this.btnPrev.AutoSize = false;
            this.btnPrev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrev.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrev.Depth = 0;
            this.btnPrev.DrawShadows = false;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.HighEmphasis = true;
            this.btnPrev.Icon = null;
            this.btnPrev.Location = new System.Drawing.Point(276, 4);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrev.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrev.Size = new System.Drawing.Size(129, 23);
            this.btnPrev.TabIndex = 17;
            this.btnPrev.Text = "Previous Week";
            this.btnPrev.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrev.UseAccentColor = false;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Visible = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = false;
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNext.Depth = 0;
            this.btnNext.DrawShadows = false;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.HighEmphasis = true;
            this.btnNext.Icon = null;
            this.btnNext.Location = new System.Drawing.Point(413, 4);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNext.Size = new System.Drawing.Size(129, 23);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next Week";
            this.btnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNext.UseAccentColor = false;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnReports);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 672);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(819, 40);
            this.panel4.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.AutoSize = false;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExit.Depth = 0;
            this.btnExit.DrawShadows = false;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.HighEmphasis = true;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(722, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExit.Size = new System.Drawing.Size(92, 40);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReports.AutoSize = false;
            this.btnReports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReports.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReports.Depth = 0;
            this.btnReports.DrawShadows = false;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.HighEmphasis = true;
            this.btnReports.Icon = null;
            this.btnReports.Location = new System.Drawing.Point(4, 0);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReports.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReports.Name = "btnReports";
            this.btnReports.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReports.Size = new System.Drawing.Size(92, 40);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Reports";
            this.btnReports.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReports.UseAccentColor = false;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // frmNewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 715);
            this.Controls.Add(this.mainDataContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "frmNewMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Scheduler Main Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainDataContainer.Panel1.ResumeLayout(false);
            this.mainDataContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataContainer)).EndInit();
            this.mainDataContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointments)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgWeekView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainDataContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgAppointments;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgWeekView;
        private System.Windows.Forms.MonthCalendar monthView;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialButton btnCustomerAdd;
        private MaterialSkin.Controls.MaterialButton btnCustomerModify;
        private MaterialSkin.Controls.MaterialButton btnCustomerDelete;
        private MaterialSkin.Controls.MaterialButton btnAppAdd;
        private MaterialSkin.Controls.MaterialButton btnAppModify;
        private MaterialSkin.Controls.MaterialButton btnAppDelete;
        private MaterialSkin.Controls.MaterialButton btnPrev;
        private MaterialSkin.Controls.MaterialButton btnNext;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialButton btnReports;
        private MaterialSkin.Controls.MaterialRadioButton radWeek;
        private MaterialSkin.Controls.MaterialLabel lblWeek;
        private MaterialSkin.Controls.MaterialRadioButton radMonth;
        private MaterialSkin.Controls.MaterialTextBox txtCustomerName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtAppTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}