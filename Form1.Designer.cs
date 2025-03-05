namespace image_resizing
{
    partial class ImageResizingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PicBeforeResize = new PictureBox();
            PicAfterResize = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            BtnAddPhoto = new Button();
            BtnResize = new Button();
            txtFileName = new TextBox();
            txtCurrentSize = new TextBox();
            txtResizedSize = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PicBeforeResize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicAfterResize).BeginInit();
            SuspendLayout();
            // 
            // PicBeforeResize
            // 
            PicBeforeResize.BorderStyle = BorderStyle.FixedSingle;
            PicBeforeResize.Location = new Point(12, 12);
            PicBeforeResize.Name = "PicBeforeResize";
            PicBeforeResize.Size = new Size(260, 260);
            PicBeforeResize.TabIndex = 0;
            PicBeforeResize.TabStop = false;
            // 
            // PicAfterResize
            // 
            PicAfterResize.BorderStyle = BorderStyle.FixedSingle;
            PicAfterResize.Location = new Point(332, 12);
            PicAfterResize.Name = "PicAfterResize";
            PicAfterResize.Size = new Size(260, 260);
            PicAfterResize.TabIndex = 1;
            PicAfterResize.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 275);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 2;
            label1.Text = "Before Resize";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(430, 275);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "After Resize";
            // 
            // BtnAddPhoto
            // 
            BtnAddPhoto.Location = new Point(400, 337);
            BtnAddPhoto.Name = "BtnAddPhoto";
            BtnAddPhoto.Size = new Size(93, 23);
            BtnAddPhoto.TabIndex = 4;
            BtnAddPhoto.Text = "Add Photo";
            BtnAddPhoto.UseVisualStyleBackColor = true;
            BtnAddPhoto.Click += BtnAddPhoto_Click;
            // 
            // BtnResize
            // 
            BtnResize.Location = new Point(499, 337);
            BtnResize.Name = "BtnResize";
            BtnResize.Size = new Size(93, 23);
            BtnResize.TabIndex = 5;
            BtnResize.Text = "Resize";
            BtnResize.UseVisualStyleBackColor = true;
            BtnResize.Click += BtnResize_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(12, 337);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(375, 23);
            txtFileName.TabIndex = 6;
            // 
            // txtCurrentSize
            // 
            txtCurrentSize.BackColor = SystemColors.Control;
            txtCurrentSize.Location = new Point(101, 293);
            txtCurrentSize.Name = "txtCurrentSize";
            txtCurrentSize.ReadOnly = true;
            txtCurrentSize.Size = new Size(75, 23);
            txtCurrentSize.TabIndex = 7;
            // 
            // txtResizedSize
            // 
            txtResizedSize.BackColor = SystemColors.Control;
            txtResizedSize.Location = new Point(426, 293);
            txtResizedSize.Name = "txtResizedSize";
            txtResizedSize.ReadOnly = true;
            txtResizedSize.Size = new Size(75, 23);
            txtResizedSize.TabIndex = 8;
            // 
            // ImageResizingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(604, 373);
            Controls.Add(txtResizedSize);
            Controls.Add(txtCurrentSize);
            Controls.Add(txtFileName);
            Controls.Add(BtnResize);
            Controls.Add(BtnAddPhoto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PicAfterResize);
            Controls.Add(PicBeforeResize);
            Name = "ImageResizingForm";
            Text = "ImageResizingForm";
            ((System.ComponentModel.ISupportInitialize)PicBeforeResize).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicAfterResize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PicBeforeResize;
        private PictureBox PicAfterResize;
        private Label label1;
        private Label label2;
        private Button BtnAddPhoto;
        private Button BtnResize;
        private TextBox txtFileName;
        private TextBox txtCurrentSize;
        private TextBox txtResizedSize;
    }
}
