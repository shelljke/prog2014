using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleImageProcessing;
//using AForge.Imaging;

namespace one_click
{
    public partial class mainwindow : Form
    {
        public byte div, offset;
        public int kernel_w, kernel_h;
        public int[,] kernel;
        public mainwindow()
        {
            InitializeComponent();
        }

        private void hi_Click(object sender, EventArgs e)
        {

        }

        private void beginpic_Click_1(object sender, EventArgs e)
        {
            hi.Hide();
            begin.Hide();
            beginpic.Hide();

            open.Show();
            save.Show();

            //   power.Show();

            fon.Show();
        }

        private void begin_Click(object sender, EventArgs e)
        {
            beginpic_Click_1(sender, EventArgs.Empty);
        }

        public Bitmap origin_size_image, image_l, nashville1, willow1;
        public ImagerBitmap dst, dsp, image_l1;
        public float w, h;
        public int a;

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog() { Filter = "Файл изображения|*.jpg" };
            var result = op.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                if (origin_size_image != null)
                {
                    origin_size_image.Dispose();
                }

                origin_size_image = (Bitmap)Image.FromFile(op.FileName);
                w = origin_size_image.Width;
                h = origin_size_image.Height;

                if (origin_size_image.Width >= 150 && origin_size_image.Width >= origin_size_image.Height)
                {
                    float k = (float)origin_size_image.Width / 150;
                    w = 150;
                    h = origin_size_image.Height / k;
                }
                else if (origin_size_image.Height >= 120 && origin_size_image.Width < origin_size_image.Height)
                {
                    float k = (float)origin_size_image.Height / 120;
                    h = 120;
                    w = origin_size_image.Width / k;
                }


                image_l = new Bitmap(origin_size_image, (int)w, (int)h);
                inversion();
                kern();
                inv.Image = image_l;

                image_l = new Bitmap(origin_size_image, (int)w, (int)h);
                sharpen();
                kern();
                shrp.Image = image_l;

                image_l = new Bitmap(origin_size_image, (int)w, (int)h);
                blur();
                kern();
                blr.Image = image_l;

                image_l = new Bitmap(origin_size_image, (int)w, (int)h);
                cold();
                cld.Image = image_l;

                image_l = new Bitmap(origin_size_image, (int)w, (int)h);
                hope();
                hp.Image = image_l;

                image_l = new Bitmap(origin_size_image, (int)w, (int)h);
                nashville();
                nshv.Image = image_l;

                image_l = new Bitmap(origin_size_image, (int)w, (int)h);
                willow();
                wlw.Image = image_l;

                w = origin_size_image.Width;
                h = origin_size_image.Height;

                if (origin_size_image.Width >= 1340 && origin_size_image.Width >= origin_size_image.Height)
                {
                    float k = (float)origin_size_image.Width / 1340;
                    w = 1340;
                    h = origin_size_image.Height / k;
                }
                if (origin_size_image.Height >= 860 && origin_size_image.Width < origin_size_image.Height)
                {
                    float k = (float)origin_size_image.Height / 860;
                    h = 860;
                    w = origin_size_image.Width / k;
                }
                image_l = new Bitmap(origin_size_image, (int)w, (int)h);

