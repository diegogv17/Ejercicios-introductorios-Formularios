namespace Calculadora
{
    partial class Calculadora
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
            txtNumero1 = new Label();
            txtNumero3 = new Label();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            btnAddUp = new Button();
            btnToSubtract = new Button();
            btnMultiply = new Button();
            btnDivided = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtNumero1
            // 
            txtNumero1.AutoSize = true;
            txtNumero1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumero1.Location = new Point(60, 33);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(107, 25);
            txtNumero1.TabIndex = 0;
            txtNumero1.Text = "Number 1:";
            txtNumero1.Click += label1_Click;
            // 
            // txtNumero3
            // 
            txtNumero3.AutoSize = true;
            txtNumero3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumero3.Location = new Point(60, 127);
            txtNumero3.Name = "txtNumero3";
            txtNumero3.Size = new Size(107, 25);
            txtNumero3.TabIndex = 1;
            txtNumero3.Text = "Number 2:";
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(74, 76);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(159, 23);
            txtNumber1.TabIndex = 2;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(74, 159);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(163, 23);
            txtNumber2.TabIndex = 3;
            // 
            // btnAddUp
            // 
            btnAddUp.Location = new Point(74, 220);
            btnAddUp.Name = "btnAddUp";
            btnAddUp.Size = new Size(80, 35);
            btnAddUp.TabIndex = 4;
            btnAddUp.Text = "Add Up";
            btnAddUp.UseVisualStyleBackColor = true;
            btnAddUp.Click += btnAddUp_Click;
            // 
            // btnToSubtract
            // 
            btnToSubtract.Location = new Point(198, 224);
            btnToSubtract.Name = "btnToSubtract";
            btnToSubtract.Size = new Size(78, 28);
            btnToSubtract.TabIndex = 5;
            btnToSubtract.Text = "To Subtract";
            btnToSubtract.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(314, 222);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(112, 28);
            btnMultiply.TabIndex = 6;
            btnMultiply.Text = "Multiply";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnDivided
            // 
            btnDivided.Location = new Point(479, 224);
            btnDivided.Name = "btnDivided";
            btnDivided.Size = new Size(75, 23);
            btnDivided.TabIndex = 7;
            btnDivided.Text = "Divided";
            btnDivided.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(289, 293);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(84, 32);
            lblResult.TabIndex = 8;
            lblResult.Text = "Result";
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 374);
            Controls.Add(lblResult);
            Controls.Add(btnDivided);
            Controls.Add(btnMultiply);
            Controls.Add(btnToSubtract);
            Controls.Add(btnAddUp);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(txtNumero3);
            Controls.Add(txtNumero1);
            Name = "Calculadora";
            Text = "Calculadora";
            Load += Calculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNumero1;
        private Label txtNumero3;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Button btnAddUp;
        private Button btnToSubtract;
        private Button btnMultiply;
        private Button btnDivided;
        private Label lblResult;
    }
}
