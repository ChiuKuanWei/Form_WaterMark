using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Form_WaterMark.Module;

namespace Form_WaterMark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_SelectImage_Click(object sender, EventArgs e)
        {
            // 建立 OpenFileDialog 物件
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // 設定預設的檔案篩選條件
            openFileDialog.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";

            // 如果使用者選擇了檔案，則顯示檔案路徑並開啟圖片
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(txt_Content.Text == "")
                {
                    MessageBox.Show("請輸入浮水印內容!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // 取得選擇的檔案路徑
                lbl_ImagePath.Text = openFileDialog.FileName;

                try
                {
                    pictureBox_Image.Image = Creating_Watermarked.BuildWatermark(lbl_ImagePath.Text, txt_Content.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("開啟圖片檔失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }
    }
}
