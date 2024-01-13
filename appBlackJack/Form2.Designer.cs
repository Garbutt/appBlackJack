namespace appBlackJack
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblYourCards = new System.Windows.Forms.Label();
            this.lblDealersCards = new System.Windows.Forms.Label();
            this.picPHand1 = new System.Windows.Forms.PictureBox();
            this.picPHand2 = new System.Windows.Forms.PictureBox();
            this.picPHand3 = new System.Windows.Forms.PictureBox();
            this.picPHand4 = new System.Windows.Forms.PictureBox();
            this.picPHand5 = new System.Windows.Forms.PictureBox();
            this.picDCard1 = new System.Windows.Forms.PictureBox();
            this.picDCard2 = new System.Windows.Forms.PictureBox();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblYourScore = new System.Windows.Forms.Label();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.imgCardList = new System.Windows.Forms.ImageList(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPHand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPHand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPHand3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPHand4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPHand5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDCard2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYourCards
            // 
            this.lblYourCards.BackColor = System.Drawing.Color.Transparent;
            this.lblYourCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourCards.ForeColor = System.Drawing.Color.White;
            this.lblYourCards.Location = new System.Drawing.Point(158, 60);
            this.lblYourCards.Name = "lblYourCards";
            this.lblYourCards.Size = new System.Drawing.Size(311, 48);
            this.lblYourCards.TabIndex = 0;
            this.lblYourCards.Text = "Your Cards";
            // 
            // lblDealersCards
            // 
            this.lblDealersCards.BackColor = System.Drawing.Color.Transparent;
            this.lblDealersCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealersCards.ForeColor = System.Drawing.Color.White;
            this.lblDealersCards.Location = new System.Drawing.Point(1068, 60);
            this.lblDealersCards.Name = "lblDealersCards";
            this.lblDealersCards.Size = new System.Drawing.Size(290, 48);
            this.lblDealersCards.TabIndex = 1;
            this.lblDealersCards.Text = "Dealers Cards";
            // 
            // picPHand1
            // 
            this.picPHand1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPHand1.BackgroundImage")));
            this.picPHand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPHand1.Location = new System.Drawing.Point(65, 160);
            this.picPHand1.Name = "picPHand1";
            this.picPHand1.Size = new System.Drawing.Size(152, 217);
            this.picPHand1.TabIndex = 2;
            this.picPHand1.TabStop = false;
            // 
            // picPHand2
            // 
            this.picPHand2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPHand2.BackgroundImage")));
            this.picPHand2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPHand2.Location = new System.Drawing.Point(255, 160);
            this.picPHand2.Name = "picPHand2";
            this.picPHand2.Size = new System.Drawing.Size(152, 217);
            this.picPHand2.TabIndex = 3;
            this.picPHand2.TabStop = false;
            // 
            // picPHand3
            // 
            this.picPHand3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPHand3.Location = new System.Drawing.Point(447, 160);
            this.picPHand3.Name = "picPHand3";
            this.picPHand3.Size = new System.Drawing.Size(152, 217);
            this.picPHand3.TabIndex = 4;
            this.picPHand3.TabStop = false;
            this.picPHand3.Visible = false;
            // 
            // picPHand4
            // 
            this.picPHand4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPHand4.Location = new System.Drawing.Point(158, 405);
            this.picPHand4.Name = "picPHand4";
            this.picPHand4.Size = new System.Drawing.Size(152, 217);
            this.picPHand4.TabIndex = 5;
            this.picPHand4.TabStop = false;
            this.picPHand4.Visible = false;
            // 
            // picPHand5
            // 
            this.picPHand5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPHand5.Location = new System.Drawing.Point(356, 405);
            this.picPHand5.Name = "picPHand5";
            this.picPHand5.Size = new System.Drawing.Size(152, 217);
            this.picPHand5.TabIndex = 6;
            this.picPHand5.TabStop = false;
            this.picPHand5.Visible = false;
            // 
            // picDCard1
            // 
            this.picDCard1.BackgroundImage = global::appBlackJack.Properties.Resources.blue_back_of_cards;
            this.picDCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDCard1.Location = new System.Drawing.Point(1010, 160);
            this.picDCard1.Name = "picDCard1";
            this.picDCard1.Size = new System.Drawing.Size(152, 217);
            this.picDCard1.TabIndex = 7;
            this.picDCard1.TabStop = false;
            // 
            // picDCard2
            // 
            this.picDCard2.BackgroundImage = global::appBlackJack.Properties.Resources.blue_back_of_cards;
            this.picDCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDCard2.Location = new System.Drawing.Point(1251, 160);
            this.picDCard2.Name = "picDCard2";
            this.picDCard2.Size = new System.Drawing.Size(152, 217);
            this.picDCard2.TabIndex = 8;
            this.picDCard2.TabStop = false;
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.ForeColor = System.Drawing.Color.White;
            this.btnHit.Location = new System.Drawing.Point(580, 709);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(147, 68);
            this.btnHit.TabIndex = 9;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Visible = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.Red;
            this.btnStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.ForeColor = System.Drawing.Color.White;
            this.btnStand.Location = new System.Drawing.Point(769, 709);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(147, 68);
            this.btnStand.TabIndex = 10;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Visible = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(1256, 719);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 68);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblYourScore
            // 
            this.lblYourScore.BackColor = System.Drawing.Color.Transparent;
            this.lblYourScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourScore.ForeColor = System.Drawing.Color.White;
            this.lblYourScore.Location = new System.Drawing.Point(1002, 502);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(356, 48);
            this.lblYourScore.TabIndex = 12;
            this.lblYourScore.Text = "Your Score: ";
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblDealerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerScore.ForeColor = System.Drawing.Color.White;
            this.lblDealerScore.Location = new System.Drawing.Point(1002, 574);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(410, 48);
            this.lblDealerScore.TabIndex = 13;
            this.lblDealerScore.Text = "Dealers Score:";
            // 
            // imgCardList
            // 
            this.imgCardList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCardList.ImageStream")));
            this.imgCardList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCardList.Images.SetKeyName(0, "2c.png");
            this.imgCardList.Images.SetKeyName(1, "2d.png");
            this.imgCardList.Images.SetKeyName(2, "2h.png");
            this.imgCardList.Images.SetKeyName(3, "2s.png");
            this.imgCardList.Images.SetKeyName(4, "3c.png");
            this.imgCardList.Images.SetKeyName(5, "3d.png");
            this.imgCardList.Images.SetKeyName(6, "3h.png");
            this.imgCardList.Images.SetKeyName(7, "3s.png");
            this.imgCardList.Images.SetKeyName(8, "4c.png");
            this.imgCardList.Images.SetKeyName(9, "4d.png");
            this.imgCardList.Images.SetKeyName(10, "4h.png");
            this.imgCardList.Images.SetKeyName(11, "4s.png");
            this.imgCardList.Images.SetKeyName(12, "5c.png");
            this.imgCardList.Images.SetKeyName(13, "5d.png");
            this.imgCardList.Images.SetKeyName(14, "5h.png");
            this.imgCardList.Images.SetKeyName(15, "5s.png");
            this.imgCardList.Images.SetKeyName(16, "6c.png");
            this.imgCardList.Images.SetKeyName(17, "6d.png");
            this.imgCardList.Images.SetKeyName(18, "6h.png");
            this.imgCardList.Images.SetKeyName(19, "6s.png");
            this.imgCardList.Images.SetKeyName(20, "7c.png");
            this.imgCardList.Images.SetKeyName(21, "7d.png");
            this.imgCardList.Images.SetKeyName(22, "7h.png");
            this.imgCardList.Images.SetKeyName(23, "7s.png");
            this.imgCardList.Images.SetKeyName(24, "8c.png");
            this.imgCardList.Images.SetKeyName(25, "8d.png");
            this.imgCardList.Images.SetKeyName(26, "8h.png");
            this.imgCardList.Images.SetKeyName(27, "8s.png");
            this.imgCardList.Images.SetKeyName(28, "9c.png");
            this.imgCardList.Images.SetKeyName(29, "9d.png");
            this.imgCardList.Images.SetKeyName(30, "9h.png");
            this.imgCardList.Images.SetKeyName(31, "9s.png");
            this.imgCardList.Images.SetKeyName(32, "10c.png");
            this.imgCardList.Images.SetKeyName(33, "10d.png");
            this.imgCardList.Images.SetKeyName(34, "10h.png");
            this.imgCardList.Images.SetKeyName(35, "10s.png");
            this.imgCardList.Images.SetKeyName(36, "jc.png");
            this.imgCardList.Images.SetKeyName(37, "jd.png");
            this.imgCardList.Images.SetKeyName(38, "jh.png");
            this.imgCardList.Images.SetKeyName(39, "js.png");
            this.imgCardList.Images.SetKeyName(40, "kc.png");
            this.imgCardList.Images.SetKeyName(41, "kd.png");
            this.imgCardList.Images.SetKeyName(42, "kh.png");
            this.imgCardList.Images.SetKeyName(43, "ks.png");
            this.imgCardList.Images.SetKeyName(44, "qc.png");
            this.imgCardList.Images.SetKeyName(45, "qd.png");
            this.imgCardList.Images.SetKeyName(46, "qh.png");
            this.imgCardList.Images.SetKeyName(47, "qs.png");
            this.imgCardList.Images.SetKeyName(48, "ah.png");
            this.imgCardList.Images.SetKeyName(49, "ac.png");
            this.imgCardList.Images.SetKeyName(50, "as.png");
            this.imgCardList.Images.SetKeyName(51, "ad.png");
            this.imgCardList.Images.SetKeyName(52, "blue back of cards.png");
            this.imgCardList.Images.SetKeyName(53, "red back of cards.png");
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(83, 709);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(619, 78);
            this.lblResult.TabIndex = 14;
            this.lblResult.Visible = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.btnPlayAgain.Location = new System.Drawing.Point(1168, 719);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(235, 69);
            this.btnPlayAgain.TabIndex = 15;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(679, 51);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(132, 65);
            this.btnHelp.TabIndex = 16;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1486, 825);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDealerScore);
            this.Controls.Add(this.lblYourScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.picDCard2);
            this.Controls.Add(this.picDCard1);
            this.Controls.Add(this.picPHand5);
            this.Controls.Add(this.picPHand4);
            this.Controls.Add(this.picPHand3);
            this.Controls.Add(this.picPHand2);
            this.Controls.Add(this.picPHand1);
            this.Controls.Add(this.lblDealersCards);
            this.Controls.Add(this.lblYourCards);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPHand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPHand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPHand3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPHand4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPHand5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDCard2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblYourCards;
        private System.Windows.Forms.Label lblDealersCards;
        private System.Windows.Forms.PictureBox picPHand1;
        private System.Windows.Forms.PictureBox picPHand2;
        private System.Windows.Forms.PictureBox picPHand3;
        private System.Windows.Forms.PictureBox picPHand4;
        private System.Windows.Forms.PictureBox picPHand5;
        private System.Windows.Forms.PictureBox picDCard1;
        private System.Windows.Forms.PictureBox picDCard2;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.ImageList imgCardList;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnHelp;
    }
}