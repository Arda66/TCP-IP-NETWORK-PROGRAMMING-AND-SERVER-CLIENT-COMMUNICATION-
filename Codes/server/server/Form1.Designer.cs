namespace server
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.attackButton = new System.Windows.Forms.Button();
            this.attackCoords = new System.Windows.Forms.TextBox();
            this.attackPosText = new System.Windows.Forms.Label();
            this.PLAYER_RESULT = new System.Windows.Forms.Label();
            this.ENEMY_RESULT = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.counterText = new System.Windows.Forms.Label();
            this.flagLocText = new System.Windows.Forms.Label();
            this.FLAGS = new System.Windows.Forms.ListBox();
            this.capturedFlagCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(945, 465);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // attackButton
            // 
            this.attackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.attackButton.Location = new System.Drawing.Point(529, 590);
            this.attackButton.Margin = new System.Windows.Forms.Padding(2);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(90, 32);
            this.attackButton.TabIndex = 9;
            this.attackButton.Text = "Attack!";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_click);
            // 
            // attackCoords
            // 
            this.attackCoords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.attackCoords.Location = new System.Drawing.Point(467, 548);
            this.attackCoords.Margin = new System.Windows.Forms.Padding(2);
            this.attackCoords.Name = "attackCoords";
            this.attackCoords.Size = new System.Drawing.Size(215, 26);
            this.attackCoords.TabIndex = 10;
            // 
            // attackPosText
            // 
            this.attackPosText.AutoSize = true;
            this.attackPosText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.attackPosText.Location = new System.Drawing.Point(301, 548);
            this.attackPosText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.attackPosText.Name = "attackPosText";
            this.attackPosText.Size = new System.Drawing.Size(162, 25);
            this.attackPosText.TabIndex = 11;
            this.attackPosText.Text = "Attack Positions :";
            // 
            // PLAYER_RESULT
            // 
            this.PLAYER_RESULT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PLAYER_RESULT.Location = new System.Drawing.Point(859, 506);
            this.PLAYER_RESULT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PLAYER_RESULT.Name = "PLAYER_RESULT";
            this.PLAYER_RESULT.Size = new System.Drawing.Size(98, 80);
            this.PLAYER_RESULT.TabIndex = 19;
            // 
            // ENEMY_RESULT
            // 
            this.ENEMY_RESULT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ENEMY_RESULT.Location = new System.Drawing.Point(859, 586);
            this.ENEMY_RESULT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ENEMY_RESULT.Name = "ENEMY_RESULT";
            this.ENEMY_RESULT.Size = new System.Drawing.Size(98, 108);
            this.ENEMY_RESULT.TabIndex = 20;
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player1Label.Location = new System.Drawing.Point(778, 586);
            this.player1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(77, 20);
            this.player1Label.TabIndex = 18;
            this.player1Label.Text = "Player 1 : ";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player2Label.Location = new System.Drawing.Point(778, 506);
            this.player2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(77, 20);
            this.player2Label.TabIndex = 17;
            this.player2Label.Text = "Player 2 : ";
            // 
            // counterText
            // 
            this.counterText.AutoSize = true;
            this.counterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.counterText.Location = new System.Drawing.Point(259, 480);
            this.counterText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.counterText.Name = "counterText";
            this.counterText.Size = new System.Drawing.Size(453, 46);
            this.counterText.TabIndex = 28;
            this.counterText.Text = "Captured Area Counter :";
            // 
            // flagLocText
            // 
            this.flagLocText.AutoSize = true;
            this.flagLocText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flagLocText.Location = new System.Drawing.Point(15, 480);
            this.flagLocText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flagLocText.Name = "flagLocText";
            this.flagLocText.Size = new System.Drawing.Size(206, 31);
            this.flagLocText.TabIndex = 27;
            this.flagLocText.Text = "Flag Locations :";
            // 
            // FLAGS
            // 
            this.FLAGS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FLAGS.FormattingEnabled = true;
            this.FLAGS.ItemHeight = 25;
            this.FLAGS.Location = new System.Drawing.Point(21, 515);
            this.FLAGS.Margin = new System.Windows.Forms.Padding(2);
            this.FLAGS.Name = "FLAGS";
            this.FLAGS.Size = new System.Drawing.Size(234, 179);
            this.FLAGS.TabIndex = 26;
            // 
            // capturedFlagCount
            // 
            this.capturedFlagCount.AutoSize = true;
            this.capturedFlagCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.capturedFlagCount.Location = new System.Drawing.Point(708, 480);
            this.capturedFlagCount.Name = "capturedFlagCount";
            this.capturedFlagCount.Size = new System.Drawing.Size(42, 46);
            this.capturedFlagCount.TabIndex = 29;
            this.capturedFlagCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 721);
            this.Controls.Add(this.capturedFlagCount);
            this.Controls.Add(this.counterText);
            this.Controls.Add(this.flagLocText);
            this.Controls.Add(this.FLAGS);
            this.Controls.Add(this.ENEMY_RESULT);
            this.Controls.Add(this.PLAYER_RESULT);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.attackPosText);
            this.Controls.Add(this.attackCoords);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.TextBox attackCoords;
        private System.Windows.Forms.Label attackPosText;
        private System.Windows.Forms.Label ENEMY_RESULT;
        private System.Windows.Forms.Label PLAYER_RESULT;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label counterText;
        private System.Windows.Forms.Label flagLocText;
        private System.Windows.Forms.ListBox FLAGS;
        private System.Windows.Forms.Label capturedFlagCount;
    }
}

