using System;
using System.IO.Ports;

class Program
{
    static void Main()
    {
        SerialPort myPort = new SerialPort("COM9", 9600);
        myPort.Open();

        while (true)
        {
            string data = myPort.ReadLine();

            if (data == "REY_INVISIBLE_KEY_2025+1")

            {

                Console.WriteLine("Auth Success");

            }
        }
    }
}