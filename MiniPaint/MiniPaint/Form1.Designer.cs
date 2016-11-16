namespace MiniPaint
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
            this.cuadroImagen = new System.Windows.Forms.PictureBox();
            this.grupoFiguras = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkRelleno = new System.Windows.Forms.CheckBox();
            this.radioElipse = new System.Windows.Forms.RadioButton();
            this.radioRectangulo = new System.Windows.Forms.RadioButton();
            this.radioLinea = new System.Windows.Forms.RadioButton();
            this.grupoColores = new System.Windows.Forms.GroupBox();
            this.cuadroColorSecundario = new System.Windows.Forms.PictureBox();
            this.cuadroColorPrimario = new System.Windows.Forms.PictureBox();
            this.nudGrosorLinea = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cuadroPuntoInicial = new System.Windows.Forms.TextBox();
            this.cuadroPuntoFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroImagen)).BeginInit();
            this.grupoFiguras.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grupoColores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroColorSecundario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroColorPrimario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosorLinea)).BeginInit();
            this.SuspendLayout();
            // 
            // cuadroImagen
            // 
            this.cuadroImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cuadroImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cuadroImagen.Location = new System.Drawing.Point(146, 27);
            this.cuadroImagen.Name = "cuadroImagen";
            this.cuadroImagen.Size = new System.Drawing.Size(458, 260);
            this.cuadroImagen.TabIndex = 0;
            this.cuadroImagen.TabStop = false;
            this.cuadroImagen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cuadroImagen_MouseDown);
            this.cuadroImagen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cuadroImagen_MouseUp);
            // 
            // grupoFiguras
            // 
            this.grupoFiguras.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.grupoFiguras.Location = new System.Drawing.Point(0, 0);
            this.grupoFiguras.Name = "grupoFiguras";
            this.grupoFiguras.Size = new System.Drawing.Size(616, 24);
            this.grupoFiguras.TabIndex = 1;
            this.grupoFiguras.Text = "menuStrip1";
            this.grupoFiguras.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.grupoFiguras_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuNuevo,
            this.itemMenuSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // itemMenuNuevo
            // 
            this.itemMenuNuevo.Name = "itemMenuNuevo";
            this.itemMenuNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.itemMenuNuevo.Size = new System.Drawing.Size(152, 22);
            this.itemMenuNuevo.Text = "Nuevo";
            this.itemMenuNuevo.Click += new System.EventHandler(this.itemMenuNuevo_Click);
            // 
            // itemMenuSalir
            // 
            this.itemMenuSalir.Name = "itemMenuSalir";
            this.itemMenuSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.itemMenuSalir.Size = new System.Drawing.Size(152, 22);
            this.itemMenuSalir.Text = "Salir";
            this.itemMenuSalir.Click += new System.EventHandler(this.itemMenuSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkRelleno);
            this.groupBox1.Controls.Add(this.radioElipse);
            this.groupBox1.Controls.Add(this.radioRectangulo);
            this.groupBox1.Controls.Add(this.radioLinea);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figuras:";
            // 
            // checkRelleno
            // 
            this.checkRelleno.AutoSize = true;
            this.checkRelleno.Location = new System.Drawing.Point(7, 101);
            this.checkRelleno.Name = "checkRelleno";
            this.checkRelleno.Size = new System.Drawing.Size(97, 17);
            this.checkRelleno.TabIndex = 3;
            this.checkRelleno.Text = "Rellenar Figura";
            this.checkRelleno.UseVisualStyleBackColor = true;
            this.checkRelleno.CheckedChanged += new System.EventHandler(this.checkRelleno_CheckedChanged);
            // 
            // radioElipse
            // 
            this.radioElipse.AutoSize = true;
            this.radioElipse.Location = new System.Drawing.Point(7, 77);
            this.radioElipse.Name = "radioElipse";
            this.radioElipse.Size = new System.Drawing.Size(53, 17);
            this.radioElipse.TabIndex = 2;
            this.radioElipse.Text = "Elipse";
            this.radioElipse.UseVisualStyleBackColor = true;
            // 
            // radioRectangulo
            // 
            this.radioRectangulo.AutoSize = true;
            this.radioRectangulo.Location = new System.Drawing.Point(7, 55);
            this.radioRectangulo.Name = "radioRectangulo";
            this.radioRectangulo.Size = new System.Drawing.Size(80, 17);
            this.radioRectangulo.TabIndex = 1;
            this.radioRectangulo.Text = "Rectángulo";
            this.radioRectangulo.UseVisualStyleBackColor = true;
            this.radioRectangulo.CheckedChanged += new System.EventHandler(this.radioRectangulo_CheckedChanged);
            // 
            // radioLinea
            // 
            this.radioLinea.AutoSize = true;
            this.radioLinea.Checked = true;
            this.radioLinea.Location = new System.Drawing.Point(7, 33);
            this.radioLinea.Name = "radioLinea";
            this.radioLinea.Size = new System.Drawing.Size(51, 17);
            this.radioLinea.TabIndex = 0;
            this.radioLinea.TabStop = true;
            this.radioLinea.Text = "Linea";
            this.radioLinea.UseVisualStyleBackColor = true;
            this.radioLinea.CheckedChanged += new System.EventHandler(this.radioLinea_CheckedChanged);
            // 
            // grupoColores
            // 
            this.grupoColores.Controls.Add(this.cuadroColorSecundario);
            this.grupoColores.Controls.Add(this.cuadroColorPrimario);
            this.grupoColores.Location = new System.Drawing.Point(12, 223);
            this.grupoColores.Name = "grupoColores";
            this.grupoColores.Size = new System.Drawing.Size(128, 64);
            this.grupoColores.TabIndex = 3;
            this.grupoColores.TabStop = false;
            this.grupoColores.Text = "Colores:";
            // 
            // cuadroColorSecundario
            // 
            this.cuadroColorSecundario.BackColor = System.Drawing.Color.Olive;
            this.cuadroColorSecundario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cuadroColorSecundario.Location = new System.Drawing.Point(61, 19);
            this.cuadroColorSecundario.Name = "cuadroColorSecundario";
            this.cuadroColorSecundario.Size = new System.Drawing.Size(49, 29);
            this.cuadroColorSecundario.TabIndex = 1;
            this.cuadroColorSecundario.TabStop = false;
            this.cuadroColorSecundario.Click += new System.EventHandler(this.cuadroColorSecundario_Click);
            // 
            // cuadroColorPrimario
            // 
            this.cuadroColorPrimario.BackColor = System.Drawing.Color.Silver;
            this.cuadroColorPrimario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cuadroColorPrimario.Location = new System.Drawing.Point(6, 19);
            this.cuadroColorPrimario.Name = "cuadroColorPrimario";
            this.cuadroColorPrimario.Size = new System.Drawing.Size(49, 29);
            this.cuadroColorPrimario.TabIndex = 0;
            this.cuadroColorPrimario.TabStop = false;
            this.cuadroColorPrimario.Click += new System.EventHandler(this.cuadroColorPrimario_Click);
            // 
            // nudGrosorLinea
            // 
            this.nudGrosorLinea.Location = new System.Drawing.Point(89, 187);
            this.nudGrosorLinea.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGrosorLinea.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGrosorLinea.Name = "nudGrosorLinea";
            this.nudGrosorLinea.Size = new System.Drawing.Size(43, 20);
            this.nudGrosorLinea.TabIndex = 4;
            this.nudGrosorLinea.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGrosorLinea.ValueChanged += new System.EventHandler(this.nudGrosorLinea_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grosor Linea:";
            // 
            // cuadroPuntoInicial
            // 
            this.cuadroPuntoInicial.Location = new System.Drawing.Point(238, 293);
            this.cuadroPuntoInicial.Name = "cuadroPuntoInicial";
            this.cuadroPuntoInicial.Size = new System.Drawing.Size(100, 20);
            this.cuadroPuntoInicial.TabIndex = 6;
            // 
            // cuadroPuntoFinal
            // 
            this.cuadroPuntoFinal.Location = new System.Drawing.Point(436, 293);
            this.cuadroPuntoFinal.Name = "cuadroPuntoFinal";
            this.cuadroPuntoFinal.Size = new System.Drawing.Size(100, 20);
            this.cuadroPuntoFinal.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Punto Inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Punto Final:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cuadroPuntoFinal);
            this.Controls.Add(this.cuadroPuntoInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudGrosorLinea);
            this.Controls.Add(this.grupoColores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cuadroImagen);
            this.Controls.Add(this.grupoFiguras);
            this.MainMenuStrip = this.grupoFiguras;
            this.Name = "Form1";
            this.Text = "Mini Paint";
            ((System.ComponentModel.ISupportInitialize)(this.cuadroImagen)).EndInit();
            this.grupoFiguras.ResumeLayout(false);
            this.grupoFiguras.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grupoColores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cuadroColorSecundario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroColorPrimario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosorLinea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cuadroImagen;
        private System.Windows.Forms.MenuStrip grupoFiguras;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMenuSalir;
        private System.Windows.Forms.ToolStripMenuItem itemMenuNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioElipse;
        private System.Windows.Forms.RadioButton radioRectangulo;
        private System.Windows.Forms.RadioButton radioLinea;
        private System.Windows.Forms.GroupBox grupoColores;
        private System.Windows.Forms.PictureBox cuadroColorSecundario;
        private System.Windows.Forms.PictureBox cuadroColorPrimario;
        private System.Windows.Forms.NumericUpDown nudGrosorLinea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cuadroPuntoInicial;
        private System.Windows.Forms.TextBox cuadroPuntoFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkRelleno;
    }
}

