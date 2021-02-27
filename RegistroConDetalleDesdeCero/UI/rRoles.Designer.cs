﻿
namespace RegistroConDetalleDesdeCero.UI
{
    partial class rRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rRoles));
            this.RolLabel = new System.Windows.Forms.Label();
            this.RolIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuscarRolButton = new System.Windows.Forms.Button();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.FechaCreacionLabel = new System.Windows.Forms.Label();
            this.CreacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NuevoRolButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.DetalleGroupBox = new System.Windows.Forms.GroupBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.RolesDataGridView = new System.Windows.Forms.DataGridView();
            this.EsAsignadoCheckBox = new System.Windows.Forms.CheckBox();
            this.PermisoIdComboBox = new System.Windows.Forms.ComboBox();
            this.PermisoIdLabel = new System.Windows.Forms.Label();
            this.RolErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RolIdNumericUpDown)).BeginInit();
            this.DetalleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // RolLabel
            // 
            this.RolLabel.AutoSize = true;
            this.RolLabel.Location = new System.Drawing.Point(17, 24);
            this.RolLabel.Name = "RolLabel";
            this.RolLabel.Size = new System.Drawing.Size(50, 20);
            this.RolLabel.TabIndex = 0;
            this.RolLabel.Text = "Rol ID";
            // 
            // RolIdNumericUpDown
            // 
            this.RolIdNumericUpDown.Location = new System.Drawing.Point(221, 22);
            this.RolIdNumericUpDown.Name = "RolIdNumericUpDown";
            this.RolIdNumericUpDown.Size = new System.Drawing.Size(76, 27);
            this.RolIdNumericUpDown.TabIndex = 1;
            // 
            // BuscarRolButton
            // 
            this.BuscarRolButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarRolButton.Image")));
            this.BuscarRolButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarRolButton.Location = new System.Drawing.Point(307, 21);
            this.BuscarRolButton.Name = "BuscarRolButton";
            this.BuscarRolButton.Size = new System.Drawing.Size(92, 28);
            this.BuscarRolButton.TabIndex = 2;
            this.BuscarRolButton.Text = "Buscar";
            this.BuscarRolButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarRolButton.UseVisualStyleBackColor = true;
            this.BuscarRolButton.Click += new System.EventHandler(this.BuscarRolButton_Click_1);
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(16, 66);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(87, 20);
            this.DescripcionLabel.TabIndex = 3;
            this.DescripcionLabel.Text = "Descripcion";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(221, 63);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(178, 27);
            this.DescripcionTextBox.TabIndex = 4;
            // 
            // FechaCreacionLabel
            // 
            this.FechaCreacionLabel.AutoSize = true;
            this.FechaCreacionLabel.Location = new System.Drawing.Point(16, 111);
            this.FechaCreacionLabel.Name = "FechaCreacionLabel";
            this.FechaCreacionLabel.Size = new System.Drawing.Size(109, 20);
            this.FechaCreacionLabel.TabIndex = 5;
            this.FechaCreacionLabel.Text = "Fecha Creación";
            // 
            // CreacionDateTimePicker
            // 
            this.CreacionDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.CreacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CreacionDateTimePicker.Location = new System.Drawing.Point(221, 106);
            this.CreacionDateTimePicker.Name = "CreacionDateTimePicker";
            this.CreacionDateTimePicker.Size = new System.Drawing.Size(178, 27);
            this.CreacionDateTimePicker.TabIndex = 6;
            // 
            // NuevoRolButton
            // 
            this.NuevoRolButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoRolButton.Image")));
            this.NuevoRolButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoRolButton.Location = new System.Drawing.Point(18, 509);
            this.NuevoRolButton.Name = "NuevoRolButton";
            this.NuevoRolButton.Size = new System.Drawing.Size(90, 53);
            this.NuevoRolButton.TabIndex = 7;
            this.NuevoRolButton.Text = "Nuevo";
            this.NuevoRolButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoRolButton.UseVisualStyleBackColor = true;
            this.NuevoRolButton.Click += new System.EventHandler(this.NuevoRolButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(163, 509);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(90, 53);
            this.GuardarButton.TabIndex = 8;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(309, 509);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(90, 53);
            this.EliminarButton.TabIndex = 9;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // DetalleGroupBox
            // 
            this.DetalleGroupBox.Controls.Add(this.AgregarButton);
            this.DetalleGroupBox.Controls.Add(this.RemoverButton);
            this.DetalleGroupBox.Controls.Add(this.RolesDataGridView);
            this.DetalleGroupBox.Controls.Add(this.EsAsignadoCheckBox);
            this.DetalleGroupBox.Controls.Add(this.PermisoIdComboBox);
            this.DetalleGroupBox.Controls.Add(this.PermisoIdLabel);
            this.DetalleGroupBox.Location = new System.Drawing.Point(17, 163);
            this.DetalleGroupBox.Name = "DetalleGroupBox";
            this.DetalleGroupBox.Size = new System.Drawing.Size(611, 328);
            this.DetalleGroupBox.TabIndex = 10;
            this.DetalleGroupBox.TabStop = false;
            this.DetalleGroupBox.Text = "Detalle de rol";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(511, 34);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(92, 28);
            this.AgregarButton.TabIndex = 12;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click_1);
            // 
            // RemoverButton
            // 
            this.RemoverButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoverButton.Image")));
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(4, 295);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(92, 28);
            this.RemoverButton.TabIndex = 11;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click_1);
            // 
            // RolesDataGridView
            // 
            this.RolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolesDataGridView.Location = new System.Drawing.Point(6, 74);
            this.RolesDataGridView.Name = "RolesDataGridView";
            this.RolesDataGridView.RowHeadersWidth = 51;
            this.RolesDataGridView.RowTemplate.Height = 29;
            this.RolesDataGridView.Size = new System.Drawing.Size(597, 219);
            this.RolesDataGridView.TabIndex = 4;
            // 
            // EsAsignadoCheckBox
            // 
            this.EsAsignadoCheckBox.AutoSize = true;
            this.EsAsignadoCheckBox.Location = new System.Drawing.Point(214, 38);
            this.EsAsignadoCheckBox.Name = "EsAsignadoCheckBox";
            this.EsAsignadoCheckBox.Size = new System.Drawing.Size(94, 24);
            this.EsAsignadoCheckBox.TabIndex = 3;
            this.EsAsignadoCheckBox.Text = "Asignado";
            this.EsAsignadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // PermisoIdComboBox
            // 
            this.PermisoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PermisoIdComboBox.FormattingEnabled = true;
            this.PermisoIdComboBox.Location = new System.Drawing.Point(92, 34);
            this.PermisoIdComboBox.Name = "PermisoIdComboBox";
            this.PermisoIdComboBox.Size = new System.Drawing.Size(116, 28);
            this.PermisoIdComboBox.TabIndex = 2;
            // 
            // PermisoIdLabel
            // 
            this.PermisoIdLabel.AutoSize = true;
            this.PermisoIdLabel.Location = new System.Drawing.Point(6, 38);
            this.PermisoIdLabel.Name = "PermisoIdLabel";
            this.PermisoIdLabel.Size = new System.Drawing.Size(80, 20);
            this.PermisoIdLabel.TabIndex = 1;
            this.PermisoIdLabel.Text = "Permiso ID";
            // 
            // RolErrorProvider
            // 
            this.RolErrorProvider.ContainerControl = this;
            // 
            // rRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 578);
            this.Controls.Add(this.DetalleGroupBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoRolButton);
            this.Controls.Add(this.CreacionDateTimePicker);
            this.Controls.Add(this.FechaCreacionLabel);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.BuscarRolButton);
            this.Controls.Add(this.RolIdNumericUpDown);
            this.Controls.Add(this.RolLabel);
            this.Name = "rRoles";
            this.Text = "rRoles";
            this.Load += new System.EventHandler(this.rRoles_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.RolIdNumericUpDown)).EndInit();
            this.DetalleGroupBox.ResumeLayout(false);
            this.DetalleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RolLabel;
        private System.Windows.Forms.NumericUpDown RolIdNumericUpDown;
        private System.Windows.Forms.Button BuscarRolButton;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label FechaCreacionLabel;
        private System.Windows.Forms.DateTimePicker CreacionDateTimePicker;
        private System.Windows.Forms.Button NuevoRolButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.GroupBox DetalleGroupBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.DataGridView RolesDataGridView;
        private System.Windows.Forms.CheckBox EsAsignadoCheckBox;
        private System.Windows.Forms.ComboBox PermisoIdComboBox;
        private System.Windows.Forms.Label PermisoIdLabel;
        private System.Windows.Forms.ErrorProvider RolErrorProvider;
    }
}