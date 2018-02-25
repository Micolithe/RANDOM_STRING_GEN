namespace String_Generator_CSTEST
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
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Go = new System.Windows.Forms.Button();
            this.spinner_Length = new System.Windows.Forms.NumericUpDown();
            this.ck_lower = new System.Windows.Forms.CheckBox();
            this.ck_upper = new System.Windows.Forms.CheckBox();
            this.ck_numbers = new System.Windows.Forms.CheckBox();
            this.ck_symbols = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.spinner_Length)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(13, 230);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.ReadOnly = true;
            this.txt_Output.Size = new System.Drawing.Size(259, 20);
            this.txt_Output.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "String Length";
            // 
            // btn_Go
            // 
            this.btn_Go.Location = new System.Drawing.Point(12, 129);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(75, 23);
            this.btn_Go.TabIndex = 6;
            this.btn_Go.Text = "Go";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // spinner_Length
            // 
            this.spinner_Length.Location = new System.Drawing.Point(86, 11);
            this.spinner_Length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinner_Length.Name = "spinner_Length";
            this.spinner_Length.Size = new System.Drawing.Size(46, 20);
            this.spinner_Length.TabIndex = 1;
            this.spinner_Length.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ck_lower
            // 
            this.ck_lower.AutoSize = true;
            this.ck_lower.Location = new System.Drawing.Point(13, 37);
            this.ck_lower.Name = "ck_lower";
            this.ck_lower.Size = new System.Drawing.Size(78, 17);
            this.ck_lower.TabIndex = 2;
            this.ck_lower.Text = "Lowercase";
            this.ck_lower.UseVisualStyleBackColor = true;
            // 
            // ck_upper
            // 
            this.ck_upper.AutoSize = true;
            this.ck_upper.Location = new System.Drawing.Point(13, 60);
            this.ck_upper.Name = "ck_upper";
            this.ck_upper.Size = new System.Drawing.Size(78, 17);
            this.ck_upper.TabIndex = 3;
            this.ck_upper.Text = "Uppercase";
            this.ck_upper.UseVisualStyleBackColor = true;
            // 
            // ck_numbers
            // 
            this.ck_numbers.AutoSize = true;
            this.ck_numbers.Location = new System.Drawing.Point(13, 83);
            this.ck_numbers.Name = "ck_numbers";
            this.ck_numbers.Size = new System.Drawing.Size(68, 17);
            this.ck_numbers.TabIndex = 4;
            this.ck_numbers.Text = "Numbers";
            this.ck_numbers.UseVisualStyleBackColor = true;
            // 
            // ck_symbols
            // 
            this.ck_symbols.AutoSize = true;
            this.ck_symbols.Location = new System.Drawing.Point(13, 106);
            this.ck_symbols.Name = "ck_symbols";
            this.ck_symbols.Size = new System.Drawing.Size(65, 17);
            this.ck_symbols.TabIndex = 5;
            this.ck_symbols.Text = "Symbols";
            this.ck_symbols.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ck_symbols);
            this.Controls.Add(this.ck_numbers);
            this.Controls.Add(this.ck_upper);
            this.Controls.Add(this.ck_lower);
            this.Controls.Add(this.spinner_Length);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Output);
            this.Name = "Form1";
            this.Text = "Random String Generator";
            ((System.ComponentModel.ISupportInitialize)(this.spinner_Length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.NumericUpDown spinner_Length;
        private System.Windows.Forms.CheckBox ck_lower;
        private System.Windows.Forms.CheckBox ck_upper;
        private System.Windows.Forms.CheckBox ck_numbers;
        private System.Windows.Forms.CheckBox ck_symbols;
    }
}

