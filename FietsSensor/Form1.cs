using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using MLSmoothingMethod;
using MathWorks.MATLAB.NET.Arrays;

namespace FietsSensor
{
    public partial class Form1 : Form
    {

        public class DirectBitmap : IDisposable
        {
            public Bitmap Bitmap { get; private set; }
            public byte[] Bits { get; private set; }
            public bool Disposed { get; private set; }
            public int Height { get; private set; }
            public int Width { get; private set; }

            protected GCHandle BitsHandle { get; private set; }

            public DirectBitmap(int width, int height)
            {
                Width = width;
                Height = height;
                Bits = new byte[width * height * 4];
                BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
                Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppRgb, BitsHandle.AddrOfPinnedObject());
            }

            public void SetPixel(int x, int y, Color colour)
            {
                int index = (x + (y * Width)) * 4;
                byte[] argb = BitConverter.GetBytes(colour.ToArgb());
                for (int i = 0; i < 4; i++)
                {
                    Bits[index + i] = argb[i];
                }
            }

            public Color GetPixel(int x, int y)
            {
                int index = (x + (y * Width)) * 4;
                Color result = Color.FromArgb(
                    Bits[index + 0],
                    Bits[index + 1],
                    Bits[index + 2],
                    Bits[index + 3]
                );

                return result;
            }

            public void Dispose()
            {
                if (Disposed) return;
                Disposed = true;
                Bitmap.Dispose();
                BitsHandle.Free();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtFilename.Text = file.FileName;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbSmoothing.SelectedIndex == 0)
            {
                try
                {
                    CSmoothing CMovingAvg = new CSmoothing();
                    MWArray[] result = CMovingAvg.MovingAvg(3, txtFilename.Text, (int)nudWindow.Value);
                    MWArray Index = (MWArray)result[0];
                    MWArray Speed = (MWArray)result[1];
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Index" + "    ");
                    sb.Append("Speed");
                    sb.Append(Environment.NewLine);
                    for (int row = 1; row <= Speed.Dimensions[0]; row++)
                    {
                        sb.Append(string.Format("{0,3}", Index[new int[] { row, 1 }]) + "        ");
                        sb.Append(string.Format("{0,3}", Speed[new int[] { row, 1 }]));
                        sb.Append(Environment.NewLine);
                    }
                    txtResult.Text = sb.ToString();

                    int width = result[2].Dimensions[1];
                    int height = result[2].Dimensions[0];

                    byte[,,] output = (byte[,,])result[2].ToArray();

                    DirectBitmap directBitmap = new DirectBitmap(width, height);

                    for (int x = 0; x < width; x++)
                    {
                        for (int y = 0; y < height; y++)
                        {
                            directBitmap.Bits[(y * width + x) * 4 + 0] = output[2, y, x]; // R
                            directBitmap.Bits[(y * width + x) * 4 + 1] = output[1, y, x]; // G
                            directBitmap.Bits[(y * width + x) * 4 + 2] = output[0, y, x]; // B
                            directBitmap.Bits[(y * width + x) * 4 + 3] = 255;  // alpha
                        }
                    }
                    pbxPlot.Image = directBitmap.Bitmap;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Oops: " + ex.Message);
                }
            }
            else if (cmbSmoothing.SelectedIndex == 1)
            {
                try
                {
                    CSmoothing CExpSmooth = new CSmoothing();
                    MWArray[] result = CExpSmooth.ExpSmooth(3, txtFilename.Text, (double)nudAlpha.Value);
                    MWArray Index = (MWArray)result[0];
                    MWArray Speed = (MWArray)result[1];
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Index" + "    ");
                    sb.Append("Speed");
                    sb.Append(Environment.NewLine);
                    for (int row = 1; row <= Speed.Dimensions[0]; row++)
                    {
                        sb.Append(string.Format("{0,3}", Index[new int[] { row, 1 }]) + "        ");
                        sb.Append(string.Format("{0,3}", Speed[new int[] { row, 1 }]));
                        sb.Append(Environment.NewLine);
                    }
                    txtResult.Text = sb.ToString();

                    int width = result[2].Dimensions[1];
                    int height = result[2].Dimensions[0];

                    byte[,,] output = (byte[,,])result[2].ToArray();

                    DirectBitmap directBitmap = new DirectBitmap(width, height);

                    for (int x = 0; x < width; x++)
                    {
                        for (int y = 0; y < height; y++)
                        {
                            directBitmap.Bits[(y * width + x) * 4 + 0] = output[2, y, x]; // R
                            directBitmap.Bits[(y * width + x) * 4 + 1] = output[1, y, x]; // G
                            directBitmap.Bits[(y * width + x) * 4 + 2] = output[0, y, x]; // B
                            directBitmap.Bits[(y * width + x) * 4 + 3] = 255;  // alpha
                        }
                    }
                    pbxPlot.Image = directBitmap.Bitmap;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Oops: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSmoothing.SelectedIndex = 0;
        }

        private void cmbSmoothing_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblWindow.Visible = cmbSmoothing.SelectedIndex == 0;
            nudWindow.Visible = cmbSmoothing.SelectedIndex == 0;
            lblAlpha.Visible = cmbSmoothing.SelectedIndex == 1;
            nudAlpha.Visible = cmbSmoothing.SelectedIndex == 1;
        }
    }
}
