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

namespace A2ListasDePixels
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
                }
            }
        }

        #region Update Image
        private void UpdateImageNormal()
        {
            List<Color> copiaCores = new List<Color>(cores);
            VisualizarIcone(copiaCores);
        }

        private void UpdateImageInvertida()
        {
            List<Color> copiaCores = new List<Color>(cores);
            copiaCores.Reverse(); // inverter a imagem
            VisualizarIcone(copiaCores);
        }

        private void UpdateImageOrdenarEscuroClaro()
        {
            List<Color> copiaCores = new List<Color>(cores);
            var ordenado = copiaCores
                .OrderBy(c => c.A + c.R + c.G + c.B)
                .ToList(); //do mais escuro para o mais claro
            VisualizarIcone(ordenado);
        }

        private void UpdateImageOrdenarClaroEscuro()
        {
            List<Color> copiaCores = new List<Color>(cores);
            var ordenado = copiaCores
                .OrderByDescending(c => c.A + c.R + c.G + c.B)
                .ToList(); //do mais claro para o mais escuro

            VisualizarIcone(ordenado);
        }

        private void UpdateImageRemoveMetadeInferior()
        {
            List<Color> copiaCores = new List<Color>(cores);
            copiaCores.RemoveRange(bitmap.Width * (bitmap.Height / 2), bitmap.Width * (bitmap.Height / 2)); // remove a metade de baixo
            copiaCores.AddRange(Enumerable
                .Range(0, bitmap.Width * (bitmap.Height / 2))
                .Select(x => Color.White));
            VisualizarIcone(copiaCores);
        }

        private void UpdateImageRemoveMetadeSuperior()
        {
            List<Color> copiaCores = new List<Color>(cores);
            copiaCores.RemoveRange(0, bitmap.Width * (bitmap.Height / 2)); //remove a metade de cima
            copiaCores.InsertRange(0, Enumerable
                .Range(0, bitmap.Width * (bitmap.Height / 2))
                .Select(x => Color.White));
            VisualizarIcone(copiaCores);
        }

        private void UpdateImagePintarEsquerdaAzul()
        {
            List<Color> copiaCores = new List<Color>(cores);

            //PINTA A PARTE ESQUERDA DE AZUL
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    if (x < bitmap.Width / 2)
                    {
                        copiaCores[x + y * bitmap.Height] = Color.DarkBlue;
                    }
                }
            }
            VisualizarIcone(copiaCores);
        }

        private void UpdateImagePintarDireitaLaranja()
        {
            List<Color> copiaCores = new List<Color>(cores);
            //PINTA A PARTE DIREITA DE LARANJA
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    if (x >= bitmap.Width / 2)
                    {
                        copiaCores[x + y * bitmap.Height] = Color.Orange;
                    }
                }
            }
            VisualizarIcone(copiaCores);
        }

        private void UpdateImageDuplicarMetadeBaixo()
        {
            List<Color> copiaCores = new List<Color>(cores);
            ////DUPLICA A METADE DE CIMA
            copiaCores.RemoveRange(0, bitmap.Width * (bitmap.Height / 2)); // remove a parte de baixo
            copiaCores.AddRange(copiaCores); // copia a metade de cima pra baixo
            VisualizarIcone(copiaCores);
        }

        private void UpdateImageDuplicarMetadeCima()
        {
            List<Color> copiaCores = new List<Color>(cores);
            ////DUPLICA A METADE DE CIMA
            copiaCores.RemoveRange(bitmap.Width * (bitmap.Height / 2), bitmap.Width * (bitmap.Height / 2)); // remove a parte de baixo
            copiaCores.AddRange(copiaCores); // copia a metade de cima pra baixo
            VisualizarIcone(copiaCores);
        }

        private void UpdateImageCorMedia()
        {
            List<Color> copiaCores = new List<Color>(cores);

            int corMediaA = (int)copiaCores.Average(c => c.A); 
            int corMediaR = (int)copiaCores.Average(c => c.R);
            int corMediaG = (int)copiaCores.Average(c => c.G);
            int corMediaB = (int)copiaCores.Average(c => c.B);
            Color corMedia = Color.FromArgb(corMediaA, corMediaR, corMediaG, corMediaB);

            for (int i = 0; i < copiaCores.Count; i++)
            {
                copiaCores[i] = corMedia;
            }
            
            VisualizarIcone(copiaCores);
        }

        private void UpdateImageCorMaisClara()
        {
            List<Color> copiaCores = new List<Color>(cores);

            Color corMaisClara = copiaCores.OrderBy(c => c.A + c.R + c.G + c.B).First();
            
            for (int i = 0; i < copiaCores.Count; i++)
            {
                copiaCores[i] = corMaisClara;
            }

            VisualizarIcone(copiaCores);
        }

        private void UpdateImageCorMaisEscura()
        {
            List<Color> copiaCores = new List<Color>(cores);

            Color corMaisEscura = copiaCores.OrderBy(c => c.A + c.R + c.G + c.B).Last();

            for (int i = 0; i < copiaCores.Count; i++)
            {
                copiaCores[i] = corMaisEscura;
            }

            VisualizarIcone(copiaCores);
        }

        private void UpdateVirarHorizontal()
        {
            List<Color> copiaCores = new List<Color>(cores);

            var query
                = copiaCores
                    .Select((c, i) => new { Cor = c, Index = i })
                    .GroupBy(x => x.Index / bitmap.Width)
                    .Select(x => x.Select(v => v.Cor).Reverse().ToList())
                    .ToList();

            var linhasInvertidas = query.SelectMany(x => x).ToList();

            VisualizarIcone(linhasInvertidas);
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

        private void VisualizarIcone(List<Color> cores)
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

        #region Eventos
        private void mnuNormal_Click(object sender, EventArgs e)
        {
            UpdateImageNormal();
        }

        private void mnuInvertida_Click(object sender, EventArgs e)
        {
            UpdateImageInvertida();
        }

        private void mnuOrdenarEscuroClaro_Click(object sender, EventArgs e)
        {
            UpdateImageOrdenarEscuroClaro();
        }

        private void mnuOrdenarClaroEscuro_Click(object sender, EventArgs e)
        {
            UpdateImageOrdenarClaroEscuro();
        }

        private void mnuRemoveMetadeInferior_Click(object sender, EventArgs e)
        {
            UpdateImageRemoveMetadeInferior();
        }

        private void mnuRemoveMetadeSuperior_Click(object sender, EventArgs e)
        {
            UpdateImageRemoveMetadeSuperior();
        }

        private void mnuPintarEsquerdaAzul_Click(object sender, EventArgs e)
        {
            UpdateImagePintarEsquerdaAzul();
        }

        private void mnuPintarDireitaLaranja_Click(object sender, EventArgs e)
        {
            UpdateImagePintarDireitaLaranja();
        }

        private void mnuDuplicarMetadeBaixo_Click(object sender, EventArgs e)
        {
            UpdateImageDuplicarMetadeBaixo();
        }

        private void mnuDuplicarMetadeCima_Click(object sender, EventArgs e)
        {
            UpdateImageDuplicarMetadeCima();
        }

        private void mnuCorMedia_Click(object sender, EventArgs e)
        {
            UpdateImageCorMedia();
        }

        private void mnuCorMaisClara_Click(object sender, EventArgs e)
        {
            UpdateImageCorMaisClara();
        }

        private void mnuCorMaisEscura_Click(object sender, EventArgs e)
        {
            UpdateImageCorMaisEscura();
        }

        private void mnuVirarHorizontal_Click(object sender, EventArgs e)
        {
            UpdateVirarHorizontal();
        }
        #endregion

    }
}
