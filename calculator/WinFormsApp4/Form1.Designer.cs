namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblA = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            lblB = new Label();
            lblresultado = new Label();
            btnsuma = new Button();
            btnresta = new Button();
            btnsalir = new Button();
            btnmultiplicasion = new Button();
            btndivicion = new Button();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblA.Location = new Point(19, 49);
            lblA.Margin = new Padding(5, 0, 5, 0);
            lblA.Name = "lblA";
            lblA.Size = new Size(30, 25);
            lblA.TabIndex = 0;
            lblA.Text = "A:";
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtA.Location = new Point(85, 44);
            txtA.Margin = new Padding(5);
            txtA.Name = "txtA";
            txtA.Size = new Size(243, 33);
            txtA.TabIndex = 1;
            txtA.TextAlign = HorizontalAlignment.Right;
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtB.Location = new Point(85, 124);
            txtB.Margin = new Padding(5);
            txtB.Name = "txtB";
            txtB.Size = new Size(243, 33);
            txtB.TabIndex = 2;
            txtB.TextAlign = HorizontalAlignment.Right;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblB.Location = new Point(19, 138);
            lblB.Margin = new Padding(5, 0, 5, 0);
            lblB.Name = "lblB";
            lblB.Size = new Size(29, 25);
            lblB.TabIndex = 3;
            lblB.Text = "B:";
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblresultado.Location = new Point(167, 211);
            lblresultado.Margin = new Padding(5, 0, 5, 0);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(65, 25);
            lblresultado.TabIndex = 4;
            lblresultado.Text = "label1";
            // 
            // btnsuma
            // 
            btnsuma.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnsuma.Location = new Point(362, 36);
            btnsuma.Margin = new Padding(5);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(49, 50);
            btnsuma.TabIndex = 5;
            btnsuma.Text = "+";
            btnsuma.UseVisualStyleBackColor = true;
            btnsuma.Click += btnsuma_Click;
            // 
            // btnresta
            // 
            btnresta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnresta.Location = new Point(360, 116);
            btnresta.Margin = new Padding(5);
            btnresta.Name = "btnresta";
            btnresta.Size = new Size(50, 50);
            btnresta.TabIndex = 6;
            btnresta.Text = "-";
            btnresta.UseVisualStyleBackColor = true;
            btnresta.Click += btnresta_Click;
            // 
            // btnsalir
            // 
            btnsalir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnsalir.Location = new Point(362, 240);
            btnsalir.Margin = new Padding(5);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(130, 50);
            btnsalir.TabIndex = 7;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnmultiplicasion
            // 
            btnmultiplicasion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnmultiplicasion.Location = new Point(439, 116);
            btnmultiplicasion.Margin = new Padding(5);
            btnmultiplicasion.Name = "btnmultiplicasion";
            btnmultiplicasion.Size = new Size(50, 50);
            btnmultiplicasion.TabIndex = 8;
            btnmultiplicasion.Text = "*";
            btnmultiplicasion.UseVisualStyleBackColor = true;
            btnmultiplicasion.Click += btnmultiplicasion_Click;
            // 
            // btndivicion
            // 
            btndivicion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btndivicion.Location = new Point(439, 36);
            btndivicion.Margin = new Padding(5);
            btndivicion.Name = "btndivicion";
            btndivicion.Size = new Size(50, 50);
            btndivicion.TabIndex = 9;
            btndivicion.Text = "/";
            btndivicion.UseVisualStyleBackColor = true;
            btndivicion.Click += btndivicion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 314);
            Controls.Add(btndivicion);
            Controls.Add(btnmultiplicasion);
            Controls.Add(btnsalir);
            Controls.Add(btnresta);
            Controls.Add(btnsuma);
            Controls.Add(lblresultado);
            Controls.Add(lblB);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private TextBox txtA;
        private TextBox txtB;
        private Label lblB;
        private Label lblresultado;
        private Button btnsuma;
        private Button btnresta;
        private Button btnsalir;
        private Button btnmultiplicasion;
        private Button btndivicion;
    }
}
