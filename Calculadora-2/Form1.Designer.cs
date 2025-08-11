namespace Calculadora_2
{
    partial class Fcalculator
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
            lblNumber1 = new Label();
            lblNumber2 = new Label();
            TxtNumber1 = new TextBox();
            TxtNumber2 = new TextBox();
            BtnAddUp = new Button();
            BtnToDeduct = new Button();
            BtnToMultiply = new Button();
            BtnDivided = new Button();
            SuspendLayout();
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumber1.Location = new Point(94, 107);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(102, 25);
            lblNumber1.TabIndex = 0;
            lblNumber1.Text = "Number1:";
            lblNumber1.Click += lblNumber_Click;
            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumber2.Location = new Point(89, 195);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(102, 25);
            lblNumber2.TabIndex = 1;
            lblNumber2.Text = "Number2:";
            // 
            // TxtNumber1
            // 
            TxtNumber1.Location = new Point(241, 112);
            TxtNumber1.Name = "TxtNumber1";
            TxtNumber1.Size = new Size(299, 23);
            TxtNumber1.TabIndex = 2;
            TxtNumber1.TextChanged += textBox1_TextChanged;
            // 
            // TxtNumber2
            // 
            TxtNumber2.Location = new Point(241, 200);
            TxtNumber2.Name = "TxtNumber2";
            TxtNumber2.Size = new Size(299, 23);
            TxtNumber2.TabIndex = 3;
            TxtNumber2.TextChanged += textBox2_TextChanged;
            // 
            // BtnAddUp
            // 
            BtnAddUp.Location = new Point(94, 271);
            BtnAddUp.Name = "BtnAddUp";
            BtnAddUp.Size = new Size(77, 29);
            BtnAddUp.TabIndex = 4;
            BtnAddUp.Text = "Add Up";
            BtnAddUp.UseVisualStyleBackColor = true;
            BtnAddUp.Click += BtnAddUp_Click;
            // 
            // BtnToDeduct
            // 
            BtnToDeduct.Location = new Point(195, 271);
            BtnToDeduct.Name = "BtnToDeduct";
            BtnToDeduct.Size = new Size(77, 29);
            BtnToDeduct.TabIndex = 5;
            BtnToDeduct.Text = "To Deduct";
            BtnToDeduct.UseVisualStyleBackColor = true;
            BtnToDeduct.Click += BtnToDeduct_Click;
            // 
            // BtnToMultiply
            // 
            BtnToMultiply.Location = new Point(291, 270);
            BtnToMultiply.Name = "BtnToMultiply";
            BtnToMultiply.Size = new Size(75, 31);
            BtnToMultiply.TabIndex = 6;
            BtnToMultiply.Text = "To Multiply";
            BtnToMultiply.UseVisualStyleBackColor = true;
            BtnToMultiply.Click += BtnToMultiply_Click;
            // 
            // BtnDivided
            // 
            BtnDivided.Location = new Point(391, 272);
            BtnDivided.Name = "BtnDivided";
            BtnDivided.Size = new Size(79, 27);
            BtnDivided.TabIndex = 7;
            BtnDivided.Text = "Divided";
            BtnDivided.UseVisualStyleBackColor = true;
            BtnDivided.Click += BtnDivided_Click;
            // 
            // Fcalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnDivided);
            Controls.Add(BtnToMultiply);
            Controls.Add(BtnToDeduct);
            Controls.Add(BtnAddUp);
            Controls.Add(TxtNumber2);
            Controls.Add(TxtNumber1);
            Controls.Add(lblNumber2);
            Controls.Add(lblNumber1);
            Name = "Fcalculator";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber1;
        private Label lblNumber2;
        private TextBox TxtNumber1;
        private TextBox TxtNumber2;
        private Button BtnAddUp;
        private Button BtnToDeduct;
        private Button BtnToMultiply;
        private Button BtnDivided;
    }
}
