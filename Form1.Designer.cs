namespace FunctionCalculator
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.functionTextBox = new System.Windows.Forms.TextBox();
            this.parameterTextBox = new System.Windows.Forms.TextBox();
            this.functionLabel = new System.Windows.Forms.Label();
            this.xValueLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTitelLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(12, 169);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(116, 31);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // functionTextBox
            // 
            this.functionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionTextBox.Location = new System.Drawing.Point(60, 34);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(525, 31);
            this.functionTextBox.TabIndex = 1;
            // 
            // parameterTextBox
            // 
            this.parameterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parameterTextBox.Location = new System.Drawing.Point(114, 84);
            this.parameterTextBox.Name = "parameterTextBox";
            this.parameterTextBox.Size = new System.Drawing.Size(471, 31);
            this.parameterTextBox.TabIndex = 2;
            // 
            // functionLabel
            // 
            this.functionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionLabel.Location = new System.Drawing.Point(12, 34);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(49, 30);
            this.functionLabel.TabIndex = 3;
            this.functionLabel.Text = "f(x):";
            // 
            // xValueLabel
            // 
            this.xValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xValueLabel.Location = new System.Drawing.Point(12, 87);
            this.xValueLabel.Name = "xValueLabel";
            this.xValueLabel.Size = new System.Drawing.Size(89, 30);
            this.xValueLabel.TabIndex = 4;
            this.xValueLabel.Text = "x value:";
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(134, 169);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(451, 30);
            this.resultLabel.TabIndex = 5;
            // 
            // resultTitelLabel
            // 
            this.resultTitelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTitelLabel.Location = new System.Drawing.Point(134, 139);
            this.resultTitelLabel.Name = "resultTitelLabel";
            this.resultTitelLabel.Size = new System.Drawing.Size(96, 30);
            this.resultTitelLabel.TabIndex = 6;
            this.resultTitelLabel.Text = "result:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(18, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 219);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resultTitelLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.xValueLabel);
            this.Controls.Add(this.functionLabel);
            this.Controls.Add(this.parameterTextBox);
            this.Controls.Add(this.functionTextBox);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label resultTitelLabel;

        private System.Windows.Forms.Label resultLabel;

        private System.Windows.Forms.Label xValueLabel;

        private System.Windows.Forms.TextBox parameterTextBox;
        private System.Windows.Forms.Label functionLabel;

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox functionTextBox;
        

        #endregion
    }
}