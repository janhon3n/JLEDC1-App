using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLEDC1_App
{
    public class LEDCommander
    {

        byte[] bytes = new byte[5];
        SerialPort serialPort;

        public LEDCommander()
        {
            bytes[0] = 0xfe;
            bytes[4] = 0xff;
        }

        public static String[] GetComs()
        {
            return SerialPort.GetPortNames();
        }
        public void Connect(String com)
        {
            serialPort = new SerialPort(com, 9600, Parity.None, 8, StopBits.One);
            serialPort.Open();
        }
        public void SetRGB(byte red, byte green, byte blue)
        {
            SetByte(1, red);
            SetByte(2, green);
            SetByte(3, blue);
            this.transmit();
        }
        public void SetRed(byte red)
        {
            SetByte(1, red);
            this.transmit();
        }
        public void SetGreen(byte green)
        {
            SetByte(2, green);
            this.transmit();
        }
        public void SetBlue(byte blue)
        {
            SetByte(3, blue);
            this.transmit();
        }


        private void SetByte(int i, byte b)
        {
            Console.WriteLine("Setting bytes[" + i + "] to " + b);
            if(1 <= i && i <= 3 && 0 <= b && b <= 0xfd)
            {
                bytes[i] = b;
            } else
            {
                throw new ArgumentException("Illegal arguments");
            }
        }

        private void transmit()
        {
            Console.WriteLine("" + bytes[0] + "," + bytes[1] + "," + bytes[2] + "," + bytes[3] + "," + bytes[4]);
            Console.WriteLine(serialPort.PortName);
            serialPort.Write(bytes, 0, 5);
        }
    }
}
