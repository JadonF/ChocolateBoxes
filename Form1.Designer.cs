namespace ChocolateBoxes
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
            this.lblAsk = new System.Windows.Forms.Label();
            this.nudInput = new System.Windows.Forms.NumericUpDown();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAsk
            // 
            this.lblAsk.AutoSize = true;
            this.lblAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAsk.Location = new System.Drawing.Point(32, 40);
            this.lblAsk.Name = "lblAsk";
            this.lblAsk.Size = new System.Drawing.Size(435, 26);
            this.lblAsk.TabIndex = 0;
            this.lblAsk.Text = "Select how many chocolate boxes you sold.";
            // 
            // nudInput
            // 
            this.nudInput.Location = new System.Drawing.Point(179, 89);
            this.nudInput.Name = "nudInput";
            this.nudInput.Size = new System.Drawing.Size(120, 20);
            this.nudInput.TabIndex = 1;
            this.nudInput.ValueChanged += new System.EventHandler(this.nudInput_ValueChanged);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAnswer.Location = new System.Drawing.Point(37, 189);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(85, 26);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCheck.Location = new System.Drawing.Point(199, 127);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 32);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 261);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.nudInput);
            this.Controls.Add(this.lblAsk);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsk;
        private System.Windows.Forms.NumericUpDown nudInput;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnCheck;
    }
}

