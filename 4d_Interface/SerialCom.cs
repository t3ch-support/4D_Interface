using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4d_Interface
{
    class SerialCom
    {
        public bool isConnected = false;
        private readonly GuiForm _formHnd;
        public SerialPort port;
        

        public SerialCom(GuiForm form)
        {
            port = new SerialPort();
            _formHnd = form;
        }

        public void Connect(string portId, int baudRate)
        {
            if (port.IsOpen)
            {
                MessageBox.Show("already connected");
                return;
            }
            port = new SerialPort(portId, baudRate, Parity.None, 8, StopBits.One);
            port.Open();
            if (port.IsOpen)
            {
                MessageBox.Show("connection succesful");
                isConnected = true;
            }
        }

        public void WriteMessage(string msg)
        {
            port.WriteLine(msg);
        }
        public void Disconnect()
        {
            if (!port.IsOpen) return;
            port.Close();
        }
    }
}
