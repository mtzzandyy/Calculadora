namespace Calculadora
{
    partial class frmCalculadora
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
            label1 = new Label();
            label2 = new Label();
            txtVariableA = new TextBox();
            txtVariableB = new TextBox();
            btnCalcular = new Button();
            btnReset = new Button();
            groupBox1 = new GroupBox();
            RdbSuma = new RadioButton();
            RdbResta = new RadioButton();
            RdbMultiplicacion = new RadioButton();
            RdbDivision = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(93, 47);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 0;
            label1.Text = "Variable A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(93, 226);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 1;
            label2.Text = "Variable B";
            // 
            // txtVariableA
            // 
            txtVariableA.Location = new Point(109, 101);
            txtVariableA.Name = "txtVariableA";
            txtVariableA.Size = new Size(150, 31);
            txtVariableA.TabIndex = 2;
            // 
            // txtVariableB
            // 
            txtVariableB.Location = new Point(109, 280);
            txtVariableB.Name = "txtVariableB";
            txtVariableB.Size = new Size(150, 31);
            txtVariableB.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(255, 192, 192);
            btnCalcular.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = SystemColors.ActiveCaptionText;
            btnCalcular.Location = new Point(346, 41);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 54);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 192, 192);
            btnReset.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(505, 47);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 45);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RdbDivision);
            groupBox1.Controls.Add(RdbMultiplicacion);
            groupBox1.Controls.Add(RdbResta);
            groupBox1.Controls.Add(RdbSuma);
            groupBox1.Location = new Point(397, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 234);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operaciones";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // RdbSuma
            // 
            RdbSuma.AutoSize = true;
            RdbSuma.Location = new Point(29, 45);
            RdbSuma.Name = "RdbSuma";
            RdbSuma.Size = new Size(82, 29);
            RdbSuma.TabIndex = 0;
            RdbSuma.TabStop = true;
            RdbSuma.Text = "Suma";
            RdbSuma.UseVisualStyleBackColor = true;
            // 
            // RdbResta
            // 
            RdbResta.AutoSize = true;
            RdbResta.Location = new Point(29, 95);
            RdbResta.Name = "RdbResta";
            RdbResta.Size = new Size(79, 29);
            RdbResta.TabIndex = 1;
            RdbResta.TabStop = true;
            RdbResta.Text = "Resta";
            RdbResta.UseVisualStyleBackColor = true;
            // 
            // RdbMultiplicacion
            // 
            RdbMultiplicacion.AutoSize = true;
            RdbMultiplicacion.Location = new Point(29, 139);
            RdbMultiplicacion.Name = "RdbMultiplicacion";
            RdbMultiplicacion.Size = new Size(146, 29);
            RdbMultiplicacion.TabIndex = 2;
            RdbMultiplicacion.TabStop = true;
            RdbMultiplicacion.Text = "Multiplicacion";
            RdbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // RdbDivision
            // 
            RdbDivision.AutoSize = true;
            RdbDivision.Location = new Point(29, 183);
            RdbDivision.Name = "RdbDivision";
            RdbDivision.Size = new Size(100, 29);
            RdbDivision.TabIndex = 3;
            RdbDivision.TabStop = true;
            RdbDivision.Text = "Division";
            RdbDivision.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnReset);
            Controls.Add(btnCalcular);
            Controls.Add(txtVariableB);
            Controls.Add(txtVariableA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCalculadora";
            Text = "Calculadora";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtVariableA;
        private TextBox txtVariableB;
        private Button btnCalcular;
        private Button btnReset;
        private GroupBox groupBox1;
        private RadioButton RdbResta;
        private RadioButton RdbSuma;
        private RadioButton RdbDivision;
        private RadioButton RdbMultiplicacion;
    }
}