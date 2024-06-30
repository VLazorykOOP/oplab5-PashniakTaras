namespace Hraf5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtVx1 = new System.Windows.Forms.TextBox();
            this.txtVy1 = new System.Windows.Forms.TextBox();
            this.txtVx2 = new System.Windows.Forms.TextBox();
            this.txtVy2 = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.pnlDrawingArea = new System.Windows.Forms.Panel();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblV1 = new System.Windows.Forms.Label();
            this.lblV2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(160, 12);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(50, 20);
            this.txtX1.TabIndex = 0;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(216, 12);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(50, 20);
            this.txtY1.TabIndex = 1;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(160, 38);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(50, 20);
            this.txtX2.TabIndex = 2;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(216, 38);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(50, 20);
            this.txtY2.TabIndex = 3;
            // 
            // txtVx1
            // 
            this.txtVx1.Location = new System.Drawing.Point(160, 64);
            this.txtVx1.Name = "txtVx1";
            this.txtVx1.Size = new System.Drawing.Size(50, 20);
            this.txtVx1.TabIndex = 4;
            // 
            // txtVy1
            // 
            this.txtVy1.Location = new System.Drawing.Point(216, 64);
            this.txtVy1.Name = "txtVy1";
            this.txtVy1.Size = new System.Drawing.Size(50, 20);
            this.txtVy1.TabIndex = 5;
            // 
            // txtVx2
            // 
            this.txtVx2.Location = new System.Drawing.Point(160, 90);
            this.txtVx2.Name = "txtVx2";
            this.txtVx2.Size = new System.Drawing.Size(50, 20);
            this.txtVx2.TabIndex = 6;
            // 
            // txtVy2
            // 
            this.txtVy2.Location = new System.Drawing.Point(216, 90);
            this.txtVy2.Name = "txtVy2";
            this.txtVy2.Size = new System.Drawing.Size(50, 20);
            this.txtVy2.TabIndex = 7;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(272, 62);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 8;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // pnlDrawingArea
            // 
            this.pnlDrawingArea.Location = new System.Drawing.Point(12, 120);
            this.pnlDrawingArea.Name = "pnlDrawingArea";
            this.pnlDrawingArea.Size = new System.Drawing.Size(523, 318);
            this.pnlDrawingArea.TabIndex = 9;
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Location = new System.Drawing.Point(90, 15);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(42, 13);
            this.lblP1.TabIndex = 10;
            this.lblP1.Text = "P1 (X1, Y1):";
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Location = new System.Drawing.Point(90, 41);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(42, 13);
            this.lblP2.TabIndex = 11;
            this.lblP2.Text = "P2 (X2, Y2):";
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Location = new System.Drawing.Point(80, 67);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(42, 13);
            this.lblV1.TabIndex = 12;
            this.lblV1.Text = "V1 (Vx1, Vy1):";
            // 
            // lblV2
            // 
            this.lblV2.AutoSize = true;
            this.lblV2.Location = new System.Drawing.Point(80, 93);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(42, 13);
            this.lblV2.TabIndex = 13;
            this.lblV2.Text = "V2 (Vx2, Vy2):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.lblV2);
            this.Controls.Add(this.lblV1);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.pnlDrawingArea);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.txtVy2);
            this.Controls.Add(this.txtVx2);
            this.Controls.Add(this.txtVy1);
            this.Controls.Add(this.txtVx1);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX1);
            this.Name = "Form1";
            this.Text = "Hermite Curve Drawer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtVx1;
        private System.Windows.Forms.TextBox txtVy1;
        private System.Windows.Forms.TextBox txtVx2;
        private System.Windows.Forms.TextBox txtVy2;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Panel pnlDrawingArea;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.Label lblV2;
    }
}
