namespace ImageView36
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.piclmg = new System.Windows.Forms.PictureBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.piclmg)).BeginInit();
            this.SuspendLayout();
            // 
            // piclmg
            // 
            this.piclmg.Location = new System.Drawing.Point(12, 12);
            this.piclmg.Name = "piclmg";
            this.piclmg.Size = new System.Drawing.Size(293, 180);
            this.piclmg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclmg.TabIndex = 0;
            this.piclmg.TabStop = false;
            this.piclmg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(12, 208);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(84, 65);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "이전";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // lblNum
            // 
            this.lblNum.Font = new System.Drawing.Font("굴림", 14F);
            this.lblNum.Location = new System.Drawing.Point(112, 208);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(100, 23);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "/";
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(218, 208);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 65);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgList.ImageSize = new System.Drawing.Size(256, 144);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 306);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.piclmg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "사진첩";
            ((System.ComponentModel.ISupportInitialize)(this.piclmg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox piclmg;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ImageList imgList;
    }
}

