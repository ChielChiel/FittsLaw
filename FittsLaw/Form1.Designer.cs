namespace FittsLaw
{
    partial class FittsBox
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
            this.StartButton = new System.Windows.Forms.Button();
            this.ReactButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(681, 529);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(244, 155);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "StartKnop";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ReactButton
            // 
            this.ReactButton.Location = new System.Drawing.Point(243, 387);
            this.ReactButton.Name = "ReactButton";
            this.ReactButton.Size = new System.Drawing.Size(178, 128);
            this.ReactButton.TabIndex = 1;
            this.ReactButton.Text = "ReactButton";
            this.ReactButton.UseVisualStyleBackColor = true;
            this.ReactButton.Click += new System.EventHandler(this.ReactButton_Click);
            // 
            // FittsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(2007, 1330);
            this.Controls.Add(this.ReactButton);
            this.Controls.Add(this.StartButton);
            this.MinimizeBox = false;
            this.Name = "FittsBox";
            this.Text = "Fitts\' Law";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ReactButton;
    }
}

