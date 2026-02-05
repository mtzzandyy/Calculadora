namespace Calculadora.Formularios
{
    partial class frmRegistroAlumnos
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnRegistrar = new Button();
            dtpFecha = new DateTimePicker();
            label3 = new Label();
            txtBoxApellido = new TextBox();
            txtBoxNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            dgvPersonas = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(24, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(779, 557);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRegistrar);
            tabPage1.Controls.Add(dtpFecha);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtBoxApellido);
            tabPage1.Controls.Add(txtBoxNombre);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(771, 519);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(462, 330);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(54, 333);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(300, 31);
            dtpFecha.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 288);
            label3.Name = "label3";
            label3.Size = new Size(177, 25);
            label3.TabIndex = 4;
            label3.Text = "Fecha de Nacimiento";
            // 
            // txtBoxApellido
            // 
            txtBoxApellido.Location = new Point(56, 197);
            txtBoxApellido.Name = "txtBoxApellido";
            txtBoxApellido.Size = new Size(150, 31);
            txtBoxApellido.TabIndex = 3;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(54, 78);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(150, 31);
            txtBoxNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 151);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 26);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvPersonas);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(771, 519);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(29, 41);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 62;
            dgvPersonas.Size = new Size(694, 433);
            dgvPersonas.TabIndex = 0;
            // 
            // frmRegistroAlumnos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 581);
            Controls.Add(tabControl1);
            Name = "frmRegistroAlumnos";
            Text = "frmRegistro";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Button btnRegistrar;
        private DateTimePicker dtpFecha;
        private Label label3;
        private TextBox txtBoxApellido;
        private TextBox txtBoxNombre;
        private DataGridView dgvPersonas;
    }
}