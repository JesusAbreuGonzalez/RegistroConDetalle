﻿using RegistroConDetalleDesdeCero.BLL;
using RegistroConDetalleDesdeCero.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroConDetalleDesdeCero.UI.Consultas
{
    public partial class cUsuarios : Form
    {
        List<Usuarios> lista = new List<Usuarios>();
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
                        
            //Si algun radioButton se encuentra seleccionado
            if(FiltroActivoCheckBox.Checked)
            {
                if (TodosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(CriterioTextBox.Text));
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text.ToUpper()) || r.Alias.Contains(CriterioTextBox.Text.ToLower()));
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text.ToUpper()) || r.Nombres.Contains(CriterioTextBox.Text.ToLower()));
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text.ToUpper()) || r.Email.Contains(CriterioTextBox.Text.ToLower()));
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text));
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = UsuariosBLL.GetList(r => true);
                }
                else if (ActivosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(CriterioTextBox.Text) && r.Activo);
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => (r.Alias.Contains(CriterioTextBox.Text.ToUpper()) && r.Activo) || (r.Alias.Contains(CriterioTextBox.Text.ToLower()) && r.Activo));
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => (r.Nombres.Contains(CriterioTextBox.Text.ToUpper()) && r.Activo) || (r.Nombres.Contains(CriterioTextBox.Text.ToLower()) && r.Activo));
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => (r.Email.Contains(CriterioTextBox.Text.ToUpper()) && r.Activo) || (r.Email.Contains(CriterioTextBox.Text.ToLower()) && r.Activo));
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = UsuariosBLL.GetList(r => true && r.Activo);
                }
                else if (InactivosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(CriterioTextBox.Text) && !r.Activo);
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => (r.Alias.Contains(CriterioTextBox.Text.ToUpper()) && !r.Activo) || (r.Alias.Contains(CriterioTextBox.Text.ToLower()) && !r.Activo));
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => (r.Nombres.Contains(CriterioTextBox.Text.ToUpper()) && !r.Activo) || (r.Nombres.Contains(CriterioTextBox.Text.ToLower()) && !r.Activo));
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => (r.Email.Contains(CriterioTextBox.Text.ToUpper()) && !r.Activo) || (r.Email.Contains(CriterioTextBox.Text.ToLower()) && !r.Activo));
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && !r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = UsuariosBLL.GetList(r => true && !r.Activo);
                }
            }
            else
            {
                //si CriterioTextBox no se encuentra vacio
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //UsuarioId
                            lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(CriterioTextBox.Text));
                            break;
                        case 1: //Alias
                            lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text.ToUpper()) || r.Alias.Contains(CriterioTextBox.Text.ToLower()));
                            break;
                        case 2: //Nombres
                            lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text.ToUpper()) || r.Nombres.Contains(CriterioTextBox.Text.ToLower()));
                            break;
                        case 3: //Email
                            lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text.ToUpper()) || r.Email.Contains(CriterioTextBox.Text.ToLower()));
                            break;
                        case 4: //RolId
                            lista = UsuariosBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text));
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    lista = UsuariosBLL.GetList(r => true);
                }
            }


            //Si usarFecha se encuentra cortejado
            if (FiltroFechaCheckBox.Checked)
            {
                lista = UsuariosBLL.GetList(l => l.FechaIngreso >= DesdeDateTimePicker.Value && l.FechaIngreso <= HastaDateTimePicker.Value);
            }


            UsuariosConsultaDataGridView.DataSource = null;
            UsuariosConsultaDataGridView.DataSource = lista;
        }

        private void cUsuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void FiltroActivoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FiltroActivoCheckBox.Checked)
            {
                esActivoGroupBox.Enabled = true;
            }
            else
            {
                esActivoGroupBox.Enabled = false;
            }
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            if (lista.Count == 0)
            {
                MessageBox.Show("No hay datos a imprimir");
                return;
            }
            
            
        }
    }
}
