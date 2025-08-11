namespace Converter
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
            components = new System.ComponentModel.Container();
            TxtTempeture = new TextBox();
            label1 = new Label();
            CbxSelect = new ComboBox();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            BtnConvert = new Button();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // TxtTempeture
            // 
            TxtTempeture.Location = new Point(196, 98);
            TxtTempeture.Name = "TxtTempeture";
            TxtTempeture.Size = new Size(253, 23);
            TxtTempeture.TabIndex = 0;
            TxtTempeture.TextChanged += TxtTempeture_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 100);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 2;
            label1.Text = "Temperature";
            label1.Click += label1_Click;
            // 
            // CbxSelect
            // 
            CbxSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxSelect.FormattingEnabled = true;
            CbxSelect.Items.AddRange(new object[] { "Celsius to Fahrenheit", "Fahrenheit to Celsius" });
            CbxSelect.Location = new Point(278, 179);
            CbxSelect.Name = "CbxSelect";
            CbxSelect.Size = new Size(171, 23);
            CbxSelect.TabIndex = 3;
            CbxSelect.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 173);
            label2.Name = "label2";
            label2.Size = new Size(260, 26);
            label2.TabIndex = 4;
            label2.Text = "Select the type of conversion";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // BtnConvert
            // 
            BtnConvert.Location = new Point(196, 248);
            BtnConvert.Name = "BtnConvert";
            BtnConvert.Size = new Size(146, 43);
            BtnConvert.TabIndex = 5;
            BtnConvert.Text = "Convert ";
            BtnConvert.UseVisualStyleBackColor = true;
            BtnConvert.Click += BtnConvert_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(196, 311);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(84, 32);
            lblResult.TabIndex = 6;
            lblResult.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 394);
            Controls.Add(lblResult);
            Controls.Add(BtnConvert);
            Controls.Add(label2);
            Controls.Add(CbxSelect);
            Controls.Add(label1);
            Controls.Add(TxtTempeture);
            Name = "Form1";
            Text = "Converter";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtTempeture;
        private Label label1;
        private ComboBox CbxSelect;
        private Label label2;
        private ErrorProvider errorProvider1;
        private Button BtnConvert;
        private Label lblResult;
    }
}
