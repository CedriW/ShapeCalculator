namespace Area
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.Triangle = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(210, 153);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(75, 23);
            this.Triangle.TabIndex = 0;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(335, 153);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(75, 23);
            this.Rectangle.TabIndex = 1;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(461, 153);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(75, 23);
            this.Circle.TabIndex = 2;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Triangle);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

