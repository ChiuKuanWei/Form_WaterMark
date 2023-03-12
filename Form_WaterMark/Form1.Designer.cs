namespace Form_WaterMark
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Content = new System.Windows.Forms.TextBox();
            this.btn_SelectImage = new System.Windows.Forms.Button();
            this.lbl_ImagePath = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "浮水印內容:";
            // 
            // txt_Content
            // 
            this.txt_Content.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Content.Location = new System.Drawing.Point(143, 30);
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.Size = new System.Drawing.Size(248, 27);
            this.txt_Content.TabIndex = 1;
            // 
            // btn_SelectImage
            // 
            this.btn_SelectImage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SelectImage.Location = new System.Drawing.Point(49, 78);
            this.btn_SelectImage.Name = "btn_SelectImage";
            this.btn_SelectImage.Size = new System.Drawing.Size(123, 23);
            this.btn_SelectImage.TabIndex = 2;
            this.btn_SelectImage.Text = "請選擇圖片檔";
            this.btn_SelectImage.UseVisualStyleBackColor = true;
            this.btn_SelectImage.Click += new System.EventHandler(this.btn_SelectImage_Click);
            // 
            // lbl_ImagePath
            // 
            this.lbl_ImagePath.AutoSize = true;
            this.lbl_ImagePath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ImagePath.Location = new System.Drawing.Point(177, 82);
            this.lbl_ImagePath.Name = "lbl_ImagePath";
            this.lbl_ImagePath.Size = new System.Drawing.Size(71, 16);
            this.lbl_ImagePath.TabIndex = 3;
            this.lbl_ImagePath.Text = "路徑位置";
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.label1);
            this.panel_Top.Controls.Add(this.lbl_ImagePath);
            this.panel_Top.Controls.Add(this.txt_Content);
            this.panel_Top.Controls.Add(this.btn_SelectImage);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(638, 141);
            this.panel_Top.TabIndex = 4;
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox_Image.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Image.Image")));
            this.pictureBox_Image.Location = new System.Drawing.Point(0, 147);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(638, 357);
            this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Image.TabIndex = 5;
            this.pictureBox_Image.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 504);
            this.Controls.Add(this.pictureBox_Image);
            this.Controls.Add(this.panel_Top);
            this.Name = "Form1";
            this.Text = "浮水印製作";
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Content;
        private System.Windows.Forms.Button btn_SelectImage;
        private System.Windows.Forms.Label lbl_ImagePath;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.PictureBox pictureBox_Image;
    }
}

