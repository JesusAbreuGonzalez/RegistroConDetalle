using RegistroConDetalleDesdeCero.BLL;
using RegistroConDetalleDesdeCero.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegistroConDetalleDesdeCero.UI
{
    public partial class rRoles : Form
    {
        public List<RolesDetalle> rolDetalle { get; set; } //Almacena la lista del detalle
        public List<RolesDetalle> detalle { get; set; } //Muestra el detalle agregado en el boton agregar
        public rRoles()
        {
            InitializeComponent();
            this.rolDetalle = new List<RolesDetalle>();
        }

        private void LlenarGrid()
        {
            RolesDataGridView.DataSource = null;
            RolesDataGridView.DataSource = rolDetalle;
        }

        private void AgregarFila()
        {
            RolesDataGridView.DataSource = null;
            RolesDataGridView.DataSource = detalle;
        }

        private void Limpiar()
        {
            RolIdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
            if(detalle != null)
                detalle.Clear();
            RolesDataGridView.DataSource = null;
        }


        //Esta funcion sirve para verificar que no falte ningun campo obligatorio por llenar
        private bool Validar()
        {
            bool paso = true;

            if (DescripcionTextBox.Text == "")
            {
                RolErrorProvider.SetError(DescripcionTextBox, "Campo obligatorio");
                paso = false;
            }

            return paso;
        }


        private Roles LlenaClase()
        {
            Roles roles = new Roles();
            roles.RolId = (int)RolIdNumericUpDown.Value;
            roles.Descripcion = DescripcionTextBox.Text;
            roles.FechaCreacion = DateTime.Now;
            roles.RolesDetalle = this.rolDetalle;
            roles.esActivo = ActivoCheckBox.Checked;
            LlenarGrid();

            return roles;
        }

        private void LLenaCampos(Roles roles)
        {
            RolIdNumericUpDown.Value = roles.RolId;
            DescripcionTextBox.Text = roles.Descripcion;
            this.rolDetalle = roles.RolesDetalle;
            ActivoCheckBox.Checked = roles.esActivo;
            LlenarGrid();
        }

        //Este es el evento del boton Nuevo, sirve para limpiar los campos y errores

        private void NuevoRolButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //Este es el evento del boton Buscar, sirve para buscar los datos correspondientes al id ingresado
        private void BuscarRolButton_Click_1(object sender, EventArgs e)
        {
            var roles = new Roles();
            int id = (int)RolIdNumericUpDown.Value;

            Limpiar();
            roles = RolesBLL.Buscar(id);
            if (roles != null)
            {
                LLenaCampos(roles);
            }
            else
            {
                MessageBox.Show("Rol no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Este es el evento de boton guardar y sirve para almacenar o modificar los datos de los roles que se registren
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Roles roles;

            if (!Validar())
                return;
            roles = LlenaClase();

            var paso = RolesBLL.Guardar(roles);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("El usuario ha sido guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("El usuario no ha sido guardado con exito", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //Este es el evento del boton eliminar y sirve para eliminar los datos correspondiente al id ingresado
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = (int)RolIdNumericUpDown.Value;
            RolErrorProvider.Clear();

            if (RolesBLL.Eliminar(id))
            {
                MessageBox.Show("El rol ha sido eliminado", "Logrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                RolErrorProvider.SetError(RolIdNumericUpDown, "Este Id no existe en la base de datos");
        }

        private void AgregarButton_Click_1(object sender, EventArgs e)
        {
            
            if (RolesDataGridView.DataSource != null)
                this.rolDetalle = (List<RolesDetalle>)RolesDataGridView.DataSource;

            this.rolDetalle.Add(
                new RolesDetalle(){
                    RolId = (int)RolIdNumericUpDown.Value,
                    PermisoId = Convert.ToInt32(PermisoIdComboBox.Text),
                    EsAsignado = EsAsignadoCheckBox.Checked
                });

            detalle = rolDetalle;
            AgregarFila();
            EsAsignadoCheckBox.Checked = false;
        }

        //Llenamos el ComboBox de permio ID, usando el metodo GetPermisos
        private void rRoles_Load_1(object sender, EventArgs e)
        {

            PermisoIdComboBox.DataSource = PermisosBLL.GetPermisos();
            PermisoIdComboBox.DisplayMember = "PermisoId";
            PermisoIdComboBox.ValueMember = "PermisoId";
        }

        private void RemoverButton_Click_1(object sender, EventArgs e)
        {
            if (RolesDataGridView.Rows.Count > 0 && RolesDataGridView.CurrentRow != null)
            {
                rolDetalle.RemoveAt(RolesDataGridView.CurrentRow.Index);
                LlenarGrid();
            }
        }
    }
}
