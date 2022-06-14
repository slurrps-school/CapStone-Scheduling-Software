
namespace SchedulingSoftware.Forms
{
    partial class frmNewAppointment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.txtCustomer = new MaterialSkin.Controls.MaterialTextBox();
            this.txtURL = new MaterialSkin.Controls.MaterialTextBox();
            this.txtType = new MaterialSkin.Controls.MaterialTextBox();
            this.txtContact = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLocation = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDesc = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgAppointments = new System.Windows.Forms.DataGridView();
            this.pnAppointments = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAppointmentTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.pnCustomers = new System.Windows.Forms.Panel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCustomerName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointments)).BeginInit();
            this.pnAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            this.pnCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel13);
            this.groupBox1.Controls.Add(this.materialLabel12);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.materialLabel10);
            this.groupBox1.Controls.Add(this.materialLabel9);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Controls.Add(this.dateTimeEnd);
            this.groupBox1.Controls.Add(this.dateTimeStart);
            this.groupBox1.Controls.Add(this.txtCustomer);
            this.groupBox1.Controls.Add(this.txtURL);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 543);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Details";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(15, 498);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(69, 19);
            this.materialLabel13.TabIndex = 19;
            this.materialLabel13.Text = "End Date:";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(15, 458);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(76, 19);
            this.materialLabel12.TabIndex = 18;
            this.materialLabel12.Text = "Start Date:";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(15, 414);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(73, 19);
            this.materialLabel11.TabIndex = 17;
            this.materialLabel11.Text = "Customer:";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(15, 372);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(34, 19);
            this.materialLabel10.TabIndex = 16;
            this.materialLabel10.Text = "URL:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(15, 330);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(40, 19);
            this.materialLabel9.TabIndex = 15;
            this.materialLabel9.Text = "Type:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(15, 288);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(60, 19);
            this.materialLabel8.TabIndex = 14;
            this.materialLabel8.Text = "Contact:";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(106, 490);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(348, 35);
            this.dateTimeEnd.TabIndex = 13;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(106, 449);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(348, 35);
            this.dateTimeStart.TabIndex = 12;
            // 
            // txtCustomer
            // 
            this.txtCustomer.AnimateReadOnly = false;
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomer.Depth = 0;
            this.txtCustomer.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomer.LeadingIcon = null;
            this.txtCustomer.Location = new System.Drawing.Point(106, 407);
            this.txtCustomer.MaxLength = 50;
            this.txtCustomer.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustomer.Multiline = false;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(348, 36);
            this.txtCustomer.TabIndex = 11;
            this.txtCustomer.Text = "";
            this.txtCustomer.TrailingIcon = null;
            this.txtCustomer.UseTallSize = false;
            // 
            // txtURL
            // 
            this.txtURL.AnimateReadOnly = false;
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtURL.Depth = 0;
            this.txtURL.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtURL.LeadingIcon = null;
            this.txtURL.Location = new System.Drawing.Point(106, 365);
            this.txtURL.MaxLength = 50;
            this.txtURL.MouseState = MaterialSkin.MouseState.OUT;
            this.txtURL.Multiline = false;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(348, 36);
            this.txtURL.TabIndex = 10;
            this.txtURL.Text = "";
            this.txtURL.TrailingIcon = null;
            this.txtURL.UseTallSize = false;
            // 
            // txtType
            // 
            this.txtType.AnimateReadOnly = false;
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtType.Depth = 0;
            this.txtType.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtType.LeadingIcon = null;
            this.txtType.Location = new System.Drawing.Point(106, 323);
            this.txtType.MaxLength = 50;
            this.txtType.MouseState = MaterialSkin.MouseState.OUT;
            this.txtType.Multiline = false;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(348, 36);
            this.txtType.TabIndex = 9;
            this.txtType.Text = "";
            this.txtType.TrailingIcon = null;
            this.txtType.UseTallSize = false;
            // 
            // txtContact
            // 
            this.txtContact.AnimateReadOnly = false;
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContact.Depth = 0;
            this.txtContact.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContact.LeadingIcon = null;
            this.txtContact.Location = new System.Drawing.Point(106, 281);
            this.txtContact.MaxLength = 50;
            this.txtContact.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContact.Multiline = false;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(348, 36);
            this.txtContact.TabIndex = 8;
            this.txtContact.Text = "";
            this.txtContact.TrailingIcon = null;
            this.txtContact.UseTallSize = false;
            // 
            // txtLocation
            // 
            this.txtLocation.AnimateReadOnly = false;
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocation.Depth = 0;
            this.txtLocation.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLocation.LeadingIcon = null;
            this.txtLocation.Location = new System.Drawing.Point(106, 239);
            this.txtLocation.MaxLength = 50;
            this.txtLocation.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLocation.Multiline = false;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(348, 36);
            this.txtLocation.TabIndex = 7;
            this.txtLocation.Text = "";
            this.txtLocation.TrailingIcon = null;
            this.txtLocation.UseTallSize = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(15, 246);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(67, 19);
            this.materialLabel7.TabIndex = 6;
            this.materialLabel7.Text = "Location:";
            // 
            // txtTitle
            // 
            this.txtTitle.AnimateReadOnly = false;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Depth = 0;
            this.txtTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTitle.LeadingIcon = null;
            this.txtTitle.Location = new System.Drawing.Point(106, 47);
            this.txtTitle.MaxLength = 50;
            this.txtTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTitle.Multiline = false;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(348, 36);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.Text = "";
            this.txtTitle.TrailingIcon = null;
            this.txtTitle.UseTallSize = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(15, 89);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(85, 19);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Description:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(15, 52);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(36, 19);
            this.materialLabel5.TabIndex = 3;
            this.materialLabel5.Text = "Title:";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.Depth = 0;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDesc.Location = new System.Drawing.Point(106, 89);
            this.txtDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(348, 144);
            this.txtDesc.TabIndex = 1;
            this.txtDesc.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 607);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 40);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.DrawShadows = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(945, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(92, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.DrawShadows = false;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(1045, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(92, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgAppointments);
            this.groupBox2.Controls.Add(this.pnAppointments);
            this.groupBox2.Controls.Add(this.dgCustomers);
            this.groupBox2.Controls.Add(this.pnCustomers);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(478, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 543);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customers and Appointments";
            // 
            // dgAppointments
            // 
            this.dgAppointments.AllowUserToAddRows = false;
            this.dgAppointments.AllowUserToDeleteRows = false;
            this.dgAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAppointments.Location = new System.Drawing.Point(3, 342);
            this.dgAppointments.Name = "dgAppointments";
            this.dgAppointments.ReadOnly = true;
            this.dgAppointments.RowHeadersVisible = false;
            this.dgAppointments.RowHeadersWidth = 62;
            this.dgAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAppointments.Size = new System.Drawing.Size(659, 198);
            this.dgAppointments.TabIndex = 24;
            // 
            // pnAppointments
            // 
            this.pnAppointments.Controls.Add(this.materialLabel4);
            this.pnAppointments.Controls.Add(this.materialLabel2);
            this.pnAppointments.Controls.Add(this.txtAppointmentTitle);
            this.pnAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAppointments.Location = new System.Drawing.Point(3, 302);
            this.pnAppointments.Name = "pnAppointments";
            this.pnAppointments.Size = new System.Drawing.Size(659, 40);
            this.pnAppointments.TabIndex = 23;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(203, 10);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(131, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Appointment Title:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(3, 8);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(151, 29);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Appointments";
            // 
            // txtAppointmentTitle
            // 
            this.txtAppointmentTitle.AnimateReadOnly = false;
            this.txtAppointmentTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAppointmentTitle.Depth = 0;
            this.txtAppointmentTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAppointmentTitle.LeadingIcon = null;
            this.txtAppointmentTitle.Location = new System.Drawing.Point(340, 3);
            this.txtAppointmentTitle.MaxLength = 50;
            this.txtAppointmentTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAppointmentTitle.Multiline = false;
            this.txtAppointmentTitle.Name = "txtAppointmentTitle";
            this.txtAppointmentTitle.Size = new System.Drawing.Size(316, 36);
            this.txtAppointmentTitle.TabIndex = 3;
            this.txtAppointmentTitle.Text = "";
            this.txtAppointmentTitle.TrailingIcon = null;
            this.txtAppointmentTitle.UseTallSize = false;
            this.txtAppointmentTitle.TextChanged += new System.EventHandler(this.txtAppointmentTitle_TextChanged);
            // 
            // dgCustomers
            // 
            this.dgCustomers.AllowUserToAddRows = false;
            this.dgCustomers.AllowUserToDeleteRows = false;
            this.dgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgCustomers.Location = new System.Drawing.Point(3, 71);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.ReadOnly = true;
            this.dgCustomers.RowHeadersVisible = false;
            this.dgCustomers.RowHeadersWidth = 62;
            this.dgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomers.Size = new System.Drawing.Size(659, 231);
            this.dgCustomers.TabIndex = 22;
            this.dgCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomers_CellClick);
            // 
            // pnCustomers
            // 
            this.pnCustomers.Controls.Add(this.materialLabel3);
            this.pnCustomers.Controls.Add(this.txtCustomerName);
            this.pnCustomers.Controls.Add(this.materialLabel1);
            this.pnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCustomers.Location = new System.Drawing.Point(3, 31);
            this.pnCustomers.Name = "pnCustomers";
            this.pnCustomers.Size = new System.Drawing.Size(659, 40);
            this.pnCustomers.TabIndex = 2;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(151, 11);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(119, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AnimateReadOnly = false;
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerName.Depth = 0;
            this.txtCustomerName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomerName.LeadingIcon = null;
            this.txtCustomerName.Location = new System.Drawing.Point(276, 3);
            this.txtCustomerName.MaxLength = 50;
            this.txtCustomerName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCustomerName.Multiline = false;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(380, 36);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.Text = "";
            this.txtCustomerName.TrailingIcon = null;
            this.txtCustomerName.UseTallSize = false;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(3, 8);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(118, 29);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Customers";
            // 
            // frmNewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmNewAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Screen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointments)).EndInit();
            this.pnAppointments.ResumeLayout(false);
            this.pnAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            this.pnCustomers.ResumeLayout(false);
            this.pnCustomers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnCustomers;
        private System.Windows.Forms.DataGridView dgAppointments;
        private System.Windows.Forms.Panel pnAppointments;
        private System.Windows.Forms.DataGridView dgCustomers;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtCustomerName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox txtAppointmentTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtDesc;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txtTitle;
        private MaterialSkin.Controls.MaterialTextBox txtLocation;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox txtCustomer;
        private MaterialSkin.Controls.MaterialTextBox txtURL;
        private MaterialSkin.Controls.MaterialTextBox txtType;
        private MaterialSkin.Controls.MaterialTextBox txtContact;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
    }
}