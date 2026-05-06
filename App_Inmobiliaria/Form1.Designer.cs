namespace App_Inmobiliaria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbPropertyData = new GroupBox();
            gbExtraData = new GroupBox();
            txtArea = new TextBox();
            lblArea = new Label();
            txtMonths = new TextBox();
            lblMonths = new Label();
            rbRent = new RadioButton();
            rbSale = new RadioButton();
            cmbPropertyModel = new ComboBox();
            lblPropertyModel = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            lblClientName = new Label();
            txtClientName = new TextBox();
            cmbTypes = new ComboBox();
            txtSellerName = new TextBox();
            lblSellerName = new Label();
            lblType = new Label();
            btnRegisterAndCalculate = new Button();
            dgvProperties = new DataGridView();
            gbPropertyData.SuspendLayout();
            gbExtraData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).BeginInit();
            SuspendLayout();
            // 
            // gbPropertyData
            // 
            gbPropertyData.Controls.Add(gbExtraData);
            gbPropertyData.Controls.Add(cmbPropertyModel);
            gbPropertyData.Controls.Add(lblPropertyModel);
            gbPropertyData.Controls.Add(txtAddress);
            gbPropertyData.Controls.Add(lblAddress);
            gbPropertyData.Controls.Add(lblClientName);
            gbPropertyData.Controls.Add(txtClientName);
            gbPropertyData.Controls.Add(cmbTypes);
            gbPropertyData.Controls.Add(txtSellerName);
            gbPropertyData.Controls.Add(lblSellerName);
            gbPropertyData.Controls.Add(lblType);
            gbPropertyData.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbPropertyData.Location = new Point(12, 12);
            gbPropertyData.Name = "gbPropertyData";
            gbPropertyData.Size = new Size(282, 200);
            gbPropertyData.TabIndex = 0;
            gbPropertyData.TabStop = false;
            gbPropertyData.Text = "Datos de la propiedad";
            // 
            // gbExtraData
            // 
            gbExtraData.Controls.Add(txtArea);
            gbExtraData.Controls.Add(lblArea);
            gbExtraData.Controls.Add(txtMonths);
            gbExtraData.Controls.Add(lblMonths);
            gbExtraData.Controls.Add(rbRent);
            gbExtraData.Controls.Add(rbSale);
            gbExtraData.Font = new Font("Segoe UI", 9F);
            gbExtraData.Location = new Point(135, 66);
            gbExtraData.Name = "gbExtraData";
            gbExtraData.Size = new Size(141, 134);
            gbExtraData.TabIndex = 3;
            gbExtraData.TabStop = false;
            gbExtraData.Text = "Datos especificos";
            // 
            // txtArea
            // 
            txtArea.Font = new Font("Segoe UI", 9F);
            txtArea.Location = new Point(6, 103);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(113, 23);
            txtArea.TabIndex = 11;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 9F);
            lblArea.Location = new Point(6, 85);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(31, 15);
            lblArea.TabIndex = 10;
            lblArea.Text = "Area";
            // 
            // txtMonths
            // 
            txtMonths.Font = new Font("Segoe UI", 9F);
            txtMonths.Location = new Point(6, 59);
            txtMonths.Name = "txtMonths";
            txtMonths.Size = new Size(113, 23);
            txtMonths.TabIndex = 9;
            // 
            // lblMonths
            // 
            lblMonths.AutoSize = true;
            lblMonths.Font = new Font("Segoe UI", 9F);
            lblMonths.Location = new Point(6, 41);
            lblMonths.Name = "lblMonths";
            lblMonths.Size = new Size(40, 15);
            lblMonths.TabIndex = 9;
            lblMonths.Text = "Meses";
            // 
            // rbRent
            // 
            rbRent.AutoSize = true;
            rbRent.Checked = true;
            rbRent.Location = new Point(66, 19);
            rbRent.Name = "rbRent";
            rbRent.Size = new Size(55, 19);
            rbRent.TabIndex = 4;
            rbRent.TabStop = true;
            rbRent.Text = "Renta";
            rbRent.UseVisualStyleBackColor = true;
            rbRent.CheckedChanged += rbRent_CheckedChanged;
            // 
            // rbSale
            // 
            rbSale.AutoSize = true;
            rbSale.Location = new Point(6, 19);
            rbSale.Name = "rbSale";
            rbSale.Size = new Size(54, 19);
            rbSale.TabIndex = 3;
            rbSale.Text = "Venta";
            rbSale.UseVisualStyleBackColor = true;
            rbSale.CheckedChanged += rbSale_CheckedChanged;
            // 
            // cmbPropertyModel
            // 
            cmbPropertyModel.Enabled = false;
            cmbPropertyModel.Font = new Font("Segoe UI", 9F);
            cmbPropertyModel.FormattingEnabled = true;
            cmbPropertyModel.Location = new Point(133, 37);
            cmbPropertyModel.Name = "cmbPropertyModel";
            cmbPropertyModel.Size = new Size(121, 23);
            cmbPropertyModel.TabIndex = 8;
            // 
            // lblPropertyModel
            // 
            lblPropertyModel.AutoSize = true;
            lblPropertyModel.Font = new Font("Segoe UI", 9F);
            lblPropertyModel.Location = new Point(133, 19);
            lblPropertyModel.Name = "lblPropertyModel";
            lblPropertyModel.Size = new Size(72, 15);
            lblPropertyModel.TabIndex = 7;
            lblPropertyModel.Text = "Tipo de bien";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9F);
            txtAddress.Location = new Point(6, 169);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(123, 23);
            txtAddress.TabIndex = 6;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9F);
            lblAddress.Location = new Point(6, 151);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(57, 15);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Dirección";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Font = new Font("Segoe UI", 9F);
            lblClientName.Location = new Point(6, 107);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(108, 15);
            lblClientName.TabIndex = 4;
            lblClientName.Text = "Nombre del cliente";
            // 
            // txtClientName
            // 
            txtClientName.Font = new Font("Segoe UI", 9F);
            txtClientName.Location = new Point(6, 125);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(123, 23);
            txtClientName.TabIndex = 3;
            // 
            // cmbTypes
            // 
            cmbTypes.Font = new Font("Segoe UI", 9F);
            cmbTypes.FormattingEnabled = true;
            cmbTypes.Items.AddRange(new object[] { "Lujo", "Comerciales", "Terrenos" });
            cmbTypes.Location = new Point(6, 37);
            cmbTypes.Name = "cmbTypes";
            cmbTypes.Size = new Size(121, 23);
            cmbTypes.TabIndex = 1;
            cmbTypes.SelectedIndexChanged += cmbTypes_SelectedIndexChanged;
            // 
            // txtSellerName
            // 
            txtSellerName.Font = new Font("Segoe UI", 9F);
            txtSellerName.Location = new Point(6, 81);
            txtSellerName.Name = "txtSellerName";
            txtSellerName.Size = new Size(123, 23);
            txtSellerName.TabIndex = 1;
            // 
            // lblSellerName
            // 
            lblSellerName.AutoSize = true;
            lblSellerName.Font = new Font("Segoe UI", 9F);
            lblSellerName.Location = new Point(6, 63);
            lblSellerName.Name = "lblSellerName";
            lblSellerName.Size = new Size(123, 15);
            lblSellerName.TabIndex = 1;
            lblSellerName.Text = "Nombre del vendedor";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 9F);
            lblType.Location = new Point(6, 19);
            lblType.Name = "lblType";
            lblType.Size = new Size(72, 15);
            lblType.TabIndex = 2;
            lblType.Text = "Tipo de bien";
            // 
            // btnRegisterAndCalculate
            // 
            btnRegisterAndCalculate.BackColor = Color.OliveDrab;
            btnRegisterAndCalculate.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnRegisterAndCalculate.ForeColor = SystemColors.Control;
            btnRegisterAndCalculate.Location = new Point(12, 218);
            btnRegisterAndCalculate.Name = "btnRegisterAndCalculate";
            btnRegisterAndCalculate.Size = new Size(95, 42);
            btnRegisterAndCalculate.TabIndex = 1;
            btnRegisterAndCalculate.Text = "Registrar y calcular";
            btnRegisterAndCalculate.UseVisualStyleBackColor = false;
            btnRegisterAndCalculate.Click += btnRegisterAndCalculate_Click;
            // 
            // dgvProperties
            // 
            dgvProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProperties.Location = new Point(300, 12);
            dgvProperties.Name = "dgvProperties";
            dgvProperties.Size = new Size(542, 200);
            dgvProperties.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(854, 270);
            Controls.Add(dgvProperties);
            Controls.Add(btnRegisterAndCalculate);
            Controls.Add(gbPropertyData);
            Name = "Form1";
            Text = "Registro de propiedades";
            gbPropertyData.ResumeLayout(false);
            gbPropertyData.PerformLayout();
            gbExtraData.ResumeLayout(false);
            gbExtraData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbPropertyData;
        private TextBox txtSellerName;
        private Label lblSellerName;
        private ComboBox cmbTypes;
        private Label lblType;
        private TextBox txtClientName;
        private Label lblClientName;
        private TextBox txtAddress;
        private Label lblAddress;
        private ComboBox cmbPropertyModel;
        private Label lblPropertyModel;
        private Button btnRegisterAndCalculate;
        private DataGridView dgvProperties;
        private GroupBox gbExtraData;
        private RadioButton rbRent;
        private RadioButton rbSale;
        private TextBox txtMonths;
        private Label lblMonths;
        private TextBox txtArea;
        private Label lblArea;
    }
}
