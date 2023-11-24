namespace jumblrUI2
{
    partial class Hint
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
            this.label1 = new System.Windows.Forms.Label();
            this.Button3 = new jumblrUI2.rndButton();
            this.rndPanel1 = new rndPanel();
            this.rndPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(183)))), ((int)(((byte)(216)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 0;
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(156)))));
            this.Button3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(156)))));
            this.Button3.BorderColor = System.Drawing.Color.LightBlue;
            this.Button3.BorderRadius = 40;
            this.Button3.BorderSize = 0;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(209)))));
            this.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(156)))));
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(89)))), ((int)(((byte)(169)))));
            this.Button3.Location = new System.Drawing.Point(500, 550);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(274, 61);
            this.Button3.TabIndex = 1;
            this.Button3.Text = "BACK";
            this.Button3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(89)))), ((int)(((byte)(169)))));
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // rndPanel1
            // 
            this.rndPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.rndPanel1.BackgroundImage = global::jumblrUI2.Properties.Resources.Add_a_heading__3_;
            this.rndPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rndPanel1.Controls.Add(this.label1);
            this.rndPanel1.Location = new System.Drawing.Point(334, 86);
            this.rndPanel1.Name = "rndPanel1";
            this.rndPanel1.Size = new System.Drawing.Size(601, 344);
            this.rndPanel1.TabIndex = 2;
            // 
            // Hint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(183)))), ((int)(((byte)(216)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1275, 700);
            this.Controls.Add(this.rndPanel1);
            this.Controls.Add(this.Button3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hint";
            this.Text = "Hint";
            this.Load += new System.EventHandler(this.Hint_Load);
            this.rndPanel1.ResumeLayout(false);
            this.rndPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private rndButton Button3;
        private rndPanel rndPanel1;
    }
}