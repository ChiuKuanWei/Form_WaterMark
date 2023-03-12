using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_WaterMark.Module
{
    public static class Creating_Watermarked
    {
        /// <summary>    
        /// 在圖片上增加文字浮水印   
        /// </summary>    
        /// <param name="SrcImgPath">原始圖片的路徑</param>       
        /// <param name="sMarkText">浮水印文字內容</param>  
        public static Image BuildWatermark(string SrcImgPath, string sMarkText)
        {
            // 讀取圖像
            Image image = Image.FromFile(SrcImgPath);

            // 創建一個新的圖像，以便繪製浮水印
            Bitmap bitmap = new Bitmap(image.Width, image.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // 複製原始圖像到新的圖像中
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);

                // 計算浮水印文字的大小和位置
                Font font = GetAdjustedFont(graphics, sMarkText, "arial", image.Width);
                SizeF size = graphics.MeasureString(sMarkText, font);
                float x = 10;
                float y = 10;

                // 設置文字的背景色和前景色
                SolidBrush backBrush = new SolidBrush(Color.White);
                SolidBrush fontBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 0));

                // 在圖像上繪製浮水印
                graphics.FillRectangle(backBrush, x, y, size.Width, size.Height);
                graphics.DrawString(sMarkText, font, fontBrush, x, y);

                // 釋放資源
                font.Dispose();
                backBrush.Dispose();
                fontBrush.Dispose();
            }

            string sDirectory = System.Windows.Forms.Application.StartupPath + "\\圖片存放區";
            DirectoryInfo dir = new DirectoryInfo(sDirectory);
            if (!dir.Exists)  ////檢查目錄是否存在
            {
                dir.Create();
            }

            string sFileName = sDirectory + "\\" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".jpg";  //建立圖片存放的路徑與檔名
            bitmap.Save(sFileName, ImageFormat.Jpeg);  //儲存拍攝的圖片
            FileStream fs = new FileStream(sFileName, System.IO.FileMode.Open);
            Bitmap myBitmap = new Bitmap(fs);
            fs.Close();
            Image myImage = (Image)myBitmap.Clone();  //將拍攝的圖片顯示在PictureBox

            image.Dispose();
            return myImage;
        }

        // 依照圖片大小，計算字體大小
        private static Font GetAdjustedFont(Graphics graphics, string text, string fontName, int maxWidth)
        {          
            int fontSize = 50;
            Font font = new Font(fontName, fontSize, FontStyle.Regular, GraphicsUnit.Pixel);
            while (graphics.MeasureString(text, font).Width > maxWidth)
            {
                fontSize--;
                font = new Font(fontName, fontSize, FontStyle.Regular, GraphicsUnit.Pixel);
            }

            return font;
        }
    }
}
