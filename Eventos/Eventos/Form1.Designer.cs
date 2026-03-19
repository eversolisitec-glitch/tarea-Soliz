namespace Eventos
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
            btnsaludo = new Button();
            lblmensaje = new Label();
            btndespedida = new Button();
            btnsalir = new Button();
            SuspendLayout();
            // 
            // btnsaludo
            // 
            btnsaludo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsaludo.Location = new Point(215, 61);
            btnsaludo.Name = "btnsaludo";
            btnsaludo.Size = new Size(109, 34);
            btnsaludo.TabIndex = 0;
            btnsaludo.Text = "Saludo";
            btnsaludo.UseVisualStyleBackColor = true;
            btnsaludo.Click += btnsaludo_Click;
            // 
            // lblmensaje
            // 
            lblmensaje.AutoSize = true;
            lblmensaje.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmensaje.Location = new Point(50, 61);
            lblmensaje.Name = "lblmensaje";
            lblmensaje.Size = new Size(65, 25);
            lblmensaje.TabIndex = 1;
            lblmensaje.Text = "label1";
            // 
            // btndespedida
            // 
            btndespedida.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndespedida.Location = new Point(204, 119);
            btndespedida.Name = "btndespedida";
            btndespedida.Size = new Size(132, 34);
            btndespedida.TabIndex = 2;
            btndespedida.Text = "Despedida";
            btndespedida.UseVisualStyleBackColor = true;
            btndespedida.Click += btndespedida_Click;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = SystemColors.ControlLight;
            btnsalir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalir.ForeColor = Color.Red;
            btnsalir.Location = new Point(141, 197);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(104, 37);
            btnsalir.TabIndex = 3;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 269);
            Controls.Add(btnsalir);
            Controls.Add(btndespedida);
            Controls.Add(lblmensaje);
            Controls.Add(btnsaludo);
            Name = "Form1";
            Text = "Eventos 01";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsaludo;
        private Label lblmensaje;
        private Button btndespedida;
        private Button btnsalir;
    }
}
