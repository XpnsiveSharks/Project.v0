namespace jumblrUI2
{
    partial class Answer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rndPanel1 = new rndPanel();
            this.rndButton1 = new jumblrUI2.rndButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1055, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 49);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(89)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(17, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "score: \r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rndPanel1
            // 
            this.rndPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.rndPanel1.Location = new System.Drawing.Point(334, 130);
            this.rndPanel1.Name = "rndPanel1";
            this.rndPanel1.Size = new System.Drawing.Size(599, 343);
            this.rndPanel1.TabIndex = 7;
            // 
            // rndButton1
            // 
            this.rndButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(156)))));
            this.rndButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(156)))));
            this.rndButton1.BorderColor = System.Drawing.Color.LightBlue;
            this.rndButton1.BorderRadius = 40;
            this.rndButton1.BorderSize = 0;
            this.rndButton1.FlatAppearance.BorderSize = 0;
            this.rndButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(209)))));
            this.rndButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(156)))));
            this.rndButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rndButton1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rndButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(89)))), ((int)(((byte)(169)))));
            this.rndButton1.Location = new System.Drawing.Point(497, 550);
            this.rndButton1.Name = "rndButton1";
            this.rndButton1.Size = new System.Drawing.Size(274, 61);
            this.rndButton1.TabIndex = 8;
            this.rndButton1.Text = "NEXT";
            this.rndButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(89)))), ((int)(((byte)(169)))));
            this.rndButton1.UseVisualStyleBackColor = false;
            // 
            // Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(183)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1275, 700);
            this.Controls.Add(this.rndButton1);
            this.Controls.Add(this.rndPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Answer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Answer";
            this.Load += new System.EventHandler(this.Answer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private rndPanel rndPanel1;
        private rndButton rndButton1;
    }
}