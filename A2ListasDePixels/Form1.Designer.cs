namespace A2ListasDePixels
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInvertida = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrdenarEscuroClaro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrdenarClaroEscuro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveMetadeInferior = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveMetadeSuperior = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPintarEsquerdaAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPintarDireitaLaranja = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDuplicarMetadeBaixo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDuplicarMetadeCima = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCorMedia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCorMaisClara = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCorMaisEscura = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVirarHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(320, 320);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imagemToolStripMenuItem
            // 
            this.imagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNormal,
            this.mnuInvertida,
            this.mnuOrdenarEscuroClaro,
            this.mnuOrdenarClaroEscuro,
            this.mnuRemoveMetadeInferior,
            this.mnuRemoveMetadeSuperior,
            this.mnuPintarEsquerdaAzul,
            this.mnuPintarDireitaLaranja,
            this.mnuDuplicarMetadeBaixo,
            this.mnuDuplicarMetadeCima,
            this.mnuCorMedia,
            this.mnuCorMaisClara,
            this.mnuCorMaisEscura,
            this.mnuVirarHorizontal});
            this.imagemToolStripMenuItem.Name = "imagemToolStripMenuItem";
            this.imagemToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.imagemToolStripMenuItem.Text = "Imagem";
            // 
            // mnuNormal
            // 
            this.mnuNormal.Name = "mnuNormal";
            this.mnuNormal.Size = new System.Drawing.Size(237, 22);
            this.mnuNormal.Text = "Normal";
            this.mnuNormal.Click += new System.EventHandler(this.mnuNormal_Click);
            // 
            // mnuInvertida
            // 
            this.mnuInvertida.Name = "mnuInvertida";
            this.mnuInvertida.Size = new System.Drawing.Size(237, 22);
            this.mnuInvertida.Text = "Inverter";
            this.mnuInvertida.Click += new System.EventHandler(this.mnuInvertida_Click);
            // 
            // mnuOrdenarEscuroClaro
            // 
            this.mnuOrdenarEscuroClaro.Name = "mnuOrdenarEscuroClaro";
            this.mnuOrdenarEscuroClaro.Size = new System.Drawing.Size(237, 22);
            this.mnuOrdenarEscuroClaro.Text = "Ordenar do escuro para o claro";
            this.mnuOrdenarEscuroClaro.Click += new System.EventHandler(this.mnuOrdenarEscuroClaro_Click);
            // 
            // mnuOrdenarClaroEscuro
            // 
            this.mnuOrdenarClaroEscuro.Name = "mnuOrdenarClaroEscuro";
            this.mnuOrdenarClaroEscuro.Size = new System.Drawing.Size(237, 22);
            this.mnuOrdenarClaroEscuro.Text = "Ordenar do claro para o escuro";
            this.mnuOrdenarClaroEscuro.Click += new System.EventHandler(this.mnuOrdenarClaroEscuro_Click);
            // 
            // mnuRemoveMetadeInferior
            // 
            this.mnuRemoveMetadeInferior.Name = "mnuRemoveMetadeInferior";
            this.mnuRemoveMetadeInferior.Size = new System.Drawing.Size(237, 22);
            this.mnuRemoveMetadeInferior.Text = "Remove metade inferior";
            this.mnuRemoveMetadeInferior.Click += new System.EventHandler(this.mnuRemoveMetadeInferior_Click);
            // 
            // mnuRemoveMetadeSuperior
            // 
            this.mnuRemoveMetadeSuperior.Name = "mnuRemoveMetadeSuperior";
            this.mnuRemoveMetadeSuperior.Size = new System.Drawing.Size(237, 22);
            this.mnuRemoveMetadeSuperior.Text = "Remove metade superior";
            this.mnuRemoveMetadeSuperior.Click += new System.EventHandler(this.mnuRemoveMetadeSuperior_Click);
            // 
            // mnuPintarEsquerdaAzul
            // 
            this.mnuPintarEsquerdaAzul.Name = "mnuPintarEsquerdaAzul";
            this.mnuPintarEsquerdaAzul.Size = new System.Drawing.Size(237, 22);
            this.mnuPintarEsquerdaAzul.Text = "Pintar esquerda de azul";
            this.mnuPintarEsquerdaAzul.Click += new System.EventHandler(this.mnuPintarEsquerdaAzul_Click);
            // 
            // mnuPintarDireitaLaranja
            // 
            this.mnuPintarDireitaLaranja.Name = "mnuPintarDireitaLaranja";
            this.mnuPintarDireitaLaranja.Size = new System.Drawing.Size(237, 22);
            this.mnuPintarDireitaLaranja.Text = "Pintar direita de laranja";
            this.mnuPintarDireitaLaranja.Click += new System.EventHandler(this.mnuPintarDireitaLaranja_Click);
            // 
            // mnuDuplicarMetadeBaixo
            // 
            this.mnuDuplicarMetadeBaixo.Name = "mnuDuplicarMetadeBaixo";
            this.mnuDuplicarMetadeBaixo.Size = new System.Drawing.Size(237, 22);
            this.mnuDuplicarMetadeBaixo.Text = "Duplicar metade de baixo";
            this.mnuDuplicarMetadeBaixo.Click += new System.EventHandler(this.mnuDuplicarMetadeBaixo_Click);
            // 
            // mnuDuplicarMetadeCima
            // 
            this.mnuDuplicarMetadeCima.Name = "mnuDuplicarMetadeCima";
            this.mnuDuplicarMetadeCima.Size = new System.Drawing.Size(237, 22);
            this.mnuDuplicarMetadeCima.Text = "Duplicar metade de cima";
            this.mnuDuplicarMetadeCima.Click += new System.EventHandler(this.mnuDuplicarMetadeCima_Click);
            // 
            // mnuCorMedia
            // 
            this.mnuCorMedia.Name = "mnuCorMedia";
            this.mnuCorMedia.Size = new System.Drawing.Size(237, 22);
            this.mnuCorMedia.Text = "Cor média";
            this.mnuCorMedia.Click += new System.EventHandler(this.mnuCorMedia_Click);
            // 
            // mnuCorMaisClara
            // 
            this.mnuCorMaisClara.Name = "mnuCorMaisClara";
            this.mnuCorMaisClara.Size = new System.Drawing.Size(237, 22);
            this.mnuCorMaisClara.Text = "Cor mais clara";
            this.mnuCorMaisClara.Click += new System.EventHandler(this.mnuCorMaisClara_Click);
            // 
            // mnuCorMaisEscura
            // 
            this.mnuCorMaisEscura.Name = "mnuCorMaisEscura";
            this.mnuCorMaisEscura.Size = new System.Drawing.Size(237, 22);
            this.mnuCorMaisEscura.Text = "Cor mais escura";
            this.mnuCorMaisEscura.Click += new System.EventHandler(this.mnuCorMaisEscura_Click);
            // 
            // mnuVirarHorizontal
            // 
            this.mnuVirarHorizontal.Name = "mnuVirarHorizontal";
            this.mnuVirarHorizontal.Size = new System.Drawing.Size(237, 22);
            this.mnuVirarHorizontal.Text = "Virar Horizontal";
            this.mnuVirarHorizontal.Click += new System.EventHandler(this.mnuVirarHorizontal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 404);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNormal;
        private System.Windows.Forms.ToolStripMenuItem mnuOrdenarEscuroClaro;
        private System.Windows.Forms.ToolStripMenuItem mnuOrdenarClaroEscuro;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveMetadeInferior;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveMetadeSuperior;
        private System.Windows.Forms.ToolStripMenuItem mnuPintarEsquerdaAzul;
        private System.Windows.Forms.ToolStripMenuItem mnuPintarDireitaLaranja;
        private System.Windows.Forms.ToolStripMenuItem mnuDuplicarMetadeCima;
        private System.Windows.Forms.ToolStripMenuItem mnuInvertida;
        private System.Windows.Forms.ToolStripMenuItem mnuDuplicarMetadeBaixo;
        private System.Windows.Forms.ToolStripMenuItem mnuCorMedia;
        private System.Windows.Forms.ToolStripMenuItem mnuCorMaisClara;
        private System.Windows.Forms.ToolStripMenuItem mnuCorMaisEscura;
        private System.Windows.Forms.ToolStripMenuItem mnuVirarHorizontal;
    }
}

