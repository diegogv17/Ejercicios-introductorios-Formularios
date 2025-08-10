namespace Conversor_Celsius___Fahrenheit
{
    partial class Conversor
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
            components = new System.ComponentModel.Container();
            TemperatureText = new Label();
            TemperatureWriting = new TextBox();
            ConversionText = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            convertButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // TemperatureText
            // 
            TemperatureText.AutoSize = true;
            TemperatureText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            TemperatureText.ForeColor = SystemColors.ButtonFace;
            TemperatureText.Location = new Point(101, 13);
            TemperatureText.Name = "TemperatureText";
            TemperatureText.Size = new Size(220, 25);
            TemperatureText.TabIndex = 0;
            TemperatureText.Text = "Converter Temperature";
            TemperatureText.Click += this.label1_Click;
            // 
            // TemperatureWriting
            // 
            TemperatureWriting.Font = new Font("Segoe UI", 12F);
            TemperatureWriting.Location = new Point(101, 56);
            TemperatureWriting.Name = "TemperatureWriting";
            TemperatureWriting.Size = new Size(229, 29);
            TemperatureWriting.TabIndex = 1;
            TemperatureWriting.TextChanged += this.TemperatureWriting_TextChanged;
            // 
            // ConversionText
            // 
            ConversionText.AutoSize = true;
            ConversionText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ConversionText.ForeColor = SystemColors.ButtonFace;
            ConversionText.Location = new Point(154, 110);
            ConversionText.Name = "ConversionText";
            ConversionText.Size = new Size(113, 25);
            ConversionText.TabIndex = 2;
            ConversionText.Text = "Conversion";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "\"Celsius to Fahrenheit\"", "", "", "\"Fahrenheit to Celsius\"" });
            comboBox1.Location = new Point(101, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 23);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(170, 247);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 4;
            label1.Text = "Result";
            label1.Click += this.label1_Click_1;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(159, 198);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(86, 31);
            convertButton.TabIndex = 5;
            convertButton.Text = "convert";
            convertButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Conversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(435, 332);
            Controls.Add(convertButton);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(ConversionText);
            Controls.Add(TemperatureWriting);
            Controls.Add(TemperatureText);
            Name = "Conversor";
            Text = "Conversor de Temperatura";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TemperatureText;
        private TextBox TemperatureWriting;
        private Label ConversionText;
        private ComboBox comboBox1;
        private Label label1;
        private Button convertButton;
        private ErrorProvider errorProvider1;
    }
}
