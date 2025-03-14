using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageResizerApp
{
    public partial class ImageResizerForm : Form
    {
        private Bitmap? originalImage;
        private string? loadedFilePath;

        public ImageResizerForm()
        {
            InitializeComponent();
        }

        private void BtnAddPict_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new()
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
                txtCurrentSize.Text = $"{originalImage.Height} x {originalImage.Width} px";
                txtCurrentSize.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void BtnResize_Click(object sender, EventArgs e)
        {
            if (originalImage == null || string.IsNullOrEmpty(loadedFilePath))
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

            try
            {
                using Bitmap resizedImage = Resize(originalImage, newWidth, newHeight);
                PicAfterResize.SizeMode = PictureBoxSizeMode.Zoom;
                PicAfterResize.Image = resizedImage;

                string newFilePath = GetNextFileName(loadedFilePath);
                resizedImage.Save(newFilePath, ImageFormat.Jpeg);

                MessageBox.Show(
                    $"Image resized and saved as:\n{newFilePath}",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private static string GetNextFileName(string filePath)
        {
            int increment = 1;
            string? directory = Path.GetDirectoryName(filePath);
            string fileNameWithoutExt = Path.GetFileNameWithoutExtension(filePath);
            string extension = Path.GetExtension(filePath);
            string newFilePath;

            if (directory == null)
            {
                throw new ArgumentException(
                    "Directory cannot be determined from the file path.",
                    nameof(filePath)
                );
            }

            do
            {
                newFilePath = Path.Combine(
                    directory,
                    $"{fileNameWithoutExt}_Resized_{increment}{extension}"
                );
                increment++;
            } while (File.Exists(newFilePath));

            return newFilePath;
        }

        private static new Bitmap Resize(Image image, int width, int height)
        {
            Bitmap resizedImage = new(width, height);
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
