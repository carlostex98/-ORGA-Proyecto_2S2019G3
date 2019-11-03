using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class boton:Button
    {
        public int cx;
        public int cy;
        public int valor;
        public boton()
        {
            this.Width = 60;
            this.Height = 30;
            this.Text = "";
            this.BackColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
            this.Click += new System.EventHandler(this.evento_click);
        }
        public boton(int cx, int cy)
        {
            this.Width = 60;
            this.Height = 30;
            this.Text = "";
            this.BackColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
            this.Location = new Point(cx, cy);
            this.Click += new System.EventHandler(this.evento_click);
            
        }
         Boolean estado = false;

        public void evento_click(object sender, EventArgs e)
        {
            if (!estado)
            {
                this.BackColor = Color.Black;
                estado = true;
            }
            else
            {
                this.BackColor = Color.White;
                estado = false;
            }
            
        }
       
        public void setEstado(bool estado)
        {
            this.estado = estado;
        }
        public int getCx()
        {
            return cx;
        }
        public int getCy() {
            return cy;
        }
        public void setCx(int cx) {
            this.cx = cx;
        }
        public void setCy(int cy) {
            this.cy = cy;
        }
        public bool getEstado() {
            return estado;
        }
    }
}
