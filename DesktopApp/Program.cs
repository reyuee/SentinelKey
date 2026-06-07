using System;
using System.IO.Ports;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("user32.dll")]
    public static extern bool LockWorkStation();

    static void Main()
    {
        // change the COM port
        // You can find the COM port in Device Manager or in the Arduino IDE

        SerialPort myPort = new SerialPort("COM13", 9600);

        myPort.DtrEnable = true;
        myPort.RtsEnable = true;

        myPort.Open();

        bool isAuthenticated = false;

        while (true)
        {
            try
            {
                string data = myPort.ReadLine();

                if (data.Trim() == "REY_INVISIBLE_KEY_2025+1")
                {
                    if (!isAuthenticated)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Auth Success");
                        isAuthenticated = true;

                        
                        Console.WriteLine("[AUTH] Valid key detected.");
                    }
                }
            }
            catch
            {
                LockWorkStation();
                break;

            }

          



        }
    }
}