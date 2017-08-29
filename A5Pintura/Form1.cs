using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A5Pintura
{
    public partial class Form1 : Form
    {
        private const int LABEL_WIDTH = 20;
        private readonly Bitmap bitmap;
        private readonly ReadOnlyCollection<Color> cores;
        public Form1()
        {
            InitializeComponent();
            bitmap = GetIconBitmap();
            cores = ObterCores(bitmap);
            MontarPixels();
            UpdateImageNormal();
        }

        #region Update Image
        private void UpdateImageNormal()
        {
            List<Color> copiaCores = new List<Color>(cores);
            AtualizarPixels(copiaCores);
        }

        #endregion

        private Bitmap GetIconBitmap()
        {
            Bitmap bm = new Bitmap(32, 32);
            MemoryStream memStream;

            using (Stream stream = new FileStream("favicon.ico", FileMode.Open, FileAccess.Read))
            {
                memStream = new MemoryStream();
                byte[] buffer = new byte[1024];
                int byteCount;

                do
                {
                    byteCount = stream.Read(buffer, 0, buffer.Length);
                    memStream.Write(buffer, 0, byteCount);
                } while (byteCount > 0);
            }

            bm = new Bitmap(Image.FromStream(memStream));

            Icon ic = Icon.FromHandle(bm.GetHicon());
            this.Icon = ic;

            return bm;
        }

        private ReadOnlyCollection<Color> ObterCores(Bitmap bm)
        {
            List<Color> resultado = new List<Color>();

            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    var cor = bm.GetPixel(x, y);
                    resultado.Add(cor);
                }
            }
            return resultado.AsReadOnly();
        }

        private void MontarPixels()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Label label = new Label();
                    label.BorderStyle = BorderStyle.Fixed3D;
                    label.Padding =
                    label.Margin = new Padding(0);
                    label.Width =
                    label.Height = LABEL_WIDTH;
                    flowLayoutPanel1.Controls.Add(label);
                    label.Tag = new Point(x, y);
                    label.Click += Label_Click;
                }
            }
        }

        private void AtualizarPixels(List<Color> cores)
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    int indice = x + y * bitmap.Width;
                    Label label = flowLayoutPanel1.Controls[indice] as Label;
                    label.ForeColor =
                    label.BackColor = cores[x + y * bitmap.Width];
                }
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            List<Color> copiaCores = new List<Color>(cores);
            Point posicao = (Point)((Label)sender).Tag;
            Preencher(copiaCores, posicao, Color.Red);
            AtualizarPixels(copiaCores);
        }

        private void Preencher(List<Color> cores, Point ponto, Color corSubstituta)
        {
            Color corOriginal = cores[ponto.X + ponto.Y * bitmap.Width];
            Stack<Point> pixels = new Stack<Point>();
            corOriginal = cores[ponto.X + ponto.Y * bitmap.Width];
            pixels.Push(ponto);

            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                if (a.X < bitmap.Width && a.X >= 0 &&
                        a.Y < bitmap.Height && a.Y >= 0)//garantindo que esteja dentro dos limites
                {

                    Color cor = cores[a.X + a.Y * bitmap.Width];
                    if (cor == corOriginal)
                    {
                        cores[a.X + a.Y * bitmap.Width] = corSubstituta;
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
            return;
        }
    }
}
