namespace WinFormsApp3
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
            lblnombre = new Label();
            txtnombre = new TextBox();
            lblmensaje = new Label();
            btnsaludo = new Button();
            btnsalir = new Button();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(52, 42);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(91, 25);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(170, 44);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(186, 23);
            txtnombre.TabIndex = 1;
            // 
            // lblmensaje
            // 
            lblmensaje.AutoSize = true;
            lblmensaje.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmensaje.Location = new Point(58, 185);
            lblmensaje.Name = "lblmensaje";
            lblmensaje.Size = new Size(85, 25);
            lblmensaje.TabIndex = 2;
            lblmensaje.Text = "Mensaje";
            lblmensaje.Click += lblmensaje_Click;
            // 
            // btnsaludo
            // 
            btnsaludo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsaludo.Location = new Point(192, 108);
            btnsaludo.Name = "btnsaludo";
            btnsaludo.Size = new Size(113, 33);
            btnsaludo.TabIndex = 3;
            btnsaludo.Text = "Saludo";
            btnsaludo.UseVisualStyleBackColor = true;
            btnsaludo.Click += btnsaludo_Click;
            // 
            // btnsalir
            // 
            btnsalir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalir.Location = new Point(295, 243);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(113, 33);
            btnsalir.TabIndex = 4;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 288);
            Controls.Add(btnsalir);
            Controls.Add(btnsaludo);
            Controls.Add(lblmensaje);
            Controls.Add(txtnombre);
            Controls.Add(lblnombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnombre;
        private TextBox txtnombre;
        private Label lblmensaje;
        private Button btnsaludo;
        private Button btnsalir;
    }
}
