using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace image_resizing
{
    public partial class ImageResizingForm : Form
    {
        public ImageResizingForm()
        {
            InitializeComponent();
        }

        public static void Resize(string srcPath, int width, int height)
        {
            Image image = Image.FromFile(srcPath);
            Bitmap resultImage = Resize(image, width, height);
            resultImage.Save(srcPath.Replace(".png", "_" + width + "x" + height + ".png"));
        }

        public static Bitmap Resize(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(
                        image,
                        destRect,
                        0,
                        0,
                        image.Width,
                        image.Height,
                        GraphicsUnit.Pixel,
                        wrapMode
                    );
                }
            }

            return destImage;
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
                Bitmap image = new Bitmap(ofd.FileName);
                PicBeforeResize.SizeMode = PictureBoxSizeMode.Zoom;
                PicBeforeResize.Image = image;

                txtFileName.Text = ofd.FileName;

                txtCurrentSize.Text = $"{image.Width} x {image.Height} px";
                txtCurrentSize.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void BtnResize_Click(object sender, EventArgs e) { }
    }
}
