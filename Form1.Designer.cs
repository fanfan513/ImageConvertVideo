namespace Image2Video_AForge
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_SelectImages = new System.Windows.Forms.Button();
            this.lb_Path = new System.Windows.Forms.Label();
            this.lb_ImageFileCount = new System.Windows.Forms.Label();
            this.lb_Result = new System.Windows.Forms.Label();
            this.lb_FrameRate = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SelectImages
            // 
            this.btn_SelectImages.Location = new System.Drawing.Point(115, 110);
            this.btn_SelectImages.Name = "btn_SelectImages";
            this.btn_SelectImages.Size = new System.Drawing.Size(95, 29);
            this.btn_SelectImages.TabIndex = 0;
            this.btn_SelectImages.Text = "select images";
            this.btn_SelectImages.UseVisualStyleBackColor = true;
            this.btn_SelectImages.Click += new System.EventHandler(this.btn_SelectImages_Click);
            // 
            // lb_Path
            // 
            this.lb_Path.AutoSize = true;
            this.lb_Path.Location = new System.Drawing.Point(29, 9);
            this.lb_Path.Name = "lb_Path";
            this.lb_Path.Size = new System.Drawing.Size(35, 12);
            this.lb_Path.TabIndex = 1;
            this.lb_Path.Text = "Path:";
            // 
            // lb_ImageFileCount
            // 
            this.lb_ImageFileCount.AutoSize = true;
            this.lb_ImageFileCount.Location = new System.Drawing.Point(29, 38);
            this.lb_ImageFileCount.Name = "lb_ImageFileCount";
            this.lb_ImageFileCount.Size = new System.Drawing.Size(77, 12);
            this.lb_ImageFileCount.TabIndex = 1;
            this.lb_ImageFileCount.Text = "Image count:";
            // 
            // lb_Result
            // 
            this.lb_Result.AutoSize = true;
            this.lb_Result.Location = new System.Drawing.Point(29, 148);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(41, 12);
            this.lb_Result.TabIndex = 1;
            this.lb_Result.Text = "Result";
            // 
            // lb_FrameRate
            // 
            this.lb_FrameRate.AutoSize = true;
            this.lb_FrameRate.Location = new System.Drawing.Point(29, 68);
            this.lb_FrameRate.Name = "lb_FrameRate";
            this.lb_FrameRate.Size = new System.Drawing.Size(71, 12);
            this.lb_FrameRate.TabIndex = 1;
            this.lb_FrameRate.Text = "Frame rate:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(130, 63);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeftLayout = true;
            this.trackBar1.Size = new System.Drawing.Size(240, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Tag = "";
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 234);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.lb_FrameRate);
            this.Controls.Add(this.lb_ImageFileCount);
            this.Controls.Add(this.lb_Path);
            this.Controls.Add(this.btn_SelectImages);
            this.Name = "Form1";
            this.Text = "Images Convert Video";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SelectImages;
        private System.Windows.Forms.Label lb_Path;
        private System.Windows.Forms.Label lb_ImageFileCount;
        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.Label lb_FrameRate;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

