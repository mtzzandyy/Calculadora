using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class frmEditor : Form
    {
        bool saved = false;
        string path = " ";
        string texto;
        public frmEditor()
        {
            InitializeComponent();
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdEditor.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofdEditor.FileName))
                {
                    rtbEditor.Text = File.ReadAllText(ofdEditor.FileName);
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            path = " ";
            saved = false;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                Guardar();
                saved = true;
            }
            else
            {
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void Guardar()
        {
            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
                path = sfdEditor.FileName;
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.WriteLine(rtbEditor.Text);
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
            texto = rtbEditor.Text;
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries); 

            // TsStatus.Text = $"{palabras.Length} Palabras"; (el signo de pesos hace la funcion del ToString())
            TsStatus.Text = palabras.Length.ToString() + "Palabras";
        }

        private void TsStatus_Click(object sender, EventArgs e)
        {
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string[] parrafos = texto.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);

            MessageBox.Show("Estadisticas: \n\nPalabras: " + palabras.Length + "\nLetras: " + texto.Length.ToString() 
                + "\nParrafos: " + parrafos.Length.ToString(), "Contador de Palabras");
        }
    }
}
