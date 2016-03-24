using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WifiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpClient tcpClient = new TcpClient();

                Console.WriteLine("Connecting to ESPDuino... Enter ESPDuino IP address:");
                string ip = Console.ReadLine();

                Console.WriteLine("Enter ESPDuino Port:");
                string port = Console.ReadLine();

                tcpClient.Connect(ip, Int32.Parse(port));

                Console.WriteLine("Connected!");

                bool useTCP = true;

                while (useTCP)
                {
                    Console.Write("Enter the string to be transmitted: ");
                    string message = Console.ReadLine();

                    Stream stream = tcpClient.GetStream();
                    ASCIIEncoding asen = new ASCIIEncoding();
                    byte[] ba = asen.GetBytes(message);
                    Console.WriteLine("Transmitting...");

                    stream.Write(ba, 0, ba.Length);

                    byte[] bb = new byte[100];
                    int k = stream.Read(bb, 0, 100);

                    for (int i = 0; i < k; i++)
                    {
                        Console.Write(Convert.ToChar(bb[i]));
                    }

                    Console.WriteLine("Continue? Enter y/n");
                    useTCP = Console.Read() == 'y';
                }

                Console.WriteLine("Goodbye!");
                tcpClient.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.StackTrace);
            }
        }
    }
}
