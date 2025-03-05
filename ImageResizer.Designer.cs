namespace ImageResizerApp
{
    partial class ImageResizerForm
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
            txtHeight = new TextBox();
            txtWidth = new TextBox();
            label3 = new Label();
            label4 = new Label();
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
            PicAfterResize.Location = new Point(286, 12);
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
            label2.Location = new Point(384, 275);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "After Resize";
            // 
            // BtnAddPhoto
            // 
            BtnAddPhoto.Location = new Point(354, 336);
            BtnAddPhoto.Name = "BtnAddPhoto";
            BtnAddPhoto.Size = new Size(93, 23);
            BtnAddPhoto.TabIndex = 4;
            BtnAddPhoto.Text = "Add Photo";
            BtnAddPhoto.UseVisualStyleBackColor = true;
            BtnAddPhoto.Click += BtnAddPhoto_Click;
            // 
            // BtnResize
            // 
            BtnResize.Location = new Point(453, 336);
            BtnResize.Name = "BtnResize";
            BtnResize.Size = new Size(93, 23);
            BtnResize.TabIndex = 5;
            BtnResize.Text = "Resize";
            BtnResize.UseVisualStyleBackColor = true;
            BtnResize.Click += BtnResize_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(11, 337);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(336, 23);
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
            // txtHeight
            // 
            txtHeight.BackColor = SystemColors.ButtonHighlight;
            txtHeight.Location = new Point(367, 293);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(38, 23);
            txtHeight.TabIndex = 8;
            // 
            // txtWidth
            // 
            txtWidth.BackColor = SystemColors.ButtonHighlight;
            txtWidth.Location = new Point(424, 293);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(38, 23);
            txtWidth.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(464, 296);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 10;
            label3.Text = "px";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(409, 296);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 11;
            label4.Text = "x";
            // 
            // ImageResizerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(559, 373);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtWidth);
            Controls.Add(txtHeight);
            Controls.Add(txtCurrentSize);
            Controls.Add(txtFileName);
            Controls.Add(BtnResize);
            Controls.Add(BtnAddPhoto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PicAfterResize);
            Controls.Add(PicBeforeResize);
            Name = "ImageResizerForm";
            Text = "ImageResizerForm";
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
        private TextBox txtHeight;
        private TextBox txtWidth;
        private Label label3;
        private Label label4;
    }
}
