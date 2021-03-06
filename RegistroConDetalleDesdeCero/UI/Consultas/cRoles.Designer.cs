
namespace RegistroConDetalleDesdeCero.UI.Consultas
{
    partial class cRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cRoles));
            this.label1 = new System.Windows.Forms.Label();
            this.FiltroFechaCheckBox = new System.Windows.Forms.CheckBox();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.RolesConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.esActivoGroupBox = new System.Windows.Forms.GroupBox();
            this.InactivosRadioButton = new System.Windows.Forms.RadioButton();
            this.ActivosRadioButton = new System.Windows.Forms.RadioButton();
            this.TodosRadioButton = new System.Windows.Forms.RadioButton();
            this.FechaGroupBox = new System.Windows.Forms.GroupBox();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.FiltroActivoCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.RolesConsultaDataGridView)).BeginInit();
            this.esActivoGroupBox.SuspendLayout();
            this.FechaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro";
            // 
            // FiltroFechaCheckBox
            // 
            this.FiltroFechaCheckBox.AutoSize = true;
            this.FiltroFechaCheckBox.Location = new System.Drawing.Point(12, 12);
            this.FiltroFechaCheckBox.Name = "FiltroFechaCheckBox";
            this.FiltroFechaCheckBox.Size = new System.Drawing.Size(167, 24);
            this.FiltroFechaCheckBox.TabIndex = 1;
            this.FiltroFechaCheckBox.Text = "Usar Filtro de Fechas";
            this.FiltroFechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Rol Id",
            "Descripción"});
            this.FiltroComboBox.Location = new System.Drawing.Point(61, 68);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(118, 28);
            this.FiltroComboBox.TabIndex = 2;
            // 
            // RolesConsultaDataGridView
            // 
            this.RolesConsultaDataGridView.AllowUserToAddRows = false;
            this.RolesConsultaDataGridView.AllowUserToDeleteRows = false;
            this.RolesConsultaDataGridView.AllowUserToOrderColumns = true;
            this.RolesConsultaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RolesConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolesConsultaDataGridView.Location = new System.Drawing.Point(12, 115);
            this.RolesConsultaDataGridView.Name = "RolesConsultaDataGridView";
            this.RolesConsultaDataGridView.ReadOnly = true;
            this.RolesConsultaDataGridView.RowHeadersWidth = 51;
            this.RolesConsultaDataGridView.RowTemplate.Height = 29;
            this.RolesConsultaDataGridView.Size = new System.Drawing.Size(862, 441);
            this.RolesConsultaDataGridView.TabIndex = 3;
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImprimirButton.Location = new System.Drawing.Point(12, 563);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(115, 44);
            this.ImprimirButton.TabIndex = 4;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(774, 25);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(100, 86);
            this.BuscarButton.TabIndex = 5;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // esActivoGroupBox
            // 
            this.esActivoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.esActivoGroupBox.Controls.Add(this.InactivosRadioButton);
            this.esActivoGroupBox.Controls.Add(this.ActivosRadioButton);
            this.esActivoGroupBox.Controls.Add(this.TodosRadioButton);
            this.esActivoGroupBox.Enabled = false;
            this.esActivoGroupBox.Location = new System.Drawing.Point(644, 12);
            this.esActivoGroupBox.Name = "esActivoGroupBox";
            this.esActivoGroupBox.Size = new System.Drawing.Size(124, 97);
            this.esActivoGroupBox.TabIndex = 6;
            this.esActivoGroupBox.TabStop = false;
            this.esActivoGroupBox.Text = "esActivo?";
            // 
            // InactivosRadioButton
            // 
            this.InactivosRadioButton.AutoSize = true;
            this.InactivosRadioButton.Location = new System.Drawing.Point(6, 73);
            this.InactivosRadioButton.Name = "InactivosRadioButton";
            this.InactivosRadioButton.Size = new System.Drawing.Size(88, 24);
            this.InactivosRadioButton.TabIndex = 2;
            this.InactivosRadioButton.Text = "Inactivos";
            this.InactivosRadioButton.UseVisualStyleBackColor = true;
            // 
            // ActivosRadioButton
            // 
            this.ActivosRadioButton.AutoSize = true;
            this.ActivosRadioButton.Location = new System.Drawing.Point(6, 50);
            this.ActivosRadioButton.Name = "ActivosRadioButton";
            this.ActivosRadioButton.Size = new System.Drawing.Size(78, 24);
            this.ActivosRadioButton.TabIndex = 1;
            this.ActivosRadioButton.Text = "Activos";
            this.ActivosRadioButton.UseVisualStyleBackColor = true;
            // 
            // TodosRadioButton
            // 
            this.TodosRadioButton.AutoSize = true;
            this.TodosRadioButton.Checked = true;
            this.TodosRadioButton.Location = new System.Drawing.Point(6, 26);
            this.TodosRadioButton.Name = "TodosRadioButton";
            this.TodosRadioButton.Size = new System.Drawing.Size(70, 24);
            this.TodosRadioButton.TabIndex = 0;
            this.TodosRadioButton.TabStop = true;
            this.TodosRadioButton.Text = "Todos";
            this.TodosRadioButton.UseVisualStyleBackColor = true;
            this.TodosRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FechaGroupBox
            // 
            this.FechaGroupBox.Controls.Add(this.HastaLabel);
            this.FechaGroupBox.Controls.Add(this.HastaDateTimePicker);
            this.FechaGroupBox.Controls.Add(this.DesdeDateTimePicker);
            this.FechaGroupBox.Controls.Add(this.DesdeLabel);
            this.FechaGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FechaGroupBox.Location = new System.Drawing.Point(211, 12);
            this.FechaGroupBox.Name = "FechaGroupBox";
            this.FechaGroupBox.Size = new System.Drawing.Size(418, 50);
            this.FechaGroupBox.TabIndex = 7;
            this.FechaGroupBox.TabStop = false;
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Location = new System.Drawing.Point(230, 20);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(47, 20);
            this.HastaLabel.TabIndex = 3;
            this.HastaLabel.Text = "Hasta";
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(287, 17);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(125, 27);
            this.HastaDateTimePicker.TabIndex = 2;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(63, 17);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(125, 27);
            this.DesdeDateTimePicker.TabIndex = 1;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Location = new System.Drawing.Point(6, 20);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(51, 20);
            this.DesdeLabel.TabIndex = 0;
            this.DesdeLabel.Text = "Desde";
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(211, 68);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(418, 27);
            this.CriterioTextBox.TabIndex = 8;
            // 
            // FiltroActivoCheckBox
            // 
            this.FiltroActivoCheckBox.AutoSize = true;
            this.FiltroActivoCheckBox.Location = new System.Drawing.Point(12, 38);
            this.FiltroActivoCheckBox.Name = "FiltroActivoCheckBox";
            this.FiltroActivoCheckBox.Size = new System.Drawing.Size(160, 24);
            this.FiltroActivoCheckBox.TabIndex = 19;
            this.FiltroActivoCheckBox.Text = "Usar Filtro es activo";
            this.FiltroActivoCheckBox.UseVisualStyleBackColor = true;
            this.FiltroActivoCheckBox.CheckedChanged += new System.EventHandler(this.FiltroActivoCheckBox_CheckedChanged);
            // 
            // cRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 619);
            this.Controls.Add(this.FiltroActivoCheckBox);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.FechaGroupBox);
            this.Controls.Add(this.esActivoGroupBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.RolesConsultaDataGridView);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.FiltroFechaCheckBox);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(904, 350);
            this.Name = "cRoles";
            this.Text = "Consulta de Roles";
            this.Load += new System.EventHandler(this.cRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RolesConsultaDataGridView)).EndInit();
            this.esActivoGroupBox.ResumeLayout(false);
            this.esActivoGroupBox.PerformLayout();
            this.FechaGroupBox.ResumeLayout(false);
            this.FechaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox FiltroFechaCheckBox;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.DataGridView RolesConsultaDataGridView;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.GroupBox esActivoGroupBox;
        private System.Windows.Forms.RadioButton TodosRadioButton;
        private System.Windows.Forms.RadioButton InactivosRadioButton;
        private System.Windows.Forms.RadioButton ActivosRadioButton;
        private System.Windows.Forms.GroupBox FechaGroupBox;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.CheckBox FiltroActivoCheckBox;
    }
}