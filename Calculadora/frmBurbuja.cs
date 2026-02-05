using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmBurbuja : Form
    {
        public frmBurbuja()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Ordenamiento ordenamiento = new Ordenamiento();
            int[] ordenado = new int[dgvDesordenamiento.RowCount-1];
            for (int i = 0; i < dgvDesordenamiento.RowCount; i++)
            {
                ordenado[i] = Convert.ToInt32(dgvOrdenamiento.Rows[i].Cells[0].Value);
            }

            ordenado = ordenamiento.Burbuja(ordenado);
        }
    }
}
