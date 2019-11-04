namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnestrella = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpdibujo = new System.Windows.Forms.TabPage();
            this.caja = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.setisx = new System.Windows.Forms.Label();
            this.setisY = new System.Windows.Forms.Label();
            this.regreso = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirManualDeUsuarioYTecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnestrella);
            this.panel1.Location = new System.Drawing.Point(39, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 244);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 163);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = " Cuadrado";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 89);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Linea";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnestrella
            // 
            this.btnestrella.Location = new System.Drawing.Point(12, 15);
            this.btnestrella.Margin = new System.Windows.Forms.Padding(2);
            this.btnestrella.Name = "btnestrella";
            this.btnestrella.Size = new System.Drawing.Size(71, 57);
            this.btnestrella.TabIndex = 0;
            this.btnestrella.Text = "Circulo";
            this.btnestrella.UseVisualStyleBackColor = true;
            this.btnestrella.Click += new System.EventHandler(this.btnestrella_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(39, 288);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 152);
            this.panel2.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 14);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 33);
            this.button6.TabIndex = 0;
            this.button6.Text = "Limpiar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 98);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 38);
            this.button7.TabIndex = 4;
            this.button7.Text = " Abrir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = " Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpdibujo);
            this.tabControl1.Location = new System.Drawing.Point(161, 23);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 513);
            this.tabControl1.TabIndex = 2;
            // 
            // tpdibujo
            // 
            this.tpdibujo.Location = new System.Drawing.Point(4, 22);
            this.tpdibujo.Margin = new System.Windows.Forms.Padding(2);
            this.tpdibujo.Name = "tpdibujo";
            this.tpdibujo.Padding = new System.Windows.Forms.Padding(2);
            this.tpdibujo.Size = new System.Drawing.Size(486, 487);
            this.tpdibujo.TabIndex = 1;
            this.tpdibujo.Text = "Dibujo1";
            this.tpdibujo.UseVisualStyleBackColor = true;
            this.tpdibujo.Click += new System.EventHandler(this.Tpdibujo_Click);
            // 
            // caja
            // 
            this.caja.Location = new System.Drawing.Point(671, 42);
            this.caja.Margin = new System.Windows.Forms.Padding(2);
            this.caja.Name = "caja";
            this.caja.Size = new System.Drawing.Size(240, 487);
            this.caja.TabIndex = 0;
            this.caja.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Archivo Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coordenada X: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Coordenada Y:";
            // 
            // setisx
            // 
            this.setisx.AutoSize = true;
            this.setisx.Location = new System.Drawing.Point(88, 442);
            this.setisx.Name = "setisx";
            this.setisx.Size = new System.Drawing.Size(13, 13);
            this.setisx.TabIndex = 0;
            this.setisx.Text = "0";
            // 
            // setisY
            // 
            this.setisY.AutoSize = true;
            this.setisY.Location = new System.Drawing.Point(88, 481);
            this.setisY.Name = "setisY";
            this.setisY.Size = new System.Drawing.Size(13, 13);
            this.setisY.TabIndex = 6;
            this.setisY.Text = "0";
            // 
            // regreso
            // 
            this.regreso.AutoSize = true;
            this.regreso.Location = new System.Drawing.Point(12, 507);
            this.regreso.Name = "regreso";
            this.regreso.Size = new System.Drawing.Size(0, 13);
            this.regreso.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.abrirManualDeUsuarioYTecnicoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.guardarToolStripMenuItem.Text = "Guardar Como";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
            // 
            // abrirManualDeUsuarioYTecnicoToolStripMenuItem
            // 
            this.abrirManualDeUsuarioYTecnicoToolStripMenuItem.Name = "abrirManualDeUsuarioYTecnicoToolStripMenuItem";
            this.abrirManualDeUsuarioYTecnicoToolStripMenuItem.Size = new System.Drawing.Size(200, 20);
            this.abrirManualDeUsuarioYTecnicoToolStripMenuItem.Text = "Abrir Manual de Usuario y Tecnico";
            this.abrirManualDeUsuarioYTecnicoToolStripMenuItem.Click += new System.EventHandler(this.AbrirManualDeUsuarioYTecnicoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 540);
            this.Controls.Add(this.setisY);
            this.Controls.Add(this.setisx);
            this.Controls.Add(this.regreso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caja);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnestrella;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpdibujo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RichTextBox caja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label setisx;
        private System.Windows.Forms.Label setisY;
        private System.Windows.Forms.Label regreso;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirManualDeUsuarioYTecnicoToolStripMenuItem;
    }
}

