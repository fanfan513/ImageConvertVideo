using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using AForge;
using AForge.Video.FFMPEG;

namespace Image2Video_AForge
{
    public class MovieMaker
    {
        //public void testA()
        //{
        //    string basePaths = @"E:\cpfDir_Intelligent\2019\11\04";

        //    string[] paths = Directory.GetFiles(basePaths);
        //    int imagesCount = paths.Length;
        //    using (var vFWriter = new VideoFileWriter())
        //    {
        //        //setting the width and the heigh of video are the same as your pictures(the width and heigh of all pictures are the same.)
        //        vFWriter.Open(@"D:\videos.avi", 1920, 1080, 2, VideoCodec.MPEG4, 1000000);
        //        for (int i = 1; i < imagesCount; i++)
        //        {
        //            var imagePath = string.Format(paths[i]);
        //            using (Bitmap image = Bitmap.FromFile(imagePath) as Bitmap)
        //            {
        //                vFWriter.WriteVideoFrame(image); //you could check your pictures’s size. 
        //            }

        //        }
        //    }
        //}


        private Bitmap ToBitmap(byte[] byteArrayIn)
        {
            var ms = new System.IO.MemoryStream(byteArrayIn);
            var returnImage = System.Drawing.Image.FromStream(ms);
            var bitmap = new System.Drawing.Bitmap(returnImage);

            return bitmap;
        }

        //裁剪图像尺寸
        private Bitmap ReduceBitmap(Bitmap original, int reducedWidth, int reducedHeight)
        {
            var reduced = new Bitmap(reducedWidth, reducedHeight);
            using (var dc = Graphics.FromImage(reduced))
            {
                dc.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                dc.DrawImage(original, new Rectangle(0, 0, reducedWidth, reducedHeight), new Rectangle(0, 0, original.Width, original.Height), GraphicsUnit.Pixel);
            }
            return reduced;
        }

        /*END OF COPIED CODE BLOCK*/

        private VideoFileWriter m_VFW = null;
        private int m_ImgWidth = 0;
        private int m_ImgHeight = 0;
        //创建视频文件；
        //保存的文件路径及文件名， 视频的宽、高，视频的帧率
        public bool CreateMovie(string strVideoName, int iWidth, int iHeight, int iFrameRate)
        {   
            try
            {
                if (m_VFW == null)
                    m_VFW = new VideoFileWriter();

                m_ImgWidth = iWidth;
                m_ImgHeight = iHeight;
                // create new video file
                m_VFW.Open(strVideoName, m_ImgWidth, m_ImgHeight, iFrameRate, VideoCodec.MPEG4);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
                return false;
            }           
        }

        //向video中添加单帧图像
        public bool AddImageToMovie(Bitmap img)
        {
            try
            {
                if (m_VFW != null)
                {
                    if(img.Width != m_ImgWidth)
                        m_VFW.WriteVideoFrame(ReduceBitmap(img, m_ImgWidth, m_ImgHeight));
                    else
                        m_VFW.WriteVideoFrame(img);
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                throw ex;
                return false;
            }
        }

        //关闭对象，保存到文件
        public void CloseAndSaveMovieFile()
        {
            if(m_VFW != null)
            {
                m_VFW.Close();
                //关闭对象
                m_VFW.Dispose();
                m_VFW = null;
            }
        }

    }
}