                // this.BackgroundImage = image_l;
                this.BackgroundImage = image_l;
                this.BackColor = Color.Black;
                fon.Show();
                fon.BackColor = Color.Transparent;
            }
        }

        private void inv_Click(object sender, EventArgs e)
        {
            image_l = new Bitmap(origin_size_image, (int)w, (int)h);
            inversion();
            kern();
            this.BackgroundImage = image_l;
            a = 1;
        }

        private void shrp_Click(object sender, EventArgs e)
        {

            image_l = new Bitmap(origin_size_image, (int)w, (int)h);
            sharpen();
            kern();
            this.BackgroundImage = image_l;
            a = 2;
        }

        private void blur_Click(object sender, EventArgs e)
        {
            image_l = new Bitmap(origin_size_image, (int)w, (int)h);
            blur();
            kern();
            this.BackgroundImage = image_l;
            a = 3;
        }

        private void cld_Click(object sender, EventArgs e)
        {
            image_l = new Bitmap(origin_size_image, (int)w, (int)h);
            cold();
            this.BackgroundImage = image_l;
            a = 4;
        }

        private void hp_Click(object sender, EventArgs e)
        {
            image_l = new Bitmap(origin_size_image, (int)w, (int)h);
            hope();
            a = 5;
            this.BackgroundImage = image_l;
        }

        private void nshv_Click(object sender, EventArgs e)
        {
            image_l = new Bitmap(origin_size_image, (int)w, (int)h);
            nashville();
            a = 6;
            this.BackgroundImage = image_l;
        }

        private void wlw_Click(object sender, EventArgs e)
        {
            image_l = new Bitmap(origin_size_image, (int)w, (int)h);
            willow();
            a = 7;
            this.BackgroundImage = image_l;
        }

        void inversion()
        {
            kernel = new int[1, 1];

            kernel[0, 0] = -1;

            div = 1;
            offset = 255;
            kernel_h = kernel_w = 1;
        }

        void sharpen()
        {
            kernel = new int[3, 3];

            kernel[0, 0] = -1;
            kernel[1, 0] = -1;
            kernel[2, 0] = -1;

            kernel[0, 1] = -1;
            kernel[1, 1] = 9;
            kernel[2, 1] = -1;

            kernel[0, 2] = -1;
            kernel[1, 2] = -1;
            kernel[2, 2] = -1;


            div = 1;
            offset = 0;
            kernel_h = kernel_w = 3;
        }

        void blur()
        {
            kernel = new int[7, 7];

            kernel[0, 0] = 1;
            kernel[1, 0] = 1;
            kernel[2, 0] = 1;
            kernel[3, 0] = 1;
            kernel[4, 0] = 1;
            kernel[5, 0] = 1;
            kernel[6, 0] = 1;

            kernel[0, 1] = 1;
            kernel[1, 1] = 1;
            kernel[2, 1] = 1;
            kernel[3, 1] = 1;
            kernel[4, 1] = 1;
            kernel[5, 1] = 1;
            kernel[6, 1] = 1;

            kernel[0, 2] = 1;
            kernel[1, 2] = 1;
            kernel[2, 2] = 1;
            kernel[3, 2] = 1;
            kernel[4, 2] = 1;
            kernel[5, 2] = 1;
            kernel[6, 2] = 1;

            kernel[0, 3] = 1;
            kernel[1, 3] = 1;
            kernel[2, 3] = 1;
            kernel[3, 3] = 1;
            kernel[4, 3] = 1;
            kernel[5, 3] = 1;
            kernel[6, 3] = 1;

            kernel[0, 4] = 1;
            kernel[1, 4] = 1;
            kernel[2, 4] = 1;
            kernel[3, 4] = 1;
            kernel[4, 4] = 1;
            kernel[5, 4] = 1;
            kernel[6, 4] = 1;

            kernel[0, 5] = 1;
            kernel[1, 5] = 1;
            kernel[2, 5] = 1;
            kernel[3, 5] = 1;
            kernel[4, 5] = 1;
            kernel[5, 5] = 1;
            kernel[6, 5] = 1;

            kernel[0, 6] = 1;
            kernel[1, 6] = 1;
            kernel[2, 6] = 1;
            kernel[3, 6] = 1;
            kernel[4, 6] = 1;
            kernel[5, 6] = 1;
            kernel[6, 6] = 1;


            div = 49;
            offset = 0;
            kernel_h = kernel_w = 7;
        }

        void cold()
        {

            GC.Collect();
            willow1 = new Bitmap(one_click.Properties.Resources.ramka, (int)w, (int)h);
            dst = new ImagerBitmap(image_l);
            dsp = new ImagerBitmap(willow1);

            Enumerable.Range(0, (int)w).AsParallel().ForAll(x =>
            {
                var color = new Color();
                var color1 = new Color();
                for (int y = 0; y < (int)h; y++)
                {
                    color = dst.GetPixel(x, y);
                    color1 = dsp.GetPixel(x, y);

                    float brght = color.GetBrightness();

                    byte r = color.R;
                    byte g = color.G;
                    byte b = color.B;

                    float brght1 = color1.GetBrightness();

                    byte r1 = color1.R;
                    byte g1 = color1.G;
                    byte b1 = color1.B;

                   r =(byte)((r*0.35+ ((brght) * r + (1-brght) *100)*0.65));
                   b = (byte)((b*0.7+((1-brght) * b + (brght) * 255)*0.3));

                    dst.SetPixel(x, y, Color.FromArgb((byte)(r * (1 - brght1) + r1 * brght1), (byte)(g * (1 - brght1) + g1 * brght1), (byte)(b * (1 - brght1) + b1 * brght1)));
                }
            });

            dst.UnlockBitmap();
            dsp.UnlockBitmap();
            image_l = dst.Bitmap;
        }

        private void save_Click(object sender, EventArgs e)
        {

            var sfd = new SaveFileDialog();
            sfd.Filter = "Файл изображения|*.jpg";
            image_l = new Bitmap(origin_size_image);
            h = origin_size_image.Height;
            w = origin_size_image.Width;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var fileName = sfd.FileName;
                var fileStream = File.Create(sfd.FileName);

                switch (a)
                {
                    case 0:
                        image_l = origin_size_image;
                        break;

                    case 1:
                        inversion();
                        kern();
                        break;

                    case 2:
                        sharpen();
                        kern();
                        break;

                    case 3:
                        blur();
                        kern();
                        break;

                    case 4:
                        cold();
                        break;

                    case 5:
                        hope();
                        break;

                    case 6:
                        nashville();
                        break;

                    case 7:
                        willow();
                        break;
                }
                image_l.Save(fileStream, origin_size_image.RawFormat);
                fileStream.Close();
                image_l.Dispose();
            }
        }
        void kern()
        {


            var dst = new ImagerBitmap(image_l);
            var image_l1 = new ImagerBitmap(image_l);


            Enumerable.Range(kernel_h / 2, (int)w - kernel_h / 2 - 1).AsParallel().ForAll(x =>
            {
                var color = new Color();
                int rSum = 0, gSum = 0, bSum = 0;
                for (int y = kernel_w / 2; y < (int)h - kernel_w / 2 - 1; y++)
                {

                    for (int j = 0; j < kernel_h; j++)
                    {

                        for (int i = 0; i < kernel_w; i++)
                        {
                            color = image_l1.GetPixel(x - kernel_h / 2 + i, y - kernel_h / 2 + j);

                            byte r = color.R;
                            byte g = color.G;
                            byte b = color.B;
                            int a = kernel[i, j];

                            rSum += r * a;
                            gSum += g * a;
                            bSum += b * a;
                        }

                    }
                    rSum /= div;
                    gSum /= div;
                    bSum /= div;

                    rSum += offset;
                    gSum += offset;
                    bSum += offset;

                    if (rSum > 255) rSum = 255;
                    if (rSum < 0) rSum = 0;

                    if (gSum > 255) gSum = 255;
                    if (gSum < 0) gSum = 0;

                    if (bSum > 255) bSum = 255;
                    if (bSum < 0) bSum = 0;

                    dst.SetPixel(x, y, Color.FromArgb((byte)rSum, (byte)gSum, (byte)bSum));
                    rSum = gSum = bSum = 0;
                }

            });
            image_l1.UnlockBitmap();

            dst.UnlockBitmap();
            image_l1.Bitmap.Dispose();
            image_l = dst.Bitmap;
        }

        void hope()
        {
            GC.Collect();
            dst = new ImagerBitmap(image_l);

            Enumerable.Range(0, (int)w - 1).AsParallel().ForAll(x =>
                   {
                       var color = new Color();
                       for (int y = 0; y < (int)h - 1; y++)
                       {
                           color = dst.GetPixel(x, y);

                           float brght = color.GetBrightness();
                           byte r = color.R;
                           byte g = color.G;
                           byte b = color.B;

                           if (brght <= 0.35)
                           {
                               r = 0;
                               g = 50;
                               b = 77;
                           };
                           if (brght > 0.35 & brght <= 0.55)
                           {
                               r = 215;
                               g = 26;
                               b = 33;
                           };
                           if (brght > 0.55)
                           {
                               r = 252;
                               g = 228;
                               b = 168;
                           };

                           dst.SetPixel(x, y, Color.FromArgb((byte)r, (byte)g, (byte)b));
                       }
                   });


            dst.UnlockBitmap();
            image_l = dst.Bitmap;
        }
        void nashville()
        {
            GC.Collect();
            nashville1 = new Bitmap(one_click.Properties.Resources.nashville, (int)w, (int)h);
            dst = new ImagerBitmap(image_l);
            dsp = new ImagerBitmap(nashville1);

            Enumerable.Range(0, (int)w).AsParallel().ForAll(x =>
            {
                var color = new Color();
                var color1 = new Color();
                for (int y = 0; y < (int)h; y++)
                {
                    color = dst.GetPixel(x, y);
                    color1 = dsp.GetPixel(x, y);
                    float brght = color.GetBrightness();

                    byte r = color.R;
                    byte g = color.G;
                    byte b = color.B;

                    byte r1 = color1.R;
                    byte g1 = color1.G;
                    byte b1 = color1.B;

                    b = (byte)(255 * brght);

                    dst.SetPixel(x, y, Color.FromArgb((byte)(r * 0.55 + r1 * 0.45), (byte)(g * 0.95 + g1 * 0.05), (byte)(b * 0.6 + b1 * 0.4)));

                }
            });

            dst.UnlockBitmap();
            dsp.UnlockBitmap();
            image_l = dst.Bitmap;
        }

        void willow()
        {
            GC.Collect();
            willow1 = new Bitmap(one_click.Properties.Resources.willow1, (int)w, (int)h);
            dst = new ImagerBitmap(image_l);
            dsp = new ImagerBitmap(willow1);

            Enumerable.Range(0, (int)w).AsParallel().ForAll(x =>
            {
                var color = new Color();
                var color1 = new Color();
                for (int y = 0; y < (int)h; y++)
                {
                    color = dst.GetPixel(x, y);
                    color1 = dsp.GetPixel(x, y);
                    float brght = color.GetBrightness();

                    byte r = color.R;
                    byte g = color.G;
                    byte b = color.B;

                    float brght1 = color1.GetBrightness();
                    byte r1 = color1.R;
                    byte g1 = color1.G;
                    byte b1 = color1.B;

                    g = b = r;

                    dst.SetPixel(x, y, Color.FromArgb((byte)(r * (1 - brght1) + r1 * brght1), (byte)(g * (1 - brght1) + g1 * brght1), (byte)(b * (1 - brght1) + b1 * brght1)));
                    // dst.SetPixel(x, y, Color.FromArgb((byte)(r * brght1 + r1 * (1 - brght1)), (byte)(g * brght1 + g1 * (1 - brght1)), (byte)(b * brght1 + b1 * (1 - brght1))));

                }
            });

            dst.UnlockBitmap();
            dsp.UnlockBitmap();
            image_l = dst.Bitmap;
        }

       

    }
}

