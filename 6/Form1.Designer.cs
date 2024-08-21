namespace _6
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
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctbAvatar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLan = new System.Windows.Forms.Button();
            this.txtbIP = new System.Windows.Forms.TextBox();
            this.pctbMark = new System.Windows.Forms.PictureBox();
            this.procCoolDown = new System.Windows.Forms.ProgressBar();
            this.txtbPlayerName = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbAvatar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Location = new System.Drawing.Point(2, 12);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(458, 454);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pctbAvatar);
            this.panel2.Location = new System.Drawing.Point(481, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 210);
            this.panel2.TabIndex = 1;
            // 
            // pctbAvatar
            // 
            this.pctbAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbAvatar.BackgroundImage = global::_6.Properties.Resources._1;
            this.pctbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctbAvatar.Location = new System.Drawing.Point(2, 0);
            this.pctbAvatar.Name = "pctbAvatar";
            this.pctbAvatar.Size = new System.Drawing.Size(198, 220);
            this.pctbAvatar.TabIndex = 0;
            this.pctbAvatar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnLan);
            this.panel3.Controls.Add(this.txtbIP);
            this.panel3.Controls.Add(this.pctbMark);
            this.panel3.Controls.Add(this.procCoolDown);
            this.panel3.Controls.Add(this.txtbPlayerName);
            this.panel3.Location = new System.Drawing.Point(481, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 210);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 in a line to win";
            // 
            // btnLan
            // 
            this.btnLan.Location = new System.Drawing.Point(12, 116);
            this.btnLan.Name = "btnLan";
            this.btnLan.Size = new System.Drawing.Size(93, 35);
            this.btnLan.TabIndex = 4;
            this.btnLan.Text = "LAN";
            this.btnLan.UseVisualStyleBackColor = true;
            // 
            // txtbIP
            // 
            this.txtbIP.Location = new System.Drawing.Point(16, 90);
            this.txtbIP.Name = "txtbIP";
            this.txtbIP.Size = new System.Drawing.Size(96, 20);
            this.txtbIP.TabIndex = 3;
            this.txtbIP.Text = "127.0.0.1";
            // 
            // pctbMark
            // 
            this.pctbMark.Location = new System.Drawing.Point(129, 14);
            this.pctbMark.Name = "pctbMark";
            this.pctbMark.Size = new System.Drawing.Size(69, 53);
            this.pctbMark.TabIndex = 2;
            this.pctbMark.TabStop = false;
            // 
            // procCoolDown
            // 
            this.procCoolDown.Location = new System.Drawing.Point(14, 46);
            this.procCoolDown.Name = "procCoolDown";
            this.procCoolDown.Size = new System.Drawing.Size(99, 22);
            this.procCoolDown.TabIndex = 1;
            // 
            // txtbPlayerName
            // 
            this.txtbPlayerName.Location = new System.Drawing.Point(12, 10);
            this.txtbPlayerName.Name = "txtbPlayerName";
            this.txtbPlayerName.ReadOnly = true;
            this.txtbPlayerName.Size = new System.Drawing.Size(102, 20);
            this.txtbPlayerName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 476);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlChessBoard);
            this.Name = "Form1";
            this.Text = "Game Caro Lan";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbAvatar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pctbAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLan;
        private System.Windows.Forms.TextBox txtbIP;
        private System.Windows.Forms.PictureBox pctbMark;
        private System.Windows.Forms.ProgressBar procCoolDown;
        private System.Windows.Forms.TextBox txtbPlayerName;
    }
}

