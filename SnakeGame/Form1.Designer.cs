namespace SnakeGame
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxSnake = new System.Windows.Forms.PictureBox();
            this.pictureBoxApple = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApple)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSnake
            // 
            this.pictureBoxSnake.Image = global::SnakeGame.Properties.Resources.wide_snake_diet_1b7336d3f7de41f98827c804ca465084;
            this.pictureBoxSnake.Location = new System.Drawing.Point(59, 74);
            this.pictureBoxSnake.Name = "pictureBoxSnake";
            this.pictureBoxSnake.Size = new System.Drawing.Size(100, 80);
            this.pictureBoxSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSnake.TabIndex = 0;
            this.pictureBoxSnake.TabStop = false;
            // 
            // pictureBoxApple
            // 
            this.pictureBoxApple.Image = global::SnakeGame.Properties.Resources.istockphoto_184276818_612x612;
            this.pictureBoxApple.Location = new System.Drawing.Point(566, 101);
            this.pictureBoxApple.Name = "pictureBoxApple";
            this.pictureBoxApple.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxApple.TabIndex = 1;
            this.pictureBoxApple.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.White;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStart.Location = new System.Drawing.Point(273, 373);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(244, 65);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBoxApple);
            this.Controls.Add(this.pictureBoxSnake);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApple)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSnake;
        private System.Windows.Forms.PictureBox pictureBoxApple;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer;
    }
}

