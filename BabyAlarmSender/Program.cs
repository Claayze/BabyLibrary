using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace BabyAlarmSender
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int unitno = 1;
            int breath = 0;
            int cry = 0;
            bool running = true;
            //UdpClient client = new UdpClient();


            using (var client = new UdpClient())
            {
                while (running)

                {
                    try
                    {
                        breath = rnd.Next(8, 25);
                        cry = rnd.Next(0, 2);
                        string datatosend = $"{unitno},{breath},{cry}";
                        Byte[] databytes = Encoding.ASCII.GetBytes(datatosend);
                        Console.WriteLine(datatosend);
                        client.Send(databytes, databytes.Length, "127.0.0.1", 7000);
                        Thread.Sleep(5000);
                        Console.WriteLine(DateTime.Now.ToString());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        running = false;
                        //client.Dispose();
                    }

                }
            }
               

        }
    }
}
