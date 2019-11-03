using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        boton[,] matrizBotones=new boton[8,16];
        int retardo = 200;
        puertoParalelo puerto = new puertoParalelo();
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    matrizBotones[i, j] = new boton(60 * i, 30 * j);
                    tpdibujo.Controls.Add(matrizBotones[i, j]);
                    matrizBotones[i, j].setCx(i);
                    matrizBotones[i, j].setCy(j);
                }
            }
        }

        private void btnestrella_Click(object sender, EventArgs e)
        {
            limpiar();
            matrizBotones[2, 6].setEstado(true);
            matrizBotones[3, 5].setEstado(true);
            matrizBotones[4, 5].setEstado(true);
            matrizBotones[5, 6].setEstado(true);
            matrizBotones[6, 7].setEstado(true);
            matrizBotones[6, 8].setEstado(true);
            matrizBotones[1, 7].setEstado(true);
            matrizBotones[1, 8].setEstado(true);
            matrizBotones[2, 9].setEstado(true);
            matrizBotones[3, 10].setEstado(true);
            matrizBotones[4, 10].setEstado(true);
            matrizBotones[5, 9].setEstado(true);
            colorear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        int datoX = 0;
        int datoY = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matrizBotones[j, i].getEstado())
                    {
                        datoX = matrizBotones[j, i].getCx();
                        datoY = matrizBotones[j, i].getCy();
                        //Console.WriteLine("x: " + matrizBotones[i, j].getCx() + " y: " + matrizBotones[i, j].getCy());
                       // MessageBox.Show("x: " + datoX + " y: " + datoY);
                        puerto.activa_INIT();
                        Thread.Sleep(retardo);
                        Console.WriteLine("Hay un 1 en: " +datoX+","+datoY); 
                    }
                    else
                    {
                        datoX = matrizBotones[j, i].getCx();
                        datoY = matrizBotones[j, i].getCy();
                        puerto.desactiva_INIT();
                        Thread.Sleep(retardo);
                        Console.WriteLine("Hay un 0 en: "+datoX+","+datoY);
                    }
                    if (j==7)
                    {
                        mandarInicio(j);  
                    }
                }
            }
        }
        private void mandarInicio(int n)
        {
            do
            {
                datoX = n;
                puerto.activa_INIT();
                Thread.Sleep(retardo);
                n -= 1;
                
                Console.WriteLine("Regresando a la posicion 0 en:"+datoX+","+datoY);
            } while (n != -1);
            Console.WriteLine();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            leerArchivo();
            mostrarEnPanel();
        }

        private void leerArchivo()
        {
            String texto;
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Seleccionar fichero";
            if (file.ShowDialog()==DialogResult.OK){
                texto = file.FileName;
                abrirTexto(texto,caja);
            }
        }

        char c;
        int estado = 0;
        string lexema = "";
        int CX = 0;
        int CY = 0;
        private void mostrarEnPanel()
        {
            limpiar();
            string entrada = caja.Text;
            for (int i = 0; i < entrada.Length; i++)
            {
                c = entrada.ElementAt(i);
                switch (estado)
                {
                    case 0:
                        if (Char.IsNumber(c) && entrada.ElementAt(i-4).Equals('X'))
                        {
                            estado = 1;
                            lexema += c;
                        }
                        else if (Char.IsNumber(c) && entrada.ElementAt(i - 4).Equals('Y'))
                        {
                            estado = 2;
                            lexema += c;
                        }
                        break;
                    case 1:
                        if (Char.IsNumber(c) && entrada.ElementAt(i - 5).Equals('X'))
                        {
                            estado = 1;
                            lexema += c;
                        }
                        else
                        {
                            CX = Int32.Parse(lexema);
                            estado = 0;
                            lexema = "";
                        }
                        break;
                    case 2:
                        if (Char.IsNumber(c) && entrada.ElementAt(i - 5).Equals('Y'))
                        {
                            estado = 2;
                            lexema += c;
                        }
                        else
                        {
                            CY = Int32.Parse(lexema);
                            estado = 0;
                            lexema = "";
                            matrizBotones[CX, CY].setEstado(true);
                        }
                        break;
                }

            }
            colorear();
        }
        public void abrirTexto(String text, RichTextBox caja) {
            int contador = 0;
            String linea = "";
            caja.Text = "";
            System.IO.StreamReader file = new System.IO.StreamReader(@text);
            while((linea = file.ReadLine())!= null){
                caja.Text += linea + "\r\n";
                contador++;
            }
            file.Close();
        }

        private void Tpdibujo_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            limpiar();
            matrizBotones[4, 1].setEstado(true);
            matrizBotones[4, 2].setEstado(true);
            matrizBotones[4, 3].setEstado(true);
            matrizBotones[4, 4].setEstado(true);
            matrizBotones[4, 5].setEstado(true);
            matrizBotones[4, 6].setEstado(true);
            matrizBotones[4, 7].setEstado(true);
            matrizBotones[4, 8].setEstado(true);
            matrizBotones[4, 9].setEstado(true);
            matrizBotones[4, 10].setEstado(true);
            matrizBotones[4, 11].setEstado(true);
            matrizBotones[4, 12].setEstado(true);
            matrizBotones[4, 13].setEstado(true);
            matrizBotones[4, 14].setEstado(true);
            colorear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            limpiar();
            matrizBotones[1, 2].setEstado(true);
            matrizBotones[2, 2].setEstado(true);
            matrizBotones[3, 2].setEstado(true);
            matrizBotones[4, 2].setEstado(true);
            matrizBotones[5, 2].setEstado(true);
            matrizBotones[6, 2].setEstado(true);
            matrizBotones[1, 2].setEstado(true);
            matrizBotones[6, 2].setEstado(true);
            matrizBotones[1, 3].setEstado(true);
            matrizBotones[6, 3].setEstado(true);
            matrizBotones[1, 4].setEstado(true);
            matrizBotones[6, 4].setEstado(true);
            matrizBotones[1, 5].setEstado(true);
            matrizBotones[6, 5].setEstado(true);
            matrizBotones[1, 6].setEstado(true);
            matrizBotones[6, 6].setEstado(true);
            matrizBotones[1, 7].setEstado(true);
            matrizBotones[6, 7].setEstado(true);
            matrizBotones[1, 8].setEstado(true);
            matrizBotones[6, 8].setEstado(true);
            matrizBotones[1, 9].setEstado(true);
            matrizBotones[6, 9].setEstado(true);
            matrizBotones[1, 10].setEstado(true);
            matrizBotones[6, 10].setEstado(true);
            matrizBotones[1, 11].setEstado(true);
            matrizBotones[6, 11].setEstado(true);
            matrizBotones[1, 12].setEstado(true);
            matrizBotones[6, 12].setEstado(true);
            matrizBotones[1, 13].setEstado(true);
            matrizBotones[2, 13].setEstado(true);
            matrizBotones[3, 13].setEstado(true);
            matrizBotones[4, 13].setEstado(true);
            matrizBotones[5, 13].setEstado(true);
            matrizBotones[6, 13].setEstado(true);
            colorear();
        }
        public void limpiar()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    matrizBotones[i, j].setEstado(false);
                    matrizBotones[i, j].BackColor = Color.White;
                }
            }
        }
        public void colorear()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (matrizBotones[i, j].getEstado())
                    {
                        matrizBotones[i, j].BackColor = Color.Black;
                    }
                }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            limpiar();
            caja.Text = "";
        }
    }
}
