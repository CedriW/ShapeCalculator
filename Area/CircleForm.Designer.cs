namespace Area
{
    partial class CircleForm
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
            this.radiusLabel = new System.Windows.Forms.Label();
            this.radiusTxt = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // Radius Label
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(329, 174);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(35, 13);
            this.radiusLabel.TabIndex = 30;
            this.radiusLabel.Text = "Radius:";
            // 
            // Radius Text
            // 
            this.radiusTxt.Location = new System.Drawing.Point(371, 174);
            this.radiusTxt.Name = "radiusTxt";
            this.radiusTxt.Size = new System.Drawing.Size(100, 20);
            this.radiusTxt.TabIndex = 32;

            // 
            // Calculate Button
            // 
            this.calculate.Location = new System.Drawing.Point(371, 254);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 34;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);

            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.radiusTxt);
            this.Controls.Add(this.radiusLabel);
            this.Name = "CircleForm";
            this.Text = "CircleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.TextBox radiusTxt;
        private System.Windows.Forms.Button calculate;
    }
}