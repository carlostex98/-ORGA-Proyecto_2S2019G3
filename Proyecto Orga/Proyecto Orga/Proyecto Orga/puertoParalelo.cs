using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace WindowsFormsApplication1
{
	class puertoParalelo
	{
        private int PORT888 = 888;
        private int PORT898 = 898;
        private int PORT890 = 890;
        private byte D0;//envio de datos pin 2
        private byte D1;//envio de datos pin 3
        private byte D2; //linea D2 se conecta al pin 4 del puerto paralelo
        private byte D3; //linea D3 se conecta al pin 5 del puerto paralelo
        private byte D4; //linea D4 se conecta al pin 6 del puerto paralelo
        private byte D5; //linea D5 se conecta al pin 7 del puerto paralelo
        private byte D6; //linea D6 se conecta al pin 8 del puerto paralelo
        private byte D7; //linea D7 se conecta al pin 9 del puerto paralelo

        private byte STROBE;    //linea STROBE al pin 1 del puerto paralelo (-)
        private byte AUTOFEED;  //linea AUTOFEED al pin 14 del puerto paralelo (-)
        private byte INIT;      //linea INIT al pin 16 del puerto paralelo (-)
        private byte SELECT_IN; //linea SELECT_IN al pin 17 del puerto paralelo (-)

        private byte ERROR; //linea ERROR se conecta al pin 15 del puerto paralelo (-)
        private byte SLCT;  //linea SLCT se conecta al pin 13 del puerto paralelo (-)
        private byte PE;	   //linea PE se conecta al pin 12 del puerto paralelo (-)
        private byte ACK;   //linea ACK se conecta al pin 13 del puerto paralelo (-)
        private byte BUSY;  //linea BUSY se conecta al pin 11 del puerto paralelo
		
        public puertoParalelo() {
            D0 = 0;
            D1 = 0;
            Output();
            Input();
        }
        private void Input()
        {
            int i = 0;
            i = PortAccess.Input(PORT888);
            if (i == 128) D7 = 1; else D7 = 0;
            if (i == 64) D6 = 1; else D6 = 0;
            if (i == 32) D5 = 1; else D5 = 0;
            if (i == 16) D4 = 1; else D4 = 0;
            if (i == 8) D3 = 1; else D3 = 0;
            if (i == 4) D2 = 1; else D2 = 0;
            if (i == 2) D1 = 1; else D1 = 0;
            if (i == 1) D0 = 1; else D0 = 0;
            i = PortAccess.Input(PORT898);
            if (i == 128) BUSY = 0; else BUSY = 1;
            if (i == 64) ACK = 0; else ACK = 1;
            if (i == 32) PE = 0; else PE = 1;
            if (i == 16) SLCT = 0; else SLCT = 1;
            if (i == 8) ERROR = 0; else ERROR = 1;
            i = PortAccess.Input(PORT890);
            if (i == 8) SELECT_IN = 1; else SELECT_IN = 0;
            if (i == 4) INIT = 1; else INIT = 0;
            if (i == 2) AUTOFEED = 1; else AUTOFEED = 0;
            if (i == 1) STROBE = 1; else STROBE = 0;
        }
        public void Output() {
            PortAccess.Output(PORT888, D0 + D1 * 2 + D2 * 4 + D3 * 8 + D4 * 16 + D5 * 32 + D6 * 64 + D7 * 128);


            PortAccess.Output(PORT890, STROBE + AUTOFEED * 2 + INIT * 4 + SELECT_IN * 8);
            //PortAccess.Output(REG3, STROBE);
            //PortAccess.Output(REG3, STROBE + AUTOFEED * 2 + INIT * 4 + SELECT_IN * 8);
        }
        public void activa_D0()
        {
            D0 = 1;
            Output();
        }
          
        public void desactiva_D0()
        {
            D0 = 0;
            Output();
        }

        public void activa_D1()
        {
            D1 = 1;
            Output();
        }

        public void desactiva_D1()
        {
            D1 = 0;
            Output();
        }
        public void activa_INIT()
        {
            INIT = 0;
            Output();
        }
        public void desactiva_INIT()
        {
            INIT = 1;
            Output();
        }

        /************************** ESTADOS DEL PUERTO ************************/

        public int estado_D0()
        {
            Console.WriteLine("Estoy en el estado d0");
            Input();
            if (System.Convert.ToBoolean(D0)) return (1); else return (0);
        }

        public int estado_D1()
        {
            Input();
            if (System.Convert.ToBoolean(D1)) return (1); else return (0);
        }

        public int estado_D2()
        {
            Input();
            if (System.Convert.ToBoolean(D2)) return (1); else return (0);
        }

        public int estado_D3()
        {
            Input();
            if (System.Convert.ToBoolean(D3)) return (1); else return (0);
        }

        public int estado_D4()
        {
            Input();
            if (System.Convert.ToBoolean(D4)) return (1); else return (0);
        }

        public int estado_D5()
        {
            Input();
            if (System.Convert.ToBoolean(D5)) return (1); else return (0);
        }

        public int estado_D6()
        {
            Input();
            if (System.Convert.ToBoolean(D6)) return (1); else return (0);
        }

        public int estado_D7()
        {
            Input();
            if (System.Convert.ToBoolean(D7)) return (1); else return (0);
        }

        public int estado_STROBE()
        {
            Input();
            if (System.Convert.ToBoolean(STROBE)) return (0); else return (1);
        }

        public int estado_SLCT_IN()
        {
            Input();
            if (System.Convert.ToBoolean(SELECT_IN)) return (0); else return (1);
        }

        public int estado_AUTOFEED()
        {
            Input();
            if (System.Convert.ToBoolean(AUTOFEED)) return (0); else return (1);
        }

        public int estado_INIT()
        {
            Input();
            if (System.Convert.ToBoolean(INIT)) return (0); else return (1);
        }

        public int estado_ERROR()
        {
            Input();
            if (System.Convert.ToBoolean(ERROR)) return (0); else return (1);
        }

        public int estado_SLCT()
        {
            Input();
            if (System.Convert.ToBoolean(SLCT)) return (0); else return (1);
        }

        public int estado_PE()
        {
            Input();
            if (System.Convert.ToBoolean(PE)) return (0); else return (1);
        }

        public int estado_ACK()
        {
            Input();
            if (System.Convert.ToBoolean(ACK)) return (0); else return (1);
        }

        public int estado_BUSY()
        {
            Input();
            if (System.Convert.ToBoolean(BUSY)) return (1); else return (0);
        }
	}
}
