namespace Conversor_F_C
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
            lblConverter = new Label();
            lblResult = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            cmbOptions = new ComboBox();
            txtTemperature = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblConverter
            // 
            lblConverter.AutoSize = true;
            lblConverter.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConverter.Location = new Point(154, 32);
            lblConverter.Name = "lblConverter";
            lblConverter.Size = new Size(220, 25);
            lblConverter.TabIndex = 0;
            lblConverter.Text = "converter temperature ";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(222, 221);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(66, 25);
            lblResult.TabIndex = 1;
            lblResult.Text = "Result";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 121);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 2;
            label1.Text = "convertir";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // cmbOptions
            // 
            cmbOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOptions.FormattingEnabled = true;
            cmbOptions.Location = new Point(177, 173);
            cmbOptions.Name = "cmbOptions";
            cmbOptions.Size = new Size(159, 23);
            cmbOptions.TabIndex = 3;
            // 
            // txtTemperature
            // 
            txtTemperature.Location = new Point(177, 78);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(159, 23);
            txtTemperature.TabIndex = 4;
            txtTemperature.MaskInputRejected += this.txtTemperature_MaskInputRejected;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 322);
            Controls.Add(txtTemperature);
            Controls.Add(cmbOptions);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(lblConverter);
            Name = "Form1";
            Text = "Conversor";
            Load += this.Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConverter;
        private Label lblResult;
        private Label label1;
        private ErrorProvider errorProvider1;
        private ComboBox cmbOptions;
        private MaskedTextBox txtTemperature;
    }
}
