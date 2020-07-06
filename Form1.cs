using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Image2Video_AForge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 10;
        }

        MovieMaker myVideo = new MovieMaker();

        private void btn_SelectImages_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "请选择文件路径";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dlg.SelectedPath;
                MessageBox.Show("已选择文件夹："+foldPath);

                lb_Path.Text = "Path:" + foldPath;
                //选择文件
                string[] allFiles = System.IO.Directory.GetFiles(foldPath);
                List<string> imgFiles = new List<string>();
                for(int i=0; i<allFiles.Length; i++)
                {
                    if (allFiles[i].Contains(".bmp") || allFiles[i].Contains(".jpg"))
                    {
                        imgFiles.Add(allFiles[i]);
                    }
                }
                if(imgFiles.Count < 1)
                    return;
                lb_ImageFileCount.Text = "Image count: " + imgFiles.Count;
                Bitmap imgTemp = new System.Drawing.Bitmap(Image.FromFile(imgFiles[0]));
                int iFrameRate = trackBar1.Value;
                if (myVideo.CreateMovie(foldPath + "\\Video.avi", imgTemp.Width, imgTemp.Height, iFrameRate))
                {
                    string strErrFiles = "";
                    for(int i=0; i<imgFiles.Count; i++)
                    {
                        if (!myVideo.AddImageToMovie(new System.Drawing.Bitmap(Image.FromFile(imgFiles[i]))))
                            strErrFiles += imgFiles[i];
                    }
                    myVideo.CloseAndSaveMovieFile();

                    if (strErrFiles.Length > 0)
                        lb_Result.Text = "Result: error image file name, " + strErrFiles;
                    else
                        lb_Result.Text = "Result: success.";
                }
                else
                    lb_Result.Text = "Result: video file create fail.";

            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            TrackBar tb2 = (TrackBar)sender;
            this.lb_FrameRate.Text = "Frame rate: " + (tb2.Value).ToString();
            //this.Invoke(new MethodInvoker(() =>
            //    {
            //        TrackBar tb = (TrackBar)sender;
            //        this.lb_FrameRate.Text = "Frame rate: " + (tb.Value).ToString();
            //    }));
        }
    }


}
