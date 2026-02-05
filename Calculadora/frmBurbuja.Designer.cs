namespace Calculadora
{
    partial class frmBurbuja
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
            components = new System.ComponentModel.Container();
            dgvDesordenamiento = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            dgvOrdenamiento = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            btnOrdenar = new Button();
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)dgvDesordenamiento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenamiento).BeginInit();
            SuspendLayout();
            // 
            // dgvDesordenamiento
            // 
            dgvDesordenamiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDesordenamiento.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dgvDesordenamiento.Location = new Point(62, 69);
            dgvDesordenamiento.Name = "dgvDesordenamiento";
            dgvDesordenamiento.RowHeadersWidth = 62;
            dgvDesordenamiento.Size = new Size(266, 225);
            dgvDesordenamiento.TabIndex = 0;
            dgvDesordenamiento.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Desorden";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // dgvOrdenamiento
            // 
            dgvOrdenamiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenamiento.Columns.AddRange(new DataGridViewColumn[] { Column2 });
            dgvOrdenamiento.Location = new Point(344, 69);
            dgvOrdenamiento.Name = "dgvOrdenamiento";
            dgvOrdenamiento.RowHeadersWidth = 62;
            dgvOrdenamiento.Size = new Size(280, 225);
            dgvOrdenamiento.TabIndex = 1;
            // 
            // Column2
            // 
            Column2.HeaderText = "Orden";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(273, 357);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(112, 34);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // frmBurbuja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 725);
            Controls.Add(btnOrdenar);
            Controls.Add(dgvOrdenamiento);
            Controls.Add(dgvDesordenamiento);
            Name = "frmBurbuja";
            Text = "frmBurbuja";
            ((System.ComponentModel.ISupportInitialize)dgvDesordenamiento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenamiento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDesordenamiento;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dgvOrdenamiento;
        private DataGridViewTextBoxColumn Column2;
        private Button btnOrdenar;
        private NotifyIcon notifyIcon1;
    }
}