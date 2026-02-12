using Microsoft.VisualBasic; //para usar InputBox
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media; //para usar SoundPlayer
using CSCore.SoundOut; //para usar AudioPlayer

namespace Calculadora.Formularios
{
    public partial class frmTemporizadores : Form
    {
        String alarma1 = "";
        public frmTemporizadores()
        {
            InitializeComponent();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            if (lblHora.Text == alarma1)
            {
                SoundPlayer alarma = new SoundPlayer(@"C:");
            }
        }

        private void alarma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarma1 = Interaction.InputBox("Ingrese la hora: ", "Sistema", "00:00:00 x.x");
        }
    }
}
