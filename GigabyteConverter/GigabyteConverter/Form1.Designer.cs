namespace GigabyteConverter
{
    partial class Form1
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
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelGigabytes = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(466, 68);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 0;
            this.buttonConvert.Text = "Convert!";
            this.buttonConvert.UseVisualStyleBackColor = true;
            // 
            // labelGigabytes
            // 
            this.labelGigabytes.AutoSize = true;
            this.labelGigabytes.Location = new System.Drawing.Point(108, 393);
            this.labelGigabytes.Name = "labelGigabytes";
            this.labelGigabytes.Size = new System.Drawing.Size(69, 13);
            this.labelGigabytes.TabIndex = 2;
            this.labelGigabytes.Text = "Gigabytes: -1";
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(77, 71);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(100, 20);
            this.textInput.TabIndex = 3;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Bits",
            "Bytes",
            "Kilobytes",
            "Megabytes",
            "Gigabytes"});
            this.comboBox.Location = new System.Drawing.Point(254, 70);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.labelGigabytes);
            this.Controls.Add(this.buttonConvert);
            this.Name = "Form1";
            this.Text = "AnimNation\'s Gigabyte Converter!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label labelGigabytes;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

