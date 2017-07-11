namespace FallProtectionCalculator
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.FallPoster3M = new System.Windows.Forms.PictureBox();
            this.ReqFallDist = new System.Windows.Forms.TextBox();
            this.LanyardLength = new System.Windows.Forms.TextBox();
            this.DecelDist = new System.Windows.Forms.TextBox();
            this.SftyFct = new System.Windows.Forms.TextBox();
            this.WorkerHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FallPoster3M)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FallPoster3M
            // 
            this.FallPoster3M.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FallPoster3M.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FallPoster3M.Dock = System.Windows.Forms.DockStyle.Right;
            this.FallPoster3M.Image = global::FallProtectionCalculator.Properties.Resources.fall_clearance_lrg;
            this.FallPoster3M.Location = new System.Drawing.Point(714, 0);
            this.FallPoster3M.Name = "FallPoster3M";
            this.FallPoster3M.Size = new System.Drawing.Size(547, 759);
            this.FallPoster3M.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FallPoster3M.TabIndex = 0;
            this.FallPoster3M.TabStop = false;
            // 
            // ReqFallDist
            // 
            this.ReqFallDist.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ReqFallDist.ForeColor = System.Drawing.Color.Black;
            this.ReqFallDist.Location = new System.Drawing.Point(347, 142);
            this.ReqFallDist.MaxLength = 2767;
            this.ReqFallDist.Name = "ReqFallDist";
            this.ReqFallDist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReqFallDist.Size = new System.Drawing.Size(166, 22);
            this.ReqFallDist.TabIndex = 1;
            this.ReqFallDist.UseWaitCursor = true;
            this.ReqFallDist.TextChanged += new System.EventHandler(this.ReqFallDist_TextChanged);
            // 
            // LanyardLength
            // 
            this.LanyardLength.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LanyardLength.Location = new System.Drawing.Point(347, 213);
            this.LanyardLength.MaxLength = 2767;
            this.LanyardLength.Name = "LanyardLength";
            this.LanyardLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LanyardLength.Size = new System.Drawing.Size(166, 22);
            this.LanyardLength.TabIndex = 2;
            this.LanyardLength.UseWaitCursor = true;
            this.LanyardLength.TextChanged += new System.EventHandler(this.LanyardLength_TextChanged);
            // 
            // DecelDist
            // 
            this.DecelDist.BackColor = System.Drawing.SystemColors.HighlightText;
            this.DecelDist.Location = new System.Drawing.Point(347, 284);
            this.DecelDist.MaxLength = 2767;
            this.DecelDist.Name = "DecelDist";
            this.DecelDist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DecelDist.Size = new System.Drawing.Size(166, 22);
            this.DecelDist.TabIndex = 3;
            this.DecelDist.UseWaitCursor = true;
            this.DecelDist.TextChanged += new System.EventHandler(this.DecelDist_TextChanged);
            // 
            // SftyFct
            // 
            this.SftyFct.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SftyFct.Location = new System.Drawing.Point(347, 426);
            this.SftyFct.MaxLength = 2767;
            this.SftyFct.Name = "SftyFct";
            this.SftyFct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SftyFct.Size = new System.Drawing.Size(166, 22);
            this.SftyFct.TabIndex = 5;
            this.SftyFct.UseWaitCursor = true;
            this.SftyFct.TextChanged += new System.EventHandler(this.SftyFct_TextChanged);
            // 
            // WorkerHeight
            // 
            this.WorkerHeight.BackColor = System.Drawing.SystemColors.HighlightText;
            this.WorkerHeight.Location = new System.Drawing.Point(347, 355);
            this.WorkerHeight.MaxLength = 2767;
            this.WorkerHeight.Name = "WorkerHeight";
            this.WorkerHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WorkerHeight.Size = new System.Drawing.Size(166, 22);
            this.WorkerHeight.TabIndex = 4;
            this.WorkerHeight.UseWaitCursor = true;
            this.WorkerHeight.TextChanged += new System.EventHandler(this.WorkerHeight_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Required Fall Distance (RD)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lanyard Length (LL)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Deceleration Distance (DD)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Worker Height (HH)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Safety Factor (C)";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 759);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SftyFct);
            this.Controls.Add(this.WorkerHeight);
            this.Controls.Add(this.DecelDist);
            this.Controls.Add(this.LanyardLength);
            this.Controls.Add(this.ReqFallDist);
            this.Controls.Add(this.FallPoster3M);
            this.Name = "Form1";
            this.Text = "Fall Protection Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.FallPoster3M)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox FallPoster3M;
        private System.Windows.Forms.TextBox ReqFallDist;
        private System.Windows.Forms.TextBox LanyardLength;
        private System.Windows.Forms.TextBox DecelDist;
        private System.Windows.Forms.TextBox SftyFct;
        private System.Windows.Forms.TextBox WorkerHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

