using System;
using System.IO.Ports;

class Program
{
    static void Main()
    {
        SerialPort myPort = new SerialPort("COM13", 9600);

        myPort.DtrEnable = true;
        myPort.RtsEnable = true;

        myPort.Open();

        bool isAuthenticated = false;

        while (true)
        {
            string data = myPort.ReadLine();

            if (data.Trim() == "REY_INVISIBLE_KEY_2025+1")
            {
                if (!isAuthenticated)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Auth Success");

                    isAuthenticated = true;
                }
            }
        }
    }
}