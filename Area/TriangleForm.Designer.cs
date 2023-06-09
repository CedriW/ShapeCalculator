namespace Area
{
    partial class TriangleForm
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
            this.SideLabel1 = new System.Windows.Forms.Label();
            this.SideTxt1 = new System.Windows.Forms.TextBox();
            this.SideLabel2 = new System.Windows.Forms.Label();
            this.SideTxt2 = new System.Windows.Forms.TextBox();
            this.SideLabel3 = new System.Windows.Forms.Label();
            this.SideTxt3 = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SideLabel1
            // 
            this.SideLabel1.AutoSize = true;
            this.SideLabel1.Location = new System.Drawing.Point(325, 174);
            this.SideLabel1.Name = "SideLabel1";
            this.SideLabel1.Size = new System.Drawing.Size(40, 13);
            this.SideLabel1.TabIndex = 35;
            this.SideLabel1.Text = "Side 1:";
            // 
            // SideTxt1
            // 
            this.SideTxt1.Location = new System.Drawing.Point(371, 202);
            this.SideTxt1.Name = "SideTxt1";
            this.SideTxt1.Size = new System.Drawing.Size(100, 20);
            this.SideTxt1.TabIndex = 36;
            // 
            // SideLabel2
            // 
            this.SideLabel2.AutoSize = true;
            this.SideLabel2.Location = new System.Drawing.Point(325, 231);
            this.SideLabel2.Name = "SideLabel2";
            this.SideLabel2.Size = new System.Drawing.Size(40, 13);
            this.SideLabel2.TabIndex = 31;
            this.SideLabel2.Text = "Side 2:";
            // 
            // SideTxt2
            // 
            this.SideTxt2.Location = new System.Drawing.Point(371, 228);
            this.SideTxt2.Name = "SideTxt2";
            this.SideTxt2.Size = new System.Drawing.Size(100, 20);
            this.SideTxt2.TabIndex = 33;
            // 
            // SideLabel3
            // 
            this.SideLabel3.AutoSize = true;
            this.SideLabel3.Location = new System.Drawing.Point(325, 205);
            this.SideLabel3.Name = "SideLabel3";
            this.SideLabel3.Size = new System.Drawing.Size(40, 13);
            this.SideLabel3.TabIndex = 30;
            this.SideLabel3.Text = "Side 3:";
            // 
            // SideTxt3
            // 
            this.SideTxt3.Location = new System.Drawing.Point(371, 174);
            this.SideTxt3.Name = "SideTxt3";
            this.SideTxt3.Size = new System.Drawing.Size(100, 20);
            this.SideTxt3.TabIndex = 32;
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
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SideLabel1);
            this.Controls.Add(this.SideTxt1);
            this.Controls.Add(this.SideLabel2);
            this.Controls.Add(this.SideTxt2);
            this.Controls.Add(this.SideLabel3);
            this.Controls.Add(this.SideTxt3);
            this.Controls.Add(this.calculate);
            this.Name = "TriangleForm";
            this.Text = "TriangleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SideLabel1;
        private System.Windows.Forms.TextBox SideTxt1;
        private System.Windows.Forms.Label SideLabel2;
        private System.Windows.Forms.TextBox SideTxt2;
        private System.Windows.Forms.Label SideLabel3;
        private System.Windows.Forms.TextBox SideTxt3;
        private System.Windows.Forms.Button calculate;
    }
}