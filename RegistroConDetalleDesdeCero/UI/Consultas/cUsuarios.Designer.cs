
namespace RegistroConDetalleDesdeCero.UI.Consultas
{
    partial class cUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cUsuarios));
            this.FechaGroupBox = new System.Windows.Forms.GroupBox();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltroFechaCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TodosRadioButton = new System.Windows.Forms.RadioButton();
            this.esActivoGroupBox = new System.Windows.Forms.GroupBox();
            this.InactivosRadioButton = new System.Windows.Forms.RadioButton();
            this.ActivosRadioButton = new System.Windows.Forms.RadioButton();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.UsuariosConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.FiltroActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.FechaGroupBox.SuspendLayout();
            this.esActivoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.FechaGroupBox.TabIndex = 16;
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
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Usuario Id",
            "Alias",
            "Nombres",
            "Email",
            "RolId"});
            this.FiltroComboBox.Location = new System.Drawing.Point(61, 68);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(118, 28);
            this.FiltroComboBox.TabIndex = 11;
            // 
            // FiltroFechaCheckBox
            // 
            this.FiltroFechaCheckBox.AutoSize = true;
            this.FiltroFechaCheckBox.Location = new System.Drawing.Point(12, 12);
            this.FiltroFechaCheckBox.Name = "FiltroFechaCheckBox";
            this.FiltroFechaCheckBox.Size = new System.Drawing.Size(167, 24);
            this.FiltroFechaCheckBox.TabIndex = 10;
            this.FiltroFechaCheckBox.Text = "Usar Filtro de Fechas";
            this.FiltroFechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtro";
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
            this.esActivoGroupBox.TabIndex = 15;
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
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(211, 68);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(418, 27);
            this.CriterioTextBox.TabIndex = 17;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(774, 25);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(100, 86);
            this.BuscarButton.TabIndex = 14;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImprimirButton.Location = new System.Drawing.Point(12, 563);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(115, 44);
            this.ImprimirButton.TabIndex = 13;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // UsuariosConsultaDataGridView
            // 
            this.UsuariosConsultaDataGridView.AllowUserToAddRows = false;
            this.UsuariosConsultaDataGridView.AllowUserToDeleteRows = false;
            this.UsuariosConsultaDataGridView.AllowUserToOrderColumns = true;
            this.UsuariosConsultaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuariosConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosConsultaDataGridView.Location = new System.Drawing.Point(12, 117);
            this.UsuariosConsultaDataGridView.Name = "UsuariosConsultaDataGridView";
            this.UsuariosConsultaDataGridView.ReadOnly = true;
            this.UsuariosConsultaDataGridView.RowHeadersWidth = 51;
            this.UsuariosConsultaDataGridView.RowTemplate.Height = 29;
            this.UsuariosConsultaDataGridView.Size = new System.Drawing.Size(862, 439);
            this.UsuariosConsultaDataGridView.TabIndex = 12;
            // 
            // FiltroActivoCheckBox
            // 
            this.FiltroActivoCheckBox.AutoSize = true;
            this.FiltroActivoCheckBox.Location = new System.Drawing.Point(12, 39);
            this.FiltroActivoCheckBox.Name = "FiltroActivoCheckBox";
            this.FiltroActivoCheckBox.Size = new System.Drawing.Size(160, 24);
            this.FiltroActivoCheckBox.TabIndex = 18;
            this.FiltroActivoCheckBox.Text = "Usar Filtro es activo";
            this.FiltroActivoCheckBox.UseVisualStyleBackColor = true;
            this.FiltroActivoCheckBox.CheckedChanged += new System.EventHandler(this.FiltroActivoCheckBox_CheckedChanged);
            // 
            // cUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 619);
            this.Controls.Add(this.FiltroActivoCheckBox);
            this.Controls.Add(this.FechaGroupBox);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.FiltroFechaCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.esActivoGroupBox);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.UsuariosConsultaDataGridView);
            this.Name = "cUsuarios";
            this.Text = "Consulta de Usuarios";
            this.Load += new System.EventHandler(this.cUsuarios_Load);
            this.FechaGroupBox.ResumeLayout(false);
            this.FechaGroupBox.PerformLayout();
            this.esActivoGroupBox.ResumeLayout(false);
            this.esActivoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FechaGroupBox;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.CheckBox FiltroFechaCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton TodosRadioButton;
        private System.Windows.Forms.GroupBox esActivoGroupBox;
        private System.Windows.Forms.RadioButton InactivosRadioButton;
        private System.Windows.Forms.RadioButton ActivosRadioButton;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.DataGridView UsuariosConsultaDataGridView;
        private System.Windows.Forms.CheckBox FiltroActivoCheckBox;
    }
}