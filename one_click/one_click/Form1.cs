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
            picture.Show();
        }

        private void begin_Click(object sender, EventArgs e)
        {
            beginpic_Click_1(sender, EventArgs.Empty);
        }

        public Bitmap origin_size_image, image_l, image_l1;
        public float w, h;
        public int a;
        private void open_Click(object sender, EventArgs e)
        {
          //  origin_size_image = new Bitmap();
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

                if (origin_size_image.Width >= 88 && origin_size_image.Width >= origin_size_image.Height)
                {
                    float k = (float)origin_size_image.Width / 88;
                    w = 88;
                    h = origin_size_image.Height / k;
                }
                else if (origin_size_image.Height >= 50 && origin_size_image.Width < origin_size_image.Height)
                {
                    float k = (float)origin_size_image.Height / 50;
                    h = 50;
                    w = origin_size_image.Width / k;
                }

                image_l = new Bitmap(origin_size_image, (int)w, (int)h);
                inversion();
                kern(image_l);
                inv.Image = image_l;

                image_l = new Bitmap(origin_size_image, (int)w, (int)h);
                sharpen();
                kern(image_l);
                shrp.Image = image_l;

                image_l = new Bitmap(origin_size_image, (int)w, (int)h);
                blur();
                kern(image_l);
                blr.Image = image_l;

                w = origin_size_image.Width;
                h = origin_size_image.Height;

                if (origin_size_image.Width >= 670 && origin_size_image.Width >= origin_size_image.Height)
                {
                    float k = (float)origin_size_image.Width / 670;
                    w = 670;
                    h = origin_size_image.Height / k;
                }
                else if (origin_size_image.Height >= 430 && origin_size_image.Width < origin_size_image.Height)
                {
                    float k = (float)origin_size_image.Height / 430;
                    h = 430;
                    w = origin_size_image.Width / k;
                }

                image_l = new Bitmap(origin_size_image, (int)w, (int)h);

                picture.Image = image_l;

                this.BackColor = Color.Black;
            }
        }

        private void inv_Click(object sender, EventArgs e)
        {
            image_l.Dispose();
            image_l = new Bitmap(origin_size_image, (int)w, (int)h);
            inversion();
            kern(image_l);
            picture.Image = image_l;
            a = 1;
        }

        private void shrp_Click(object sender, EventArgs e)
        {
            image_l.Dispose();
            image_l = new Bitmap(origin_size_image, (int)w, (int)h);
            sharpen();
            kern(image_l);
            picture.Image = image_l;
            a = 2;
        }

        private void blur_Click(object sender, EventArgs e)
        {
            image_l.Dispose();
            image_l = new Bitmap(origin_size_image, (int)w, (int)h);
            blur();
            kern(image_l);
            picture.Image = image_l;
            a = 3;
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
            kernel = new int[3, 3];

            kernel[0, 0] = 1;
            kernel[1, 0] = 1;
            kernel[2, 0] = 1;

            kernel[0, 1] = 1;
            kernel[1, 1] = 1;
            kernel[2, 1] = 1;

            kernel[0, 2] = 1;
            kernel[1, 2] = 1;
            kernel[2, 2] = 1;

            div = 9;
            offset = 0;
            kernel_h = kernel_w = 3;
        }



        private void save_Click(object sender, EventArgs e)
        {
            image_l.Dispose();
            var sfd = new SaveFileDialog();
            sfd.Filter = "Файл изображения|*.jpg";
            image_l = new Bitmap(origin_size_image); 


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
                        kern(image_l);
                        break;
                    case 2:

                        sharpen();
                        kern(image_l);
                        break;

                    case 3:
                        blur();
                        kern(image_l);
                        break;
                       
                }
                image_l.Save(fileStream, origin_size_image.RawFormat);
                fileStream.Close();
                image_l.Dispose();
            }
        }

        Bitmap kern(Bitmap image_l)
        {
        /*    if (image_l!=null)
            {
                image_l.Dispose();
            }*/
          
            image_l1 = (Bitmap)image_l.Clone();
            int rSum = 0, gSum = 0, bSum = 0;
            var color = new Color();
            for (int x = kernel_w / 2; x < image_l.Width - kernel_w / 2; x++)
            {
                for (int y = kernel_w / 2; y < image_l.Height - kernel_w / 2; y++)
                {
                    for (int j = 0; j < kernel_w; j++)
                    {
                        for (int i = 0; i < kernel_h; i++)
                        {
                            color = image_l1.GetPixel(x - kernel_h / 2 + i, y - kernel_w / 2 + j);

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

                    image_l.SetPixel(x, y, Color.FromArgb((byte)rSum, (byte)gSum, (byte)bSum));
                    rSum = gSum = bSum = 0;
                }
            }
            image_l1.Dispose();
            return image_l;
        }
    }

}

