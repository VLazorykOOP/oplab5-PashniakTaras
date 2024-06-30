namespace Hraf5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.Label labelK;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.drawButton = new System.Windows.Forms.Button();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(350, 10);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 0;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);

            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.Color.White;
            this.drawPanel.Location = new System.Drawing.Point(12, 90);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(760, 500);
            this.drawPanel.TabIndex = 1;

            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(50, 10);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(50, 20);
            this.textBoxX1.TabIndex = 2;

            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(150, 10);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(50, 20);
            this.textBoxY1.TabIndex = 3;

            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(50, 40);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(50, 20);
            this.textBoxX2.TabIndex = 4;

            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(150, 40);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(50, 20);
            this.textBoxY2.TabIndex = 5;

            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(250, 10);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(50, 20);
            this.textBoxK.TabIndex = 6;

            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(12, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(32, 13);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "X1:";

            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(112, 13);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(32, 13);
            this.labelY1.TabIndex = 8;
            this.labelY1.Text = "Y1:";

            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(12, 43);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(32, 13);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "X2:";

            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(112, 43);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(32, 13);
            this.labelY2.TabIndex = 10;
            this.labelY2.Text = "Y2:";

            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Location = new System.Drawing.Point(212, 13);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(22, 13);
            this.labelK.TabIndex = 11;
            this.labelK.Text = "K:";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.drawButton);
            this.Name = "Form1";
            this.Text = "Dandelion Fractal";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
