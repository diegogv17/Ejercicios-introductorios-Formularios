namespace Ejercicios_introductorios
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
            Mensaje = new Label();
            Saludar = new Button();
            SuspendLayout();
            // 
            // Mensaje
            // 
            Mensaje.AutoSize = true;
            Mensaje.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Mensaje.Location = new Point(101, 23);
            Mensaje.Name = "Mensaje";
            Mensaje.Size = new Size(270, 37);
            Mensaje.TabIndex = 0;
            Mensaje.Text = "PRESS THE BOTTON";
            Mensaje.Click += label1_Click;
            // 
            // Saludar
            // 
            Saludar.Font = new Font("Segoe UI", 15F);
            Saludar.Location = new Point(84, 98);
            Saludar.Name = "Saludar";
            Saludar.Size = new Size(307, 64);
            Saludar.TabIndex = 1;
            Saludar.Text = "SEE THE MAGIC";
            Saludar.UseVisualStyleBackColor = true;
            Saludar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 222);
            Controls.Add(Saludar);
            Controls.Add(Mensaje);
            Name = "Form1";
            Text = "Hello!";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Mensaje;
        private Button Saludar;
    }
}
