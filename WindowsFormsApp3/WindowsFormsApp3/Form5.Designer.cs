namespace WindowsFormsApp3
{
    partial class Form5
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
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AI3 = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.AI4 = new System.Windows.Forms.PictureBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_over = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI4)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::WindowsFormsApp3.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(194, 377);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(62, 38);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AI3
            // 
            this.AI3.BackColor = System.Drawing.Color.Transparent;
            this.AI3.Image = global::WindowsFormsApp3.Properties.Resources._3;
            this.AI3.Location = new System.Drawing.Point(274, 30);
            this.AI3.Name = "AI3";
            this.AI3.Size = new System.Drawing.Size(37, 43);
            this.AI3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI3.TabIndex = 7;
            this.AI3.TabStop = false;
            this.AI3.Tag = "enemy";
            // 
            // AI2
            // 
            this.AI2.BackColor = System.Drawing.Color.Transparent;
            this.AI2.Image = global::WindowsFormsApp3.Properties.Resources._2;
            this.AI2.Location = new System.Drawing.Point(167, 39);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(44, 34);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI2.TabIndex = 6;
            this.AI2.TabStop = false;
            this.AI2.Tag = "enemy";
            // 
            // AI1
            // 
            this.AI1.BackColor = System.Drawing.Color.Transparent;
            this.AI1.Image = global::WindowsFormsApp3.Properties.Resources._1;
            this.AI1.Location = new System.Drawing.Point(42, 39);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(58, 34);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI1.TabIndex = 5;
            this.AI1.TabStop = false;
            this.AI1.Tag = "enemy";
            // 
            // AI4
            // 
            this.AI4.BackColor = System.Drawing.Color.Transparent;
            this.AI4.Image = global::WindowsFormsApp3.Properties.Resources._4;
            this.AI4.Location = new System.Drawing.Point(382, 39);
            this.AI4.Name = "AI4";
            this.AI4.Size = new System.Drawing.Size(53, 34);
            this.AI4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI4.TabIndex = 8;
            this.AI4.TabStop = false;
            this.AI4.Tag = "enemy";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_score.Location = new System.Drawing.Point(12, 9);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(131, 31);
            this.lbl_score.TabIndex = 9;
            this.lbl_score.Text = "Score : 0";
            // 
            // lbl_over
            // 
            this.lbl_over.AutoSize = true;
            this.lbl_over.BackColor = System.Drawing.Color.Transparent;
            this.lbl_over.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_over.ForeColor = System.Drawing.Color.Coral;
            this.lbl_over.Location = new System.Drawing.Point(82, 198);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(321, 65);
            this.lbl_over.TabIndex = 10;
            this.lbl_over.Text = "Game Over";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.space_g0bc86eb9e_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lbl_over);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.AI4);
            this.Controls.Add(this.AI3);
            this.Controls.Add(this.AI2);
            this.Controls.Add(this.AI1);
            this.Controls.Add(this.player);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form5_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form5_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox AI3;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox AI4;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_over;
    }
}