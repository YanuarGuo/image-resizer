using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace image_resizing
{
    public partial class ImageResizingForm : Form
    {
        private Bitmap originalImage;
        private string loadedFilePath;
        private int newWidth;
        private int newHeight;

        public ImageResizingForm()
        {
            InitializeComponent();
        }

        private void BtnAddPhoto_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter =
                    "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png",
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                loadedFilePath = ofd.FileName;
                originalImage = new Bitmap(loadedFilePath);

                PicBeforeResize.SizeMode = PictureBoxSizeMode.Zoom;
                PicBeforeResize.Image = originalImage;

                txtFileName.Text = loadedFilePath;
                txtCurrentSize.Text = $"{originalImage.Width} x {originalImage.Height} px";
                txtCurrentSize.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void BtnResize_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show(
                    "Please load an image first.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!int.TryParse(txtWidth.Text, out int newWidth) || newWidth <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid positive number for width.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!int.TryParse(txtHeight.Text, out int newHeight) || newHeight <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid positive number for height.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Bitmap resizedImage = Resize(originalImage, newWidth, newHeight);
            PicAfterResize.Image = resizedImage;

            string newFilePath = loadedFilePath.Insert(
                loadedFilePath.LastIndexOf('.'),
                $"_Resized"
            );
            resizedImage.Save(newFilePath, ImageFormat.Jpeg);

            MessageBox.Show(
                $"Image resized and saved as:\n{newFilePath}",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private static Bitmap Resize(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.CompositingQuality = CompositingQuality.HighQuality;

                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }
    }
}
