using System;
using System.IO.Ports;

namespace ArduinoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort my = new SerialPort();
            my.BaudRate = 9600;
            my.PortName = "COM3";
            my.Open();

            while (true)
            {
                var s = Console.ReadLine();
                my.WriteLine(s);
            }

        }
    }
}
