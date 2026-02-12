using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class frmRegistroAlumnos : Form
    {
        List<Persona> persona = new List<Persona>();
        public frmRegistroAlumnos()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            persona.Add(new Persona()
            {
                Nombre = txtBoxNombre.Text,
                Apellido = txtBoxApellido.Text,
                Fecha = dtpFecha.Value
            });

            MessageBox.Show("Datos registrados correctamente", "Sistema");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dgvPersonas.DataSource = null;
                dgvPersonas.DataSource = persona;
                verificarRegistros();
            }
        }

        private void verificarRegistros()
        {
            if (persona.Count == 0)

                btnEliminar.Enabled = false;
            else
                btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            persona.RemoveAt(dgvPersonas.CurrentCell.RowIndex);
            dgvPersonas.DataSource = null; //limpiar el datagridview
            dgvPersonas.DataSource = persona; //volver a llenar el datagridview
            verificarRegistros(); //verificar si habilito el boton
        }
    }
}
